using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectExample
{
    class Color
    {
        public string name { get; set; }
        public string category { get; set; }
        public string type { get; set; }

        public override string ToString()
        {
            return string.Format("Color: {0} \nCategory: {1} \nType:{2}",name, category,type);
           
        }
    }
}
