using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineHubApi.Models
{
    public class Post
    {
        public int PostID{ get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
