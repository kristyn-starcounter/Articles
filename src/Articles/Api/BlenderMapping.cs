using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    static class BlenderMapping
    {
        public static void Register()
        {
            Blender.MapUri2<Article>("/articles/partials/article/summary/{?}", new[] {"small"});
            Blender.MapUri2<Article>("/articles/partials/article/detail/{?}", new[] { "detail" });
        }
    }
}
