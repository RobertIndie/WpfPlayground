using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using RE.MainProject.Model;
using ActiproSoftware.Windows.Controls.Ribbon;
using ActiproSoftware.Windows.Controls.Ribbon.Input;

namespace RE.MainProject.ViewModel
{
    public class XmlExplorerViewModel: ViewModelBase
    {
        private XmlExplorerModel xmlExplorer;
        public XmlExplorerViewModel()
        {
            XmlExplorer = new XmlExplorerModel();
            Messenger.Default.Register<bool>(this, "ShowXmlPanel", ShowXmlPanel);
        }

        public XmlExplorerModel XmlExplorer
        {
            get { return xmlExplorer; }
            set { xmlExplorer = value; RaisePropertyChanged(() => XmlExplorer); }
        }

        private void ShowXmlPanel(bool b)
        {
            xmlExplorer.IsShowed = !xmlExplorer.IsShowed;
            Console.WriteLine("XmlExplorerViewModel.ShowXmlPanel CALLED " + xmlExplorer.IsShowed);
        }

    }
}
