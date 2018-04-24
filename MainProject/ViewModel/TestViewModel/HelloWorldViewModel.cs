using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RE.MainProject.Model;
using GalaSoft.MvvmLight;

namespace RE.MainProject.ViewModel
{
    public class HelloWorldViewModel: ViewModelBase
    {
        public HelloWorldViewModel()
        {
            Console.WriteLine("HelloWorldView Mounted");
        }

        private string _info = "Hello World!?";
        public string Info
        {
            get { return _info; }
            set { _info = value; RaisePropertyChanged(() => Info); }
        }

    }
}
