using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Entities
{
    public class User
    {
        //количество побед вынести в отдельную сущность
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}
