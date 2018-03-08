using System;
using Starcounter;
using System.Linq;
using System.Collections.Generic;
using Starcounter.Advanced.XSON;

namespace Articles
{
    class Program
    {
        static void Main()
        {
            Db.Transact(() =>
            {
                Db.SQL("DELETE FROM Article");
            });

            Db.Transact(() =>
            {
                new Article { ArtName = "Kangaroo", ArtDescript = "A bouncy little friend you never want to box with", ArtPrice = 314.00M };
                new Article { ArtName = "Penguin", ArtDescript = "Formally dressed water torpedoes", ArtPrice = 73.00M };
                new Article { ArtName = "Lion", ArtDescript = "What your cat aspires to be", ArtPrice = 109.00M };
                new Article { ArtName = "Gator", ArtDescript = "The symbol for rednecks all over Florida", ArtPrice = 803.00M };
                new Article { ArtName = "Ostrich", ArtDescript = "A giant, awkward bird that can't fly", ArtPrice = 573.00M };
                new Article { ArtName = "Racoon", ArtDescript = "Essentially a trash Panda", ArtPrice = 200.00M };
            });

            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            MainHandlers.Register();
        }
    }
}