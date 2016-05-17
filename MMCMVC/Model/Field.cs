using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMCMVC.Model
{
    public class Field<T> : FieldBase
    {
        public Field(string Name)
            : base(Name)
        {
        }

        public virtual T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public override object GetValue()
        {
            return Value;
        }

        private T _value;
    }
}
