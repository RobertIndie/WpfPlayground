using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using RE.MainProject.Model;

namespace RE.MainProject.ViewModel
{
    public class UserInfoViewModel : ViewModelBase
    {
        public UserInfoViewModel()
        {
            UserInfo = new UserInfoModel();
        }

        private UserInfoModel userInfo;
        public UserInfoModel UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; RaisePropertyChanged(() => UserInfo); }
        }

    }
}
