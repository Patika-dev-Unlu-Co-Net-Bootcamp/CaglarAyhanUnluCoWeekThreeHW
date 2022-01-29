using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int EducationId { get; set; }
        public float Note {get; set;}
        public Student Student { get; set; }
        public DateTime EvaluateDate{ get; set; }
    }
}
