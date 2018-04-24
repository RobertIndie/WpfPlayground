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
        private HelloWorldModel _helloWorld;
        public HelloWorldModel HelloWorld
        {
            get { return _helloWorld; }
            set { _helloWorld = value; RaisePropertyChanged(() => HelloWorld); }
        }

        public HelloWorldViewModel()
        {
            Console.WriteLine("HelloWorldView Mounted");
            HelloWorld = new HelloWorldModel();
        }

        private string _info = "Hello World?";
        public string Info
        {
            get { return _info; }
            set { _info = value; RaisePropertyChanged(() => Info); }
        }

    }
}
