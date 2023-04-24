using AprLoader;
using AprLoaderNew.ViewModel;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AprLoaderNew
{
    public class ConsoleCommunication : IDisposable
    {
        AutoLoadingViewModel autoLoadingViewModel;
        private int LoadingProgress;

        public ConsoleCommunication()
        {           
            autoLoadingViewModel = new AutoLoadingViewModel();
            autoLoadingViewModel.isWeUseConsole = true;
        }

        [DllImport("kernel32")]
        public static extern void AllocConsole();

        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        /// <summary>
        /// Запуск консоли и предоставление инструментов для консольной загрузки.
        /// </summary>
        public void Communication()
        {
            LoadConsole();
            ExcelSelection();
        }

        /// <summary>
        /// Инициализация новой консоли.
        /// </summary>
        private void LoadConsole()
        {
            try
            {
                AllocConsole();
                TextWriter stdOutWriter = new StreamWriter(Console.OpenStandardOutput(), Console.OutputEncoding) { AutoFlush = true };
                TextWriter stdErrWriter = new StreamWriter(Console.OpenStandardError(), Console.OutputEncoding) { AutoFlush = true };
                TextReader strInReader  = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding);

                Console.SetOut(stdOutWriter);
                Console.SetError(stdErrWriter);
                Console.SetIn(strInReader);
                Console.Write("Доступна загрузка АПР-конфигураций.\n");
            }
            catch (Exception exc)
            {
                MessageBox.Show($"При попытке инициализировать консоль возникло исключение. {exc.Message}");
            }
        }

        /// <summary>
        /// Найти excel-файлы.
        /// </summary>
        /// <returns>Массив с именами найденных файлов.</returns>
        private string[] FindExcelFiles()
        {
            string[] files = Directory.GetFiles(path, "*.xlsx");
            return files;
        }

        public string path = "D:\\";

        /// <summary>
        /// Завершить работу с загрузкой АПР-параметров.
        /// </summary>
        private void Completion()
        {
            Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        /// Получить имя файла по его пути.
        /// </summary>
        /// <param name="path">Путь до файла.</param>
        /// <returns>Имя файла.</returns>
        private string GetNameFromPath(string path)
        {
            string[] splitFileName = path.Split('\\');
            string fileName = splitFileName[splitFileName.Length - 1].Split('.')[0];
            return fileName;
        }

        /// <summary>
        /// Создать строку для вывода на консоль при выборе excel-файла.
        /// </summary>
        /// <param name="array">Массив файлов.</param>
        /// <param name="element">Текущий файл.</param>
        private string MakeStringWithNumberForPrinting(string[] array, string? element)
        {
            string result = $"{Array.IndexOf(array, element) + 1}. {GetNameFromPath(element)}\n";
            return result;
        }

        /// <summary>
        /// Загрузить excel-файл.
        /// </summary>
        private void ExcelSelection()
        {
            try
            {
                string[] excelFiles = FindExcelFiles();
                if (excelFiles.Length == 0)
                {
                    Console.Write($"Подходящие excel-файлы по пути {path} не найдены.\n Пожалуйста, введите путь вручную (пример: C:\\Users\\Pikkio\\Desktop).");
                    path = Console.ReadLine();
                    ExcelSelection();
                }
                else
                {
                    Console.Write("Для выбора подходящего файла введите его номер.\n");
                }

                foreach (var file in excelFiles)
                {
                    Console.Write(MakeStringWithNumberForPrinting(excelFiles, file));
                }

                string indexOfSelectedFile = Console.ReadLine();
                if (!isUserAnswerCorrect(indexOfSelectedFile))
                {
                    ExcelSelection();
                }

                string pathOfSelectedFile = excelFiles[int.Parse(indexOfSelectedFile) - 1];
                autoLoadingViewModel.excelLoader = new ExcelLoader(pathOfSelectedFile);
                for (int i = 0; i < autoLoadingViewModel.excelLoader.DataSet.Tables.Count; i++)
                {
                    autoLoadingViewModel.excelLoader.DataSet.Tables[i].Rows.RemoveAt(0);
                    autoLoadingViewModel.excelLoader.DataSet.Tables[i].Rows.RemoveAt(0);
                    autoLoadingViewModel.excelLoader.DataSet.Tables[i].Rows.RemoveAt(0);
                }
                string nameOfSelectedFile = GetNameFromPath(pathOfSelectedFile);

                bool isConfigurationFoung = autoLoadingViewModel.FindConfiguration(nameOfSelectedFile);
                if (isConfigurationFoung)
                {
                    ActionBeforeConfigSelection();
                }
                else
                {
                    Console.Write("Для выбранного файла не найдены конфигурации.\n");
                    ExcelSelection();
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Возникла непредвиденная ошибка. Проверьте корректность имени загружаемого файла или его содержимого.\n{ex.Message}\n");
                ExcelSelection();
            }
            
        }

        /// <summary>
        /// Проверить корректность пользовательского ответа.
        /// </summary>
        private bool isUserAnswerCorrect(string answer)
        {
            int index;
            if (!int.TryParse(answer, out index))
            {
                Console.Write("Введите корректное значение. Например: 1\n");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Вернуться назад или перейти к выбору конфигураций.
        /// </summary>
        private void ActionBeforeConfigSelection()
        {
            Console.Write("Для выбранного файла найдены конфигурации.\n~ Введите 1 чтобы продолжить, 2 - вернуться к выбору файла\n");
            string numberOfSelecteAction = Console.ReadLine();
            if (!isUserAnswerCorrect(numberOfSelecteAction))
            {
                ActionBeforeConfigSelection();
            }
            switch (int.Parse(numberOfSelecteAction))
            {
                case 1:
                    ConfigurationSelection();
                    break;
                case 2:
                    ExcelSelection();
                    break;
                default:
                    Console.Write("Введено некорректное значение.\n");
                    ActionBeforeConfigSelection();
                    break;
            }
        }

        /// <summary>
        /// Выбрать конфигурацию.
        /// </summary>
        private void ConfigurationSelection()
        {
            try
            {
                Console.Write("~ Введите номер конфигурации\n");
                foreach (var supplyOption in autoLoadingViewModel.SupplyOptionItemSource)
                {
                    Console.Write($"{autoLoadingViewModel.SupplyOptionItemSource.IndexOf(supplyOption) + 1}. {supplyOption}\n");
                }

                string numberOfSelectedSuplOption = Console.ReadLine();
                if (!isUserAnswerCorrect(numberOfSelectedSuplOption))
                {
                    ConfigurationSelection();
                }

                if (int.Parse(numberOfSelectedSuplOption) < 1 || int.Parse(numberOfSelectedSuplOption) > autoLoadingViewModel.SupplyOptionItemSource.Count)
                {
                    Console.Write("Введено некорректное значение.\n");
                    ConfigurationSelection();
                }

                autoLoadingViewModel.SupplyOptionSelectedItem = autoLoadingViewModel.SupplyOptionItemSource[int.Parse(numberOfSelectedSuplOption) - 1];
                autoLoadingViewModel.ShowConfigSettings();
                foreach (var workSpace in autoLoadingViewModel.WorkSpaceItemSource)
                {
                    Console.Write($"---{workSpace}\n");
                    autoLoadingViewModel.WorkSpaceSelectedItem = workSpace;
                    autoLoadingViewModel.ShowLists();
                    foreach (var setting in autoLoadingViewModel.WorkStationsVM)
                    {
                        Console.Write($"      {setting.WorkStationSelectedItem} -> {setting.TechniqueSelectedItem}\n");
                    }
                }
                Console.Write("~ Загрузить конфигурацию: 1, назад: 2\n");
                string numberOfSelecteAction = Console.ReadLine();
                if (!isUserAnswerCorrect(numberOfSelecteAction))
                {
                    ConfigurationSelection();
                }

                switch (int.Parse(numberOfSelecteAction))
                {
                    case 1:
                        LoadApr();
                        break;
                    case 2:
                        ActionBeforeConfigSelection();
                        break;
                    default:
                        Console.Write("Введено некорректное значение.\n");
                        ConfigurationSelection();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write($"При обращении к конфигурациям возникла непредвиденная ошибка.\n{ex.Message}");
                ConfigurationSelection();
            }
        }

        /// <summary>
        /// Загрузить АПР-параметры.
        /// </summary>
        private void LoadApr()
        {
            try
            {
                LoadingProgress = 0;
                Console.Write("Загрузка началась, ожидайте.\n");
                Thread threadForLoading = new Thread(new ThreadStart(() => { autoLoadingViewModel.LoadingApr(); }));
                threadForLoading.Priority = ThreadPriority.Highest;
                threadForLoading.Start();

                Thread.Sleep(2000);
                while (LoadingProgress != 100)
                {
                    LoadingProgress = autoLoadingViewModel.CurrentProgress;

                    if (LoadingProgress == -1)
                    {
                        Console.Write($"При загрузке АПР-параметров возникла непредвиденная ошибка.\n");
                        ConfigurationSelection();
                    }

                    Console.Write($"Загружено {LoadingProgress}%\n");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                }

                Console.Write("Загрузка конфигурации успешно завершена.\n");
                ActionsAfterLoading();
            }
            catch (Exception ex)
            {
                Console.Write($"При загрузке АПР-параметров возникла непредвиденная ошибка.\n{ex.Message}");
                ConfigurationSelection();
            }            
        }

        /// <summary>
        /// Очистить последнюю строку консоли.
        /// </summary>
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        /// <summary>
        /// Выбрать действие после загрущки АПР-параметров: вернуться к выбору конфигураций или завершить работу с программой.
        /// </summary>
        private void ActionsAfterLoading()
        {
            try
            {
                Console.Write("~ Вернуться к выбору excel-файла: 1, завершить: 2\n");
                string numberOfSelecteAction = Console.ReadLine();

                if (!isUserAnswerCorrect(numberOfSelecteAction))
                {
                    ActionsAfterLoading();
                }

                switch (int.Parse(numberOfSelecteAction))
                {
                    case 1:
                        ExcelSelection();
                        break;
                    case 2:
                        Completion();
                        break;
                    default:
                        Console.Write("Введено некорректное значение.\n");
                        ActionsAfterLoading();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Возникла непредвиденная ошибка.\n{ex.Message}");
                ActionsAfterLoading();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
