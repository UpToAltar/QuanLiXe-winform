using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe.DatabaseHelper
{
    public class DbParamsSProduce
    {
        public string Name { get; set; }

        public object Value { get; set; }

        public SqlDbType Type { get; set; }

        public DbParamsSProduce(string name, object value, SqlDbType type)
        {
            this.Name = name;
            this.Value = value;
            this.Type = type;
        }
    }
}
