﻿namespace NTS.Client.Models
{
    public class SharedNotes
    {
        public Guid FavoriteNoteId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public Guid NoteId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } =DateTime.Now;
        public string Color { get; set; } = string.Empty;
    }
}
