using Starcounter;
using System.Collections.Generic;
using System.Linq;
//using System;

namespace Articles
{
    partial class ArticleDetailPage: Json
    {
        public void Initialize(string objectId)
        {
            this.Article = Self.GET<ArticleDetailsPage>("/articles/partials/article/detail/" + objectId);
        }
    }
}
