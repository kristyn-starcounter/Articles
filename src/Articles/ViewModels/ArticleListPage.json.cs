using Starcounter;
using System.Collections.Generic;

namespace Articles
{
    partial class ArticleListPage: Json
    {
        public IEnumerable<Article> Articles = Db.SQL<Article>("SELECT a FROM Article a");
    }
}
