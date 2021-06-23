using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Data.Models
{
    public class Commit
    {
        [Key]
        [Required]
        [MaxLength(40)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Required]
        public string CreatorId { get; set; }

        public User Creator { get; set; }

        [Required]
        public string RepositoryId { get; set; }

        public Repository Repository { get; set; }
    }
}
