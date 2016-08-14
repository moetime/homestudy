namespace Home_Study.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Widget
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Widget Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        [MinLength(4)]
        [Display(Name ="Part Number")]
        public string PartNum { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Description")]
        public string Description { get; set; }
    }
}
