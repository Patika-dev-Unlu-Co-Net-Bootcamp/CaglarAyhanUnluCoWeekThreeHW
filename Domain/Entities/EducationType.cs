using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EducationType
    {
        [Key]
        public int Id { get; set; }
        public string EducationName { get; set; }
        
        
    }
}
