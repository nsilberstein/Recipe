using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeBizObjects
{
    public class BizUserName : BizObject<BizUserName>
    {
        string usernameval = "";
        public BizUserName()
        {

        }
        public int UserId
        {
            get => this.PrimaryKeyValue;
            set => PrimaryKeyValue = value;
        }


        public string UserName
        {
            get
            {
                return usernameval;
            }
            set
            {
                usernameval = value;
                InvokePropertyChanged();
            }
        }
    }
}
