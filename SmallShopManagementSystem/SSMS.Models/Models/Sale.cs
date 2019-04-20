using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMS.Models.Models
{
    public class Sale
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }


        public virtual List<PurchaseDetail> PurchaseDetailses { get; set; }
       
    }
}
