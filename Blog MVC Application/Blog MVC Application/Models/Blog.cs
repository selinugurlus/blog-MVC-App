﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_MVC_Application.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Statement { get; set; }
        public string Content { get; set; }
        public DateTime UploadDate { get; set; }
        public bool Confirm { get; set; }
        public bool Home { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; } // for foreign key
        public Category Category { get; set; }


    }
}