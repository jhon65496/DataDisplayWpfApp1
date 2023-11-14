using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDisplayWpfApp1.Models;



namespace DataDisplayWpfApp1.Data
{
    public class DataContextApp
    {
        public DataContextApp()
        {
            GenerateDataСalculationIndex();
            
        }

        
        private ObservableCollection<IndexCalculation> calculationIndexes;
        public ObservableCollection<IndexCalculation> СalculationIndexes
        {
            get { return calculationIndexes; }
            set { calculationIndexes = value; }
        }

       
        public void GenerateDataСalculationIndex()
        {
            var calculationIndexes = new ObservableCollection<IndexCalculation>();
            for (int i = 1; i < 11; i++)
            {
                var indexCalculation = new IndexCalculation()
                {
                    Id = i,
                    Name = $"NameIndex-{i}",
                    Description = $"DescriptionIndex-{i}"
                };
                calculationIndexes.Add(indexCalculation);
            }

            СalculationIndexes = calculationIndexes;
        }
        
    }
}

