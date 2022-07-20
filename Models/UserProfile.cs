using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class UserProfile
    {
        public int UserProfileID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
    }
}
