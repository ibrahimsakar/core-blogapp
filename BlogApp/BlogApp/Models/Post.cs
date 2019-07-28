﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}