using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUI.viewmodels
{
    public class MainWindowViewModel : ReactiveObject
    {

        private int _SwitchView;
        public int SwitchView { get { return _SwitchView; } set { this.RaiseAndSetIfChanged(ref _SwitchView, value); } }


        public MainWindowViewModel()
        {
            SwitchSolutionBuild = SwitchSB();
            SwitchDataBaseBuild = SwitchDB();
            ConsoleOpen = OpenImpl();
            SwitchView = 0;
        }

        private ReactiveCommand OpenImpl()
        {
            return ReactiveCommand.Create(() =>
            {
                try
                {
                    Process.Start("PowerShellConsole.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
        }

        private ReactiveCommand SwitchDB()
        {
            return ReactiveCommand.Create(() =>
            {
                SwitchView = 1;
            });
        }

        private ReactiveCommand SwitchSB()
        {
            return ReactiveCommand.Create(() =>
            {
                SwitchView = 0;
            });
        }

        public ReactiveCommand SwitchSolutionBuild { get; set; }

        public ReactiveCommand SwitchDataBaseBuild { get; set; }

        public ReactiveCommand ConsoleOpen { get; set; }
        
    }
}
