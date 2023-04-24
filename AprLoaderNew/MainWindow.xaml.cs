using MultiScreen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows;

namespace AprLoaderNew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            bool isConsoleInit = false;
            foreach (string s in System.Environment.GetCommandLineArgs())
            {
                if (s == "console")
                {
                    isConsoleInit = true;
                    Application.Current.Shutdown();
                    ConsoleCommunication console = new ConsoleCommunication();
                    console.Communication();
                    return;
                }
            }

            if (!isConsoleInit)
            {
                InitializeComponent();
            }
        }
    }
}
