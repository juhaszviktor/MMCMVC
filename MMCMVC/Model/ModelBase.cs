using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMCMVC.ConfigStore;

namespace MMCMVC.Model
{
    public class ModelBase
    {
        private Dictionary<String, FieldBase> fields;

        public ModelBase()
        {
            fields = new Dictionary<string, FieldBase>();
        }

        public void Add(FieldBase item)
        {
            fields.Add(item.Name, item);
        }

        public FieldBase Get(string Name)
        {
            return fields[Name];
        }

        public void Save(ConfigStore.ConfigStore store)
        {
            store.Save("");
        }

    }
}
