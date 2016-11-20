using BJ.TypesEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Entities
{
    public class Card
    {
        public Sing Sing { get; set; }
        public Suit Suit { get; set; }
        public int QuantityPoints { get; set; }
    }
}
