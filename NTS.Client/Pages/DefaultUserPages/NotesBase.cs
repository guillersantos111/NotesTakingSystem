﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Razor;
using MudBlazor;
using NTS.Client.Components;
using NTS.Client.Models.DTOs;
using NTS.Client.Services.Contracts;

namespace NTS.Client.Pages.DefaultUserPages
{
    public class NotesBase : ComponentBase
    {
        [Inject] public INotesService notesService { get; set; }
        [Inject] public ISnackbar snackbar { get; set; }
        [Inject] public IDialogService dialogService { get; set; }

        public readonly DialogOptions dialogOptions = new DialogOptions()
        {
            MaxWidth = MaxWidth.Small,
            FullWidth = true,
            NoHeader = true,
        };

        public List<NoteDto> notes = new();
        public bool isLoggedIn = false;
        public bool isFetched = false;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                notes = await notesService.GetAllNotesAsync();
                isFetched = true;
            }
            catch (Exception error)
            {
                snackbar.Add($"Failed To Load Notes: {error.Message}", Severity.Error);
                isFetched = false;
            }
        }


        public async Task OpenCreateNoteDialogAsync()
        {
            try
            {
                var parameters = new DialogParameters<CreateNoteDialog>();
                var dialog = dialogService.Show<CreateNoteDialog>("Create Note", parameters, dialogOptions);
                var result = await dialog.Result;

                if (!result.Canceled)
                {
                    snackbar.Add("Note Created Successfully!", Severity.Success);
                    notes = await notesService.GetAllNotesAsync();
                }
            }
            catch (Exception error)
            {
                snackbar.Add($"Faild To Refresh Notes :{error.Message}", Severity.Error);
            }
        }

        public string GetNoteCardClass(NoteDto note)
        {
            return note.Priority switch
            {
                "High" => "high-priority",
                "Low" => "low-priority",
                "Normal" => "normal-priority",
                _ => "normal-priority"
            };
        }
    }
}
