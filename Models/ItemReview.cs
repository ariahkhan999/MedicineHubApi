using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class ItemReview
    {
        public int ItemReviewID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Item Item { get; set; }
    }
}
