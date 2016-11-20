using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Entities
{
    public class User
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public int QuantityOfWins { get; set; } 
    }
}
