using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDisplayWpfApp1.Data;
using DataDisplayWpfApp1.Models;
using DataDisplayWpfApp1.ViewModels.Views;

namespace DataDisplayWpfApp1.ViewModels
{
    internal class MainWindowViewModel : BaseVM
    {
        
        public IndexesViewModel indexesViewModel;        
        public ManagerIndexesViewModel managerIndexesViewModel;        
        DataContextApp DataContextApp;
        
        public MainWindowViewModel()
        {
            // this.appManager = appManager;

            DataContextApp = new DataContextApp();

            managerIndexesViewModel = new ManagerIndexesViewModel(DataContextApp);
            indexesViewModel = new IndexesViewModel(DataContextApp);
            
            LoadItemMainMenu();
        }


        #region Title
        private string title = "App `DataDisplayWpfApp1`. Prop title";
        
        public string Title 
        {
            get { return title; }
            set { title = value; }
        }
        #endregion

        #region mainMenuItems        
        private ObservableCollection<MainMenuItemMainWindow> mainMenuItems;

        public ObservableCollection<MainMenuItemMainWindow> MainMenuItems
        {
            get { return mainMenuItems; }
            set
            {
                mainMenuItems = value;
                RaisePropertyChanged(nameof(MainMenuItemMainWindow));
            }
        }
        #endregion

        #region SelectedItem
        private MainMenuItemMainWindow selectedMainMenuItem;

        public MainMenuItemMainWindow SelectedMainMenuItem
        {
            get { return selectedMainMenuItem; }
            set 
            {                 
                selectedMainMenuItem = value;                
                
                SwitchView(selectedMainMenuItem.Alias);

                RaisePropertyChanged(nameof(CurrentView));
            }
        }
        #endregion


        private BaseVM currentView;
        public BaseVM CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                RaisePropertyChanged(nameof(CurrentView));
            }
        }

        
        private string titleDetail = "TitleDetail";

        public string TitleDetail
        {
            get { return titleDetail; }
            set 
            { 
                titleDetail = value;
                Debug.WriteLine($"titleDetail -- {titleDetail}");
                RaisePropertyChanged(nameof(TitleDetail));
            }
        }
        

       
        public void LoadItemMainMenu()
        {
            mainMenuItems = new ObservableCollection<MainMenuItemMainWindow>()
            {
                new MainMenuItemMainWindow(){ Name = "Управление коэффициентами", Alias ="ManagerIndexes" },
                new MainMenuItemMainWindow(){ Name = "Коэффициенты", Alias ="Indexes"  },
                new MainMenuItemMainWindow(){ Name = "Поставщки", Alias ="Provider"  }
            };
        }

        public void SwitchView(string nameView)
        {
            switch (nameView)
            {
                case "ManagerIndexes":                    
                    CurrentView = managerIndexesViewModel;
                    break;

                case "Indexes":                    
                    CurrentView = indexesViewModel;
                    break;
            }
        }

    }
}
