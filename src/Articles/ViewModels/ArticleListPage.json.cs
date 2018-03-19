using Starcounter;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    partial class ArticleListPage: Json
    {
        public void Initialize()
        {
            this.Articles.Data = Db.SQL<Article>("SELECT a FROM Article a").Select(O => Self.GET<ArticleListItemPage>("/articles/partials/article/summary/" + O.GetObjectID()));
        }
    }
}
