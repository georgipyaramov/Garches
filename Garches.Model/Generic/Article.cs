using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Garches.Model.Generic
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
        
        [ForeignKey("PageId")]
        public virtual int? PageId { get; set; }
        
        public virtual Page Page { get; set; }
    }
}
