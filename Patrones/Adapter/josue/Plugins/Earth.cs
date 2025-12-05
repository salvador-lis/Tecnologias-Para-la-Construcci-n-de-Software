using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterDemo.Framework;

namespace AdapterDemo.Plugins
{
    public class Earth
    {
        public void Render(Spreadsheet _document)
        {
            Console.WriteLine("Rendering Earth Visible");
        }
    }
}