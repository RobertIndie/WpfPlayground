using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using RE.MainProject.Model;

namespace RE.MainProject.ViewModel
{
    /* ViewBaseModel同时继承 ObservableObject类和ICleanup接口。
     * 所以同样有INotifyPropertyChanged接口的能力，
     * 能够通过触发PropertyChanged事件达到通知View的目的；
    */ 
    public class WelcomeViewModel : ViewModelBase
    {
        public WelcomeViewModel()
        {
            Welcome = new WelcomeModel() { Introduction = "Hello World" };
        }

        private WelcomeModel welcome;
        public WelcomeModel Welcome
        {
            get { return welcome; }
            set { welcome = value; RaisePropertyChanged(() => Welcome); }
        }
    }
}
