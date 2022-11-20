using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Translation { get; set; }
        public string? Transcription { get; set; }
        public string? Description { get; set; }
        public int Progress { get; set; } = 0;

        [Required]
        public int WordsId { get; set; }
        [Required]
        public Words Words { get; set; }

    }
}
