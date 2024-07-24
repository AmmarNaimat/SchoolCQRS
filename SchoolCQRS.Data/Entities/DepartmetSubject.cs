using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Data.Entities
{
    public class DepartmetSubject
    {
        [Key]
        public int Id { get; set; }
        public int DepId { get; set; }
        public int SubID { get; set; }

        [ForeignKey("DepId")]
        public virtual Department Department { get; set; }

        [ForeignKey("SubID")]
        public virtual Subjects Subjects { get; set; }
    }
}
