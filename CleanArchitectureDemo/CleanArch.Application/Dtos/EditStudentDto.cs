using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Dtos
{
    public class EditStudentDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<Books> Books { get; set; }
    }
}
 