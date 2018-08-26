using MyUI.models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.IO;

namespace MyUI.viewmodels
{
    public class DataBaseBuildVM : ReactiveObject
    {
        public Service sc;
        private string _selectedVersion;
        public string selectedVersion { get { return _selectedVersion; } set { this.RaiseAndSetIfChanged(ref _selectedVersion, value); } }

        private string _Username;
        public string Username { get { return _Username; } set { this.RaiseAndSetIfChanged(ref _Username, value); } }

        private string _Server;
        public string Server { get { return _Server; } set { this.RaiseAndSetIfChanged(ref _Server, value); } }

        private int _Mode;
        public int Mode { get { return _Mode; } set { this.RaiseAndSetIfChanged(ref _Mode, value); } }

        private string _LongViewpath;
        public string LongViewpath { get { return _LongViewpath; } set { this.RaiseAndSetIfChanged(ref _LongViewpath, value); } }

        public DataBaseBuildVM()
        {
            try
            {
                Server = String.Empty;
                Username = String.Empty;
                sc = new Service();
                selectedVersion = "7530";
                Mode = 0;
                v1 = VersionSelection("7530");
                v2 = VersionSelection("7500");
                v3 = VersionSelection("7400");
                v4 = VersionSelection("7300");
                v5 = VersionSelection("7200");

                first = ModeSelection(0);

                second = ModeSelection(1);
                Clean = CleanDirectory();

                third = ModeSelection(2);

                DataSource = Open();

                folderplus = getfolder();

                Build = CreateScript();

                CreateDB = DBCreation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                File.AppendAllText("log.txt", ex.ToString());
                    
            }

        }

        private ReactiveCommand CleanDirectory()
        {
            return ReactiveCommand.Create(() =>
            {
                try
                {

                    DirectoryInfo directory = new DirectoryInfo(@LongViewpath + "\\Database\\OutputFiles");
                    directory.GetFiles().ToList().ForEach(f => f.Delete());
                    MessageBox.Show("All FIles Are Deleted !");
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
        }

        private ReactiveCommand CreateScript()
        {
            return ReactiveCommand.Create(() =>
            {
                try
                {

                
                int d;
                int.TryParse(selectedVersion,out d);
                if (sc.IsValidPath(@LongViewpath + "\\Database"))
                {
                    sc.CreateScript("SQL_APPLY_MSFT","Build",LongViewpath,"Database.sln",d);
                    sc.DataBaseScript(LongViewpath, Server, Mode,selectedVersion);
                }
                else
                {
                    MessageBox.Show("Path Not Valid !");
                }
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
        }

        private ReactiveCommand getfolder()
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

        private ReactiveCommand DBCreation()
        {
            return ReactiveCommand.Create(() =>
            {
                try { 
                
                sc.CreationDB(Username, Server, selectedVersion);
                MessageBox.Show("DataBase Created !");
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    File.AppendAllText("log.txt", ex.ToString());

                }
            });
        }

        private ReactiveCommand Open()
        {
            return ReactiveCommand.Create(() =>
            {
                try
                {

                
               Process.Start(@"C:\Windows\System32\odbcad32.exe");
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    File.AppendAllText("log.txt", ex.ToString());

                }
            });
        }

        private ReactiveCommand ModeSelection(int p)
        {
            return ReactiveCommand.Create(() =>
            {
                Mode = p;
            });
        }

        private ReactiveCommand VersionSelection(string p)
        {
            return ReactiveCommand.Create(() =>
            {
                selectedVersion = p;
            });
        }

        public ReactiveCommand v1 { get; set; }

        public ReactiveCommand v2 { get; set; }

        public ReactiveCommand v3 { get; set; }

        public ReactiveCommand v4 { get; set; }

        public ReactiveCommand v5 { get; set; }

        public ReactiveCommand first { get; set; }

        public ReactiveCommand second { get; set; }

        public ReactiveCommand third { get; set; }

        public ReactiveCommand DataSource { get; set; }

        public ReactiveCommand CreateDB { get; set; }

        public ReactiveCommand folderplus { get; set; }

        public ReactiveCommand Build { get; set; }

        public ReactiveCommand Clean { get; set; }




    }
}
