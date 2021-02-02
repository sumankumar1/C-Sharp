using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryData.EntityModels
{
    public class LibraryCard
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(6,3)")]
        public decimal Fees { get; set; }

        public DateTime Created { get; set; }

        public virtual IEnumerable<CheckOut> CheckOuts { get; set; }

    }
}
