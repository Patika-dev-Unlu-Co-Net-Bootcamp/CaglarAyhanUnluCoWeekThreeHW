using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public bool isActive { get; set; } = true;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public List<Education> Educations { get; set; }
    }
}
