using System.ComponentModel.DataAnnotations;

namespace LibraryData.EntityModels
{
    public class Video: LibraryAsset
    {
        [Required]
        public string Director { get; set; }
    }
}
