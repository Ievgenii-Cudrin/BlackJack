using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Entities
{
    public class Comp
    {
        const string name = "Comp";
        public string Name { get { return name; } }
        public List<Card> Cards { get; set; }
    }
}
