using DataDisplayWpfApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDisplayWpfApp1.Data;
using System.Diagnostics;

namespace DataDisplayWpfApp1.ViewModels.Views
{
    public class IndexesViewModel : BaseVM
    {   
        ManagerIndexesViewModel managerIndexesViewModel;
        
        DataContextApp DataContextApp;

        public IndexesViewModel(ManagerIndexesViewModel managerIndexesViewModel)
        {   

            this.managerIndexesViewModel = managerIndexesViewModel;
            this.DataContextApp = this.managerIndexesViewModel.DataContextApp;

            СalculationIndexs = DataContextApp.СalculationIndexes;            
        }

        public IndexesViewModel(DataContextApp DataContextApp)
        {
            this.DataContextApp = DataContextApp;

            СalculationIndexs = DataContextApp.СalculationIndexes;
        }




        private ObservableCollection<IndexCalculation> calculationIndexs;

        public ObservableCollection<IndexCalculation> СalculationIndexs
        {
            get { return calculationIndexs; }
            set 
            { 
                calculationIndexs = value;
                RaisePropertyChanged(nameof(СalculationIndexs));
            }
        }

        private IndexCalculation selectedIndexCalculation;

        public IndexCalculation SelectedIndexCalculation
        {
            get { return selectedIndexCalculation; }
            set 
            { 
                selectedIndexCalculation = value;
             
                this.managerIndexesViewModel.SelectedIndexCalculation = selectedIndexCalculation;                

                RaisePropertyChanged(nameof(SelectedIndexCalculation));
            }
        }

        
        public void LoadDataTest2()
        {
            СalculationIndexs = this.DataContextApp.СalculationIndexes;                       
        }

        
    }
}
