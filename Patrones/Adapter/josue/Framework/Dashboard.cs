using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo.Framework
{
    public class Dashboard
    {
        private Spreadsheet _document;

        public Dashboard(Spreadsheet document)
        {
            _document = document;
        }

        public void Render(IGraphic graphic)
        {
            graphic.Generate(_document);
        }
    }
}