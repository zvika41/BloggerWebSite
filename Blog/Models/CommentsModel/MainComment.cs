﻿using System.Collections.Generic;

namespace Blog.Models.CommentsModel
{
    public class MainComment : Comment
    {
        public List<SubComment> SubComments { get; set; }
    }
}
