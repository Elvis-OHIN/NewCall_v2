using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Required]
        public int id { get; set;}

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(20)]
        public string statut { get; set; }
        public Student(int id, string firstname, string lastname, string statut)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.statut = statut;
        }

    }
}
