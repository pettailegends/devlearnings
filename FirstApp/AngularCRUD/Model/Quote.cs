using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCRUD.Model
{
    public class Quote
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Desc { get; set; }
    }
}
