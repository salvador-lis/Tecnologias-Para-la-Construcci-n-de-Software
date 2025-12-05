using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterDemo.Plugins;

namespace AdapterDemo.Framework
{
    public class EarthAdapter : IGraphic
    {
        private Earth earth;

        public EarthAdapter(Earth eart)
        {
            this.earth = eart;
        }

        public void Generate(Spreadsheet doc)
        {
            earth.Render(doc);
        }
    }
}