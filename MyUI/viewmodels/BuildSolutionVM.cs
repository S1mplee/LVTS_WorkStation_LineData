using MyUI.models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace MyUI.viewmodels
{
    public class BuildSolutionVM :ReactiveObject
    {
        private string _path;
        public string path { get { return _path; } set { this.RaiseAndSetIfChanged(ref _path, value); } }

        private int _selectedVersion;
        public int selectedVersion { get { return _selectedVersion; } set { this.RaiseAndSetIfChanged(ref _selectedVersion, value); } }

        private string _RockWave;
        public string RockWave { get { return _RockWave; } set { this.RaiseAndSetIfChanged(ref _RockWave, value); } }

        private string _Codejock;
        public string Codejock { get { return _Codejock; } set { this.RaiseAndSetIfChanged(ref _Codejock, value); } }

        Service sc = new Service();
        // Constructor 
        public BuildSolutionVM()
        {
            selected = 0;
            selectedVersion = 7530;
            
            getList();
            RockWave = list[0].RockWave;
            Codejock = list[0].CodejockWave;
            // Buttons (Clean / Build )
            Build = BuildCommand();
            Clean = CleanCommand();
            // selected Items of versions !
            v2 = changeSelectedItem(1,7500);
            v1 = changeSelectedItem(0,7530);
            v3 = changeSelectedItem(2,7400);
            v4 = changeSelectedItem(3,7300);
            v5 = changeSelectedItem(4,7200);
            // folder path
            folderplus = getpath();


        }

        private ReactiveCommand getpath()
        {
            return ReactiveCommand.Create(() =>
            {
                using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                    path = dialog.SelectedPath;
                }
            });
        }
        // change the selected items in the combo box
        private ReactiveCommand changeSelectedItem(int p,int version)
        {
            return ReactiveCommand.Create(() => { selected = p;
            selectedVersion = version;
            RockWave = list[p].RockWave;
            Codejock = list[p].CodejockWave;

            });
        }
        // Clean Implementation
        private ReactiveCommand CleanCommand()
        {
            return ReactiveCommand.Create(() => {
               
            });
        }
        // Build Implementation
        private ReactiveCommand BuildCommand()
        {
            return ReactiveCommand.Create(() => {

                ExecuteBuild();
            });
        }

        private void ExecuteBuild()
        {
            File.AppendAllText("log.txt", " << Building Project V : " + selectedVersion + " >> \r\n");
            if (!sc.IsValidPath(@path) )
            {
                File.AppendAllText("log.txt", "Folder does Not Existe \r\n");
                MessageBox.Show("Folder does Not Existe");
            }
            else if (!sc.IsValidPath((path+"\\Rogue Wave"))) {
                File.AppendAllText("log.txt", "MISSING ROGUE WAVE ! \r\n");
                MessageBox.Show("MISSING ROGUE WAVE !");
            }
            else if (!sc.IsValidPath((path+"\\Codejock Software"))) {
                File.AppendAllText("log.txt", "MISSING Codejock Software ! \r\n");
                MessageBox.Show("MISSING Codejock Software !");
            }
            else if (!sc.IsValidPath("C:\\Users\\"+Environment.UserName+"\\AppData\\Local\\Microsoft\\MSBuild\\v4.0")) {
                File.AppendAllText("log.txt", "MISSING Visual Studio Build tools (2013)! \r\n");
                MessageBox.Show("MISSING MISSING Visual Studio Build tools !");
            }
           /* else if (!sc.PerlVerif()) {
                File.AppendAllText("log.txt", "MISSING Perl! \r\n");
                MessageBox.Show("You need to install Perl !");
            }*/
          //  sc.Update_MSBUILD(RockWave, Codejock, selectedVersion, path);
            File.AppendAllText("log.txt", "Updated Path Environement ! \r\n");
            sc.editingFile(RockWave,Codejock,selectedVersion,path);
            File.AppendAllText("log.txt", "Updated Microsoft.cpp files  ! \r\n");

        }

       

        
        // Data Need it to build the Solutions
        private void getList()
        {
            list = new ReactiveList<LongView>();
            list.Add(new LongView() { RockWave = "Rogue Wave\\Stingray Studio 12.1", CodejockWave = "Codejock Software\\MFC\\Xtreme ToolkitPro v17.3.0", Version = 7530 });
            list.Add(new LongView() { RockWave = "Rogue Wave\\Stingray Studio 2006vc120", CodejockWave = "Codejock Software\\MFC\\Xtreme ToolkitPro v16.4.0", Version = 7500 });
            list.Add(new LongView() { RockWave = "Rogue Wave\\Stingray Studio 2006vc100", CodejockWave = "Codejock Software\\MFC\\Xtreme ToolkitPro v15.2.1", Version = 7400 });
            list.Add(new LongView() { RockWave = "Rogue Wave\\Stingray Studio 2006vc100", CodejockWave = "Codejock Software\\MFC\\Xtreme ToolkitPro v15.2.1", Version = 7300 });
            list.Add(new LongView() { RockWave = "Rogue Wave\\Stingray Studio 2006vc100", CodejockWave = "Codejock Software\\MFC\\Xtreme ToolkitPro v13.3.1", Version = 7200 });
        }


        private int _selected;
        public int selected { get { return _selected; } set { this.RaiseAndSetIfChanged(ref _selected, value); } }

        private string _resultat;

        public string resultat { get { return _resultat; } set { this.RaiseAndSetIfChanged(ref _resultat, value); } }

        public ReactiveList<LongView> list { get; set; }

        public ReactiveCommand Build { get; set; }

        public  ReactiveCommand Clean { get; set; }

        public ReactiveCommand v1 { get; set; }

        public ReactiveCommand v2 { get; set; }

        public ReactiveCommand v3 { get; set; }

        public ReactiveCommand v4 { get; set; }

        public ReactiveCommand v5 { get; set; }

        public ReactiveCommand folderplus { get; set; }


        
    }
}
