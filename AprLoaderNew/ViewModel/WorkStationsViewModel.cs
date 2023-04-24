using AprLoaderNew.Models;
using AprLoaderNew.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AprLoaderNew.ViewModel
{
    public class WorkStationsViewModel : ViewModelBase
    {
        public WorkStationsViewModel(int id)
        {
            technique = TechniqueData.Technique;
            workStations = TechniqueData.WorkStations;
            Id = id;
        }

        public delegate void DeleteElement(int id);

        public DeleteElement deleteElement;

        public delegate void ChangedElement();

        public ChangedElement changedElement;

        public int Id;

        private ObservableCollection<TechniqueEnum> technique;
        public ObservableCollection<TechniqueEnum> TechniqueItemSource { get => technique; set { technique = value; OnPropertyChanged(); } }

        private ObservableCollection<string> workStations;
        public ObservableCollection<string> WorkStationsItemSource { get => workStations; set { workStations = value; OnPropertyChanged(); } }

        private string workStationSelectedItem;
        public string WorkStationSelectedItem { get => workStationSelectedItem; set { workStationSelectedItem = value; changedElement(); OnPropertyChanged(); } }

        private TechniqueEnum techniqueSelectedItem;
        public TechniqueEnum TechniqueSelectedItem { get => techniqueSelectedItem; set { techniqueSelectedItem = value; changedElement(); OnPropertyChanged(); } }

        public ICommand DeleteItem
        {
            get
            {
                return new RelayCommand(
                    param =>
                    {
                        deleteElement(Id);
                    });               
            }
        }

    }
}
