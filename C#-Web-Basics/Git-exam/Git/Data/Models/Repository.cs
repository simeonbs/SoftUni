using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Data.Models
{
    public class Repository
    {
        [Key]
        [Required]
        [MaxLength(40)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsPublic { get; set; }

        [Required]
        public string OwnerId { get; set; }

        public User Owner { get; set; }

        public IEnumerable<Commit> Commits { get; init; } = new List<Commit>();
    }
}
