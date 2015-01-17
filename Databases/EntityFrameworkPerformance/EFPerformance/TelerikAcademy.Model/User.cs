namespace TelerikAcademy.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPassword { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public DateTime? LastLogin { get; set; }

        public int? GroupID { get; set; }

        public virtual Group Group { get; set; }
    }
}
