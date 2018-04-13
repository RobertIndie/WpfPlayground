using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace RE.MainProject.Model
{
    public class UserInfoModel : ObservableObject
    {
        private String userName;
        public String UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(() => UserName); }
        }

        private Int64 userPhone;
        public Int64 UserPhone
        {
            get { return userPhone; }
            set { userPhone = value; RaisePropertyChanged(() => UserPhone); }
        }

        private Int32 userSex;
        public Int32 UserSex
        {
            get { return userSex; }
            set { userSex = value; RaisePropertyChanged(() => UserSex); }
        }

        private String userAdd;
        public String UserAdd
        {
            get { return userAdd; }
            set { userAdd = value; RaisePropertyChanged(() => UserAdd); }
        }
    }
}
