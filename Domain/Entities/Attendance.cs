using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }
        public AttendenceType AttendenceType { get; set; }
        public DateTime AttendenceDate { get; set; }
        public int Duration { get; set; }
    }
}

