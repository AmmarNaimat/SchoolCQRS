using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Data.Entities
{
    public class StudentSubject
    {
        [Key]
        public int Id { get; set; }
        public int StdId { get; set; }
        public int SubId { get; set; }

        [ForeignKey("StdId")]
        public virtual Student Student { get; set; }

        [ForeignKey("SubId")]
        public virtual Subjects Subject { get; set; }
    }
}
