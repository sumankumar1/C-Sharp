using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryData.EntityModels
{
    public abstract class LibraryAsset
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public Status status { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,3)")]
        public decimal cost { get; set; }

        public string ImageUrl { get; set; }

        public int NumberOfCopies { get; set; }

        public virtual LibraryBranch Location {get; set;}
    }
}
