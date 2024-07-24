using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Data.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        public int DepId { get; set; }
        [ForeignKey("DepId")]
        public virtual Department Department {  get; set; }
    }
}
