using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string CompanyName { get; set; }
        List<Education> Educations { get; set; }
    }
}
