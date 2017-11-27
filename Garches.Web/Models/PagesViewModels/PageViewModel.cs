using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garches.Web.Models.PagesViewModels
{
    public class PageViewModel
    {
        public string Name { get; set; }

        public ArticleViewModel HeadArticle { get; set; }

        public ArticleViewModel SideArticle { get; set; }

        public ArticleViewModel BottonArticle { get; set; }

    }
}
