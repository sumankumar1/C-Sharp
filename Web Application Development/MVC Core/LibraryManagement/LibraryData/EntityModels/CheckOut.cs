

using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.EntityModels
{
    public class CheckOut
    {
        public int Id { get; set; }

        [Required]
        public LibraryAsset LibraryAsset { get; set; }

        [Required]
        public LibraryCard LibraryCard { get; set; }
        
        [Required]
        public DateTime Since { get; set; }
        public DateTime? Until { get; set; }
    }
}
