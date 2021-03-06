﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Core.Domains.Feed
{
    [BsonIgnoreExtraElements]
    public class FeedItem : BaseEntity
    {
        public bool IsPublished { get; set; } = true;
        [Required]
        public string StatusType { get; set; }
        [Required]
        public FeedItemType Type { get; set; }
        [Required]
        public string Text { get; set; }

        public string OperationStatus { get; set; } = $"Process";

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
             ApplyFormatInEditMode = true)]             
        public DateTimeOffset PublishedDate { get; set; } = DateTimeOffset.UtcNow;

        public string PublishedUserId { get; set; } // need fill this userid

        public byte[] Image { get; set; }

        [BsonIgnoreIfNull]
        public virtual List<Comment> Comments
            {
                get { return _comments;
                }
                set { _comments = value ?? new List<Comment>();
                }
            }
        private List<Comment> _comments = new List<Comment>();
        
        [BsonIgnoreIfNull]
        public virtual IList<Like> Likes
        {
            get
            {
                return _likes;
            }
            set
            {
                _likes = value ?? new List<Like>();
            }
        }
        private IList<Like> _likes = new List<Like>();
        
        public string PreciseText { get; set; }

        public string PreciseTextByUserId { get; set; }
        //public List<PreciseHistory> History { get; set; }

        

    }
}
