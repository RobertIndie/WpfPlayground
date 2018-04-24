using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace RE.MainProject.Model
{
    public class UserInfoModel : ViewModelBase
    {
        private String _userName;
        public String UserName
        {
            get { return _userName; }
            set { _userName = value; RaisePropertyChanged(() => UserName); }
        }
    }
}
