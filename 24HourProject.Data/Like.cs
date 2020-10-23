﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Data
{
    public class Like
    {
        [Required]
        [ForeignKey(nameof(Post))]
        public Post LikedPost { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public Guid OwnerId { get; set; }
        public User Liker { get; set; }
        [Required]
        public int LikeId { get; set; }
    }
}