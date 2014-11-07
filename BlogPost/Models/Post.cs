﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPost.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string[] Tags { get; set; }
    }
}