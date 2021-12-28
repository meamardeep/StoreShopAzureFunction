using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreShop.Function
{
    public class Model
    {
    }

    public class SMS
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Phone { get; set; }
        public bool IsSent { get; set; }
    }
}
