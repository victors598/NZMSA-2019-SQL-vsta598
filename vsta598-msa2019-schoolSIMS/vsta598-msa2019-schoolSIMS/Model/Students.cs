using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vsta598_msa2019_schoolSIMS.Model
{
    [Table("students")]
    public partial class Students
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("phone_number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("dob", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column("date_created", TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        [Column("middle_names")]
        [StringLength(100)]
        public string MiddleNames { get; set; }
        [Column("average_gpa")]
        public double? AverageGpa { get; set; }
    }
}
