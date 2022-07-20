using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }
        public ItemCategory ItemCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
