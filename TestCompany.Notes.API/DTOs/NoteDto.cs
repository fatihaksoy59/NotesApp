using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCompany.Notes.API.DTOs
{
    public class NoteDto
    {
        public int Id { get; set; }

        [Required]
        public string NoteName { get; set; }
        [Required]
        public string NoteData { get; set; }
    }
}
