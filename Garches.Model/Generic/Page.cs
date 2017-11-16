using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Garches.Model.Generic
{
    public class Page
    {
        public Page()
        {
            Pictures = new List<Picture>();
            Articles = new List<Article>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
