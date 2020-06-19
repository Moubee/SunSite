﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post
    {
        public string Id { get; set; }
        public string CreatorId { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastModified  { get; set; }

        public string Data { get; set; }
    }
}
