using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Education:BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public int EducationName{ get; set; }
        public decimal Period { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Tutor Tutor { get; set; }
        public EducationType EducationType { get; set; }
        public List<Company> Companies { get; set; }
        public List<Student> Students { get; set; }
        public List<Assistant> Assistants { get; set; }

    }
}
