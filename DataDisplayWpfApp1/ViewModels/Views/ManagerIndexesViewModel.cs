using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDisplayWpfApp1.Models;
using DataDisplayWpfApp1.Views.Views;
using DataDisplayWpfApp1.Data;


namespace DataDisplayWpfApp1.ViewModels.Views
{
    public class ManagerIndexesViewModel : BaseVM
    {
        IndexesViewModel IndexesViewModel2 { get; }
        
        public DataContextApp DataContextApp;


        public ManagerIndexesViewModel(DataContextApp DataContextApp)
        {
            this.DataContextApp = DataContextApp;

            IndexesViewModel2 = new IndexesViewModel(this);

        }

        private IndexCalculation selectedIndexCalculation;

        public IndexCalculation SelectedIndexCalculation
        {
            get { return selectedIndexCalculation; }
            set
            {
                selectedIndexCalculation = value;

                RaisePropertyChanged(nameof(SelectedIndexCalculation));          
            }
        }


    }
}
