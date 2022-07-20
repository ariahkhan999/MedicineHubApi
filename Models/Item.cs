using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Disease Disease { get; set; }
        public ItemCategory ItemCategory { get; set; }

    }
}
