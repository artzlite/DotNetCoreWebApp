using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebAppBasic.Models.PagingList
{
    public class DatableOption
    {
        public int pageIndex { get; set; }
        public string sortExpression { get; set; }
    }
}
