using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Data;

namespace GameData
{
    public class ManualBindingProperty : IPropertyInfo
    {
        public bool IsResolved
        {
            get
            {
                return true;
            }
        }

        public Type PropertyType
        {
            get
            {
                return typeof(int);
            }
        }

        public object GetValue(object obj)
        {
            return 10;
        }

        public object GetValue(object obj, object[] index)
        {
            return 0;
        }

        public void SetValue(object obj, object value)
        {            
        }

        public void SetValue(object obj, object value, object[] index)
        {            
        }
    }
}
