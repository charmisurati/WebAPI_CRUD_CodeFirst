using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI_CRUD_Methods.Models
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar")]
        public string Name { get; set; }

        [Column("Email", TypeName = "varchar")]
        public string Email { get; set; }

        [Column("Contact", TypeName = "varchar")]
        [StringLength(10)]
        public string Contact { get; set; }
           
    }
}