using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMS.Models.Models
{
    public class PurchaseDetail
    {
        public long Id { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }


        public long ProductId { get; set; }
        public virtual Product Purchase { get; set; }
    }
   
}
