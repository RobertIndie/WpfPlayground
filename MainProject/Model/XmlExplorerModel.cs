using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace RE.MainProject.Model
{
    public class XmlExplorerModel : ObservableObject
    {
        private bool isShowed;
        public bool IsShowed
        {
            get { return isShowed; }
            set { isShowed = value; RaisePropertyChanged(() => IsShowed); }
        }
    }
}
