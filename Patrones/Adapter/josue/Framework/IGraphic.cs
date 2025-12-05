using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo.Framework
{
    public interface IGraphic
    {
        void Generate(Spreadsheet);
    }
}