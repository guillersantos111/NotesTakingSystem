﻿using NTS.Server.Entities;
using NTS.Server.Entities.DTOs;
using System.Threading.Tasks;

namespace NTS.Server.Services.Contracts
{
    public interface INotesService
    {
        Task<NotesBase?> CreateNoteAsync(CreateNotesDto request, Guid userId);

        Task<NotesBase> EditNotesAsync(EditNotesDto editNotesDto, Guid noteId, Guid userId);

        Task<bool> RemoveNoteAsync(Guid noteId);

        Task<NotesBase> GetNoteByIdAsync(Guid noteId);

        Task<IEnumerable<NotesBase>> GetAllNotesAsync(Guid userId);

        Task<IEnumerable<NotesBase>> SearchNotesAsync(string searchTerm, Guid userId);

        Task<bool> MarkNoteAsFavoriteAsync(Guid noteId, Guid userId);

        Task<bool> MarkNoteAsImportantAsync(Guid noteId, Guid userId);

        Task<bool> MarkNoteAsSharedAsync(Guid noteId, Guid userId, Guid sharedWithUserId);

        Task<bool> MarkNoteAsStarredAsync(Guid noteId, Guid userId);
    }
}