using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using RE.MainProject.Model;

namespace RE.MainProject.ViewModel
{
    public class DockSiteViewModel : ViewModelBase
    {
        public DockSiteViewModel()
        {
            DockSite = new DockSiteModel();
        }

        private DockSiteModel dockSite;
        public DockSiteModel DockSite
        {
            get { return dockSite; }
            set { dockSite = value; RaisePropertyChanged(() => DockSite); }
        }
    }
}
