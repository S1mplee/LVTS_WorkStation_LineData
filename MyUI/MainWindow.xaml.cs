using MyUI.models;
using MyUI.viewmodels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataContext = new BuildSolutionVM();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataContext = new DataBaseBuildVM();
        }

        private void Button_ClickAsync(object sender, RoutedEventArgs e)
        {

            try
            {
                Process.Start("PowerShellConsole.exe");

            
          //  Process.Start("ConsoleEdit.exe",".\\Build.ps1");  
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
              
        }
    }
}
