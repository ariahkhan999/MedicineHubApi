using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class Wishlist
     
    {
        public int WishlistID { get; set; }
        public Item item { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
