using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class RequestItem
    {
        public int RequestItemID { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestQuantity { get; set; }
        public Item Item { get; set; }


    }
}
