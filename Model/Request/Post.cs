using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Request
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ImageUr { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Username { get; set; }
    }
}
