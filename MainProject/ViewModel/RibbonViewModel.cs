using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using RE.MainProject.Basic;
using RE.MainProject.Model;

namespace RE.MainProject.ViewModel
{
    public class RibbonViewModel : ViewModelBase
    {
        public RibbonViewModel()
        {
            Console.WriteLine("RibbonView Mounted");
            Ribbon = new RibbonModel();
        }

        private RibbonModel ribbon;
        public RibbonModel Ribbon
        {
            get { return ribbon; }
            set { ribbon = value; RaisePropertyChanged(() => Ribbon); }
        }

        private bool canExecute;
        public bool CanExecute
        {
            get { return canExecute; }
            set { canExecute = value; }
        }

        private MyCommand showXmlExplorerCommand;
        public MyCommand ShowXmlExplorerCommand
        {
            get
            {
                if (showXmlExplorerCommand == null)
                    showXmlExplorerCommand = new MyCommand(new Action<object>(o => {
                        Console.Write("命令可以执行");
                        Messenger.Default.Send<bool>(true, "ShowXmlPanel");
                    }));
                return showXmlExplorerCommand;
            }
        }

    }
}
