using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name ="First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Full Name")]

        public DateTime EnrollmentDate { get; set; }
        [Display(Name ="Full Name")]
        public string FullName
        {
            get
            {
                return LastName + "," + FirstMidName;
            }
        }



        public string Secret { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
