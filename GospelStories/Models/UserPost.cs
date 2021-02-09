using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GospelStories.Models
{
    public class UserPost
    {
        [Key]
        public int UserPostID { get; set; }

        public string PostContent { get; set; }

        public string PostImage { get; set; }

        public DateTime DateTime { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public UserModel UserModel { get; set; }
    }
}
