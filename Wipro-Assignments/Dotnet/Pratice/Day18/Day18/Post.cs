
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodeFirstApproach
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string PostDescription { get; set; }
        public System.DateTime CreationDate { get; set; }
        //public string quantity { get; set; }    
        public Nullable<int> BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
