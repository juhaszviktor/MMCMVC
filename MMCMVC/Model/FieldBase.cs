using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMCMVC.Model
{
    public abstract class FieldBase
    {
        public FieldBase(string Name)
        {
            _name = Name;
        }

        private readonly string _name;

        public abstract object GetValue();
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
