using Starcounter;

namespace Articles
{
    static class MainHandlers
    {
        public static void Register()
        {
            Handle.GET("/articles", () =>
            {
                var p = new ArticleListPage ();
                p.Initialize();
                return p;
            });

            Handle.GET("/articles/detail/{?}", (string objectId) =>
            {
                var p = new ArticleDetailPage();
                p.Initialize(objectId);
                return p;
            });

            Handle.GET("/articles/partials/article/detail/{?}", (string objectId) =>
            {
                return new ArticleDetailsPage() { Data = Db.FromId<Article>(objectId) };
            });

            Handle.GET("/articles/partials/article/summary/{?}", (string objectId) =>
            {
                return new ArticleListItemPage() { Data = Db.FromId<Article>(objectId) };
            });
        }
    }
}
