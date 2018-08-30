using MyUI.models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
namespace MyUI.viewmodels
{
    public class BuildSolutionVM :ReactiveObject
    {
        private string _LongViewpath;
        public string LongViewpath { get { return _LongViewpath; } set { this.RaiseAndSetIfChanged(ref _LongViewpath, value); } }

        private string _logfile;

        private string _RogueWavepath;
        public string RogueWavepath { get { return _RogueWavepath; } set { this.RaiseAndSetIfChanged(ref _RogueWavepath, value); } }

        private string _Xceed;
        public string Xceed { get { return _Xceed; } set { this.RaiseAndSetIfChanged(ref _Xceed, value); } }

        private int _Selectedsolution;
        public int Selectedsolution { get { return _Selectedsolution; } set { this.RaiseAndSetIfChanged(ref _Selectedsolution, value); } }

        private string _Solution;
        public string Solution { get { return _Solution; } set { this.RaiseAndSetIfChanged(ref _Solution, value); } }

        private string _CodeJockpath;
        public string CodeJockpath { get { return _CodeJockpath; } set { this.RaiseAndSetIfChanged(ref _CodeJockpath, value); } }

        private int _selectedVersion;
        public int selectedVersion { get { return _selectedVersion; } set { this.RaiseAndSetIfChanged(ref _selectedVersion, value); } }

        private string _RockWave;
        public string RockWave { get { return _RockWave; } set { this.RaiseAndSetIfChanged(ref _RockWave, value); } }

        private string _Codejock;
        public string Codejock { get { return _Codejock; } set { this.RaiseAndSetIfChanged(ref _Codejock, value); } }

        private string _Mode;
        public string Mode { get { return _Mode; } set { this.RaiseAndSetIfChanged(ref _Mode, value); } }

        Service sc = new Service();
        // Constructor 
        public BuildSolutionVM()
        {
            selected = 0;
            selectedVersion = 7530;
            Selectedsolution = 1;
            Mode = "Debug";
            _logfile = String.Empty;
            getList();
            Solution = Solutionlist[1];
            RockWave = list[0].RockWave;
            Codejock = list[0].CodejockWave;
            // Buttons (Clean / Build / OpenSolution / Configure )
            Build = BuildCommand();
            Clean = CleanCommand();
            OpenSolution = Opensolutioncommand();
            Configure = ConfigureCommand();
            // selected Items of versions !
            v2 = changeSelectedItem(1,7500,0);
            v1 = changeSelectedItem(0,7530,1);
            v3 = changeSelectedItem(2,7400,0);
            v4 = changeSelectedItem(3,7300,0);
            v5 = changeSelectedItem(4,7200,0);
            // folder path
            folderplus = getpath1();
            folderplus2 = getpath2();
            folderplus3 = getpath3();
            folderplus4 = getpath4();
            debug = changeToDebug();
            release = changeToRelease();
        }

        private ReactiveCommand Opensolutioncommand()
        {
            return ReactiveCommand.Create(() =>
            {
                OpenSoltutionImpl();
            });
        }

        private void OpenSoltutionImpl()
        {
            try
            {

           
            if (!sc.IsValidPath(@LongViewpath+"\\Database"))
            {
                MessageBox.Show("Path Not Valid !");
            }
            else
            {
                if (selectedVersion > 7300)
                {
                    Process.Start(@"C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe", @LongViewpath + "\\" + Solution );
                }
                else
                {
                    Process.Start(@"C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\devenv.exe", @LongViewpath + "\\" + Solution);
                }
            }
                 }
            catch (Exception ex)
            {
                File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                File.AppendAllText(".\\logs\\" + _logfile + "log.txt", ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

       

        private ReactiveCommand ConfigureCommand()
        {
            return ReactiveCommand.Create(() =>
            {
                ExecuteBuild();
            });
        }

        private ReactiveCommand changeToRelease()
        {
            return ReactiveCommand.Create(() =>
            {
                Mode = "Release";
            });
        }

        private ReactiveCommand changeToDebug()
        {
            return ReactiveCommand.Create(() =>
            {
                Mode = "Debug";
            });
        }

        private ReactiveCommand getpath4()
        {
            return ReactiveCommand.Create(() =>
            {
                using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                    Xceed = dialog.SelectedPath;
                }
            });
        }

        private ReactiveCommand getpath1()
        {
            return ReactiveCommand.Create(() =>
            {
                using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                    LongViewpath = dialog.SelectedPath;
                }
            });
        }

        private ReactiveCommand getpath2()
        {
            return ReactiveCommand.Create(() =>
            {
                using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                    RogueWavepath = dialog.SelectedPath;
                }
            });
        }

        private ReactiveCommand getpath3()
        {
            return ReactiveCommand.Create(() =>
            {
                using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                    CodeJockpath = dialog.SelectedPath;
                }
            });
        }
        // change the selected items in the combo box
        private ReactiveCommand changeSelectedItem(int p,int version,int s)
        {
            return ReactiveCommand.Create(() => { selected = p;
            Selectedsolution = s;
            Solution = Solutionlist[s];
            selectedVersion = version;
            RockWave = list[p].RockWave;
            Codejock = list[p].CodejockWave;

            });
        }
        // Clean Implementation
        private ReactiveCommand CleanCommand()
        {
            return ReactiveCommand.Create(() => {
                try
                {
                    LogFile();
                    CleanScript();
                }
                catch (Exception ex)
                {
                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", ex.ToString());
                    MessageBox.Show(ex.ToString());
                }
               
            });
        }

        private void CleanScript()
        {
            if (!sc.IsValidPath(@LongViewpath))
            {
                MessageBox.Show("LongView Path is Not Valid");
            }
            else
            {

                sc.CreateScript(Mode, "Clean", LongViewpath, Solution, selectedVersion, ".\\logs\\" + _logfile + "log.txt");
                MessageBox.Show("Script Created ! ");
            }
        }
        // Build Implementation
        private ReactiveCommand BuildCommand()
        {
            return ReactiveCommand.Create(() => {
                LogFile();
                BuildScript();
            });
        }

        private void BuildScript()
        {
            try
            {


                if (!sc.IsValidPath(@LongViewpath))
                {
                    MessageBox.Show("LongView Path is Not Valid");
                }
                else
                {

                    sc.CreateScript(Mode, "Build", LongViewpath, Solution, selectedVersion, ".\\logs\\" + _logfile + "log.txt");
                    MessageBox.Show("Script Created ! ");
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                File.AppendAllText(".\\logs\\" + _logfile + "log.txt", ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExecuteBuild()
        {
            try
            {
                LogFile();
                File.AppendAllText(".\\logs\\" + _logfile + "log.txt", " << Building Project V : " + selectedVersion + " >> \r\n");
                if (!sc.IsValidPath(@LongViewpath+"\\Database"))
                {
                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "Folder does Not Existe \r\n");
                    MessageBox.Show("LongView Path is Not Valid");
                }
                else if (!sc.IsValidPath(@RogueWavepath))
                {
                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "MISSING ROGUE WAVE ! \r\n");
                    MessageBox.Show("MISSING ROGUE WAVE !");
                }
                else if (!sc.IsValidPath(@CodeJockpath + "\\" + Codejock))
                {
                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "Codejock Software path Not Valid \r\n");
                    MessageBox.Show("MISSING Codejock Software Are you missing \\MFC ? ! !");
                }
                else if (!sc.IsValidPath("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Microsoft\\MSBuild\\v4.0"))
                {
                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "MISSING Visual Studio Build tools (2013)! \r\n");
                    MessageBox.Show("MISSING MISSING Visual Studio Build tools !");
                }
                else if (!sc.PerlVerif())
                {
                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "MISSING Perl! \r\n");
                    MessageBox.Show("You need to install Perl !");
                }
                else
                {
                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");


                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "Updated Path Environement ! \r\n");
                    sc.editingFile(RockWave, Codejock, selectedVersion, RogueWavepath, CodeJockpath, Xceed);
                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                    File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "Updated Microsoft.cpp files  ! \r\n");
                    sc.Update_MSBUILD(RockWave, Codejock, selectedVersion, RogueWavepath, CodeJockpath);
                    MessageBox.Show("Machine Configurated ! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                File.AppendAllText(".\\logs\\" + _logfile + "log.txt", "                                 ***************************************************                             \r\n");

                File.AppendAllText(".\\logs\\" + _logfile + "log.txt", ex.ToString());

                
            }

        }

       

        
        // Data Need it to build the Solutions
        private void getList()
        {
            list = new ReactiveList<LongView>();
            list.Add(new LongView() { RockWave = "Stingray Studio 12.1", CodejockWave = "Xtreme ToolkitPro v17.3.0", Version = 7530 });
            list.Add(new LongView() { RockWave = "Stingray Studio 2006vc120", CodejockWave = "Xtreme ToolkitPro v16.4.0", Version = 7500 });
            list.Add(new LongView() { RockWave = "Stingray Studio 2006vc100", CodejockWave = "Xtreme ToolkitPro v15.2.1", Version = 7400 });
            list.Add(new LongView() { RockWave = "Stingray Studio 2006vc100", CodejockWave = "Xtreme ToolkitPro v15.2.1", Version = 7300 });
            list.Add(new LongView() { RockWave = "Stingray Studio 2006vc100", CodejockWave = "Xtreme ToolkitPro v13.3.1", Version = 7200 });

            Solutionlist = new ReactiveList<string>();
            Solutionlist.Add("LVTradingSystem10.sln");
            Solutionlist.Add("Shared.sln");
            Solutionlist.Add("Server.sln");
            Solutionlist.Add("Client.sln");

        }

        private void LogFile()
        {
            if (_logfile == String.Empty)
            {
                DateTime d = DateTime.Today;
                var d2 = DateTime.Now;
                string d3 = d2.ToString();
                _logfile = Regex.Replace(d3, "/", "_");
                _logfile = Regex.Replace(_logfile, " ", "_");
                _logfile = Regex.Replace(_logfile, ":", "_");
            }
        }


        private int _selected;
        public int selected { get { return _selected; } set { this.RaiseAndSetIfChanged(ref _selected, value); } }

        private string _resultat;

        public string resultat { get { return _resultat; } set { this.RaiseAndSetIfChanged(ref _resultat, value); } }

        public ReactiveList<LongView> list { get; set; }

        public ReactiveList<string> Solutionlist { get; set; }


        public ReactiveCommand Build { get; set; }

        public ReactiveCommand  Clean { get; private set; }

        public ReactiveCommand v1 { get; set; }

        public ReactiveCommand v2 { get; set; }

        public ReactiveCommand v3 { get; set; }

        public ReactiveCommand v4 { get; set; }

        public ReactiveCommand v5 { get; set; }

        public ReactiveCommand folderplus { get; set; }

        public ReactiveCommand folderplus2 { get; set; }

        public ReactiveCommand folderplus3 { get; set; }

        public ReactiveCommand folderplus4 { get; set; }

        public ReactiveCommand debug { get; set; }

        public ReactiveCommand release { get; set; }

        public ReactiveCommand Configure { get; set; }

        public ReactiveCommand OpenSolution { get; set; }







        
    }
}
