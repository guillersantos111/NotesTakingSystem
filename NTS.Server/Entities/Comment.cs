﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NTS.Server.Entities
{
    public class Comment
    {
        [Key]
        public Guid CommentId { get; set; }

        public Guid SharedNoteId { get; set; }

        public Guid NoteId { get; set; }
        
        public Guid UserId { get; set; }

        [StringLength(100), Required]
        public string FullName { get; set; } = string.Empty;

        public string CommentContent { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
