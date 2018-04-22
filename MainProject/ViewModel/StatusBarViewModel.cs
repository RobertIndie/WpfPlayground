using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using RE.MainProject.Model;

namespace RE.MainProject.ViewModel
{
    public class StatusBarViewModel : ViewModelBase
    {
        public StatusBarViewModel()
        {
            Console.WriteLine("DockSiteView Mounted");
            StatusBar = new StatusBarModel();
        }

        private StatusBarModel statusBar;
        public StatusBarModel StatusBar
        {
            get { return statusBar; }
            set { statusBar = value; RaisePropertyChanged(() => StatusBar); }
        }
    }
}
