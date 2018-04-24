/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:RE.MainProject"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace RE.MainProject.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<HelloWorldViewModel>();
            SimpleIoc.Default.Register<BindDisplayViewModel>();
            SimpleIoc.Default.Register<XmlExplorerViewModel>();
            SimpleIoc.Default.Register<DockSiteViewModel>();
            SimpleIoc.Default.Register<RibbonViewModel>();
            SimpleIoc.Default.Register<StatusBarViewModel>();
            SimpleIoc.Default.Register<SampleData>();
        }
        
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public HelloWorldViewModel HelloWorld
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HelloWorldViewModel>();
            }
        }
        public BindDisplayViewModel BindDisplay
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BindDisplayViewModel>();
            }
        }
        public SampleData Data
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SampleData>();
            }
        }
        public XmlExplorerViewModel XmlExplorer
        {
            get
            {
                return ServiceLocator.Current.GetInstance<XmlExplorerViewModel>();
            }
        }
        public DockSiteViewModel DockSite
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DockSiteViewModel>();
            }
        }
        public RibbonViewModel Ribbon
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RibbonViewModel>();
            }
        }
        public StatusBarViewModel StatusBar
        {
            get
            {
                return ServiceLocator.Current.GetInstance<StatusBarViewModel>();
            }
        }


        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}