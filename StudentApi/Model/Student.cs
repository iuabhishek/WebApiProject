using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Model
{
    public class Student
    {
        [Key]
        public int Stu_id { get; set; }
        [Required]
        [Column(TypeName ="varchar(100)")]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string City { get; set; }
        [Required]
        public int Age { get; set; }

    }
}
