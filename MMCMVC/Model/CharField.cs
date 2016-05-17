using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMCMVC.Model
{
    public class CharField: Field<string>
    {
        public CharField(string Name): base(Name)
        {
        }

        public CharField(string Name, string Value) : base(Name)
        {
            this.Value = Value;
        }
    }
}
