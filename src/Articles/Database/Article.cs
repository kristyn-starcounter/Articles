using Starcounter;
using System.Collections.Generic;

namespace Articles
{
    [Database]
    public class Article
    {
        public string Key => this.GetObjectID();
        public string ArtName { get; set; }
        public string ArtDescript { get; set; }
        public decimal ArtPrice { get; set; }
    }
}