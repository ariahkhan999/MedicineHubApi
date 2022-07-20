using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class Store

    {
        public int StoreID { get; set; }
        public Item Item { get; set; }
        public City City { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
