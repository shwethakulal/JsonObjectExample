using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace JsonObjectExample
{
    class Program
    {
        public static void displayColorDetails(Color color)
        {
            Console.WriteLine("Color name:{0}",color.name);
            Console.WriteLine("Color category:{0}", color.category);
            Console.WriteLine("Color type:{0}", color.type);
        }
        static void Main(string[] args)
        {
           
            string jsondata = File.ReadAllText(@"data\JSONdata.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();

            List<Color> colors = ser.Deserialize<List<Color>>(jsondata);
            foreach (Color color in colors)
            {
                displayColorDetails(color);
               
            }

            Console.ReadKey();



        }
    }
}
