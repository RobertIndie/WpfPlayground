using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace RE.MainProject.Model
{
    /* ObservableObject 类保证能够检测属性是否被改变。
     * 它实现了INotifyPropertyChanged接口，能触发PropertyChanged事件达到通知UI更改的目的；
     * 所以我们在定义实体对象的时候，只需要调用RaisePropertyChanged(PropertyName)就可以进行属性更改通知了。
     * 实体里面定义的每个属性都加上RaisePropertyChanged的调用，就可以实现对UI的交互更新了。
    */
    public class WelcomeModel : ObservableObject
    {
        private String introduction;

        public String Introduction
        {
            get { return introduction; }
            set { introduction = value; RaisePropertyChanged(() => Introduction); }
        }
    }
}
