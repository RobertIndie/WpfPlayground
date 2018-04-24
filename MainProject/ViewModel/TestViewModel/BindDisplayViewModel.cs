using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using RE.MainProject.Model;

namespace RE.MainProject.ViewModel
{
    public class BindDisplayViewModel : ViewModelBase
    {
        private UserInfoModel _userInfo;
        public UserInfoModel UserInfo
        {
            get { return _userInfo; }
            set { _userInfo = value; RaisePropertyChanged(() => UserInfo); }
        }

        public BindDisplayViewModel()
        {
            UserInfo = new UserInfoModel();
            Console.WriteLine("BindDisplayView Mounted");
        }
    }
}
