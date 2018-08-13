using MyUI.models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace MyUI.viewmodels
{
    public class BuildSolutionVM :ReactiveObject
    {
        Service sc = new Service();
        public BuildSolutionVM()
        {
            selected = 0;
            getList();
            // Buttons (Clean / Build )
            Build = BuildCommand();
            Clean = CleanCommand();
            // selected Items of versions !
            v2 = changeSelectedItem(1);
            v1 = changeSelectedItem(0);
            v3 = changeSelectedItem(2);
            v4 = changeSelectedItem(3);
            v5 = changeSelectedItem(4);



        }
        // change the selected items in the combo box
        private ReactiveCommand changeSelectedItem(int p)
        {
            return ReactiveCommand.Create(() => selected = p);
        }
        // Clean Implementation
        private ReactiveCommand CleanCommand()
        {
            return ReactiveCommand.Create(() => {
                sc.AutoBuild("Clean");
                MessageBox.Show("Hello");
            });
        }
        // Build Implementation
        private ReactiveCommand BuildCommand()
        {
            return ReactiveCommand.Create(() => sc.AutoBuild("Build"));
        }

        
        // Data Need it to build the Solutions
        private void getList()
        {
            list = new ReactiveList<LongView>();
            list.Add(new LongView() { RockWave = "test1", CodejockWave = "test2", Version = 7500 });
            list.Add(new LongView() { RockWave = "test2", CodejockWave = "test64562", Version = 7500 });
            list.Add(new LongView() { RockWave = "test3", CodejockWave = "test4562", Version = 7500 });
            list.Add(new LongView() { RockWave = "test4", CodejockWave = "test246", Version = 7500 });
            list.Add(new LongView() { RockWave = "test5", CodejockWave = "test246", Version = 7500 });


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


        
    }
}
