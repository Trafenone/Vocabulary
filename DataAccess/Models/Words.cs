using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Words
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Word> ListWords { get; set; } = new();

        [Required]
        public int GroupId { get; set; }
        [Required]
        public Group Group { get; set; }
    }
}
