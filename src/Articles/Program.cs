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
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());
            MainHandlers.Register();
            BlenderMapping.Register();
        }
    }
}