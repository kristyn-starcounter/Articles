using Starcounter;

namespace Articles
{
    static class MainHandlers
    {
        public static void Register()
        {
            Handle.GET("/Articles", () =>
            {
                return new ArticleListPage ();
            });

            Handle.GET("/Articles/detail/{?}", (string objectId) =>
            {
                return new ArticleDetailPage() { Data = Db.FromId<Article>(objectId) };
            });
        }
    }
}
