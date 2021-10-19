using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    interface IStudentRepository
    {
        Student GetStudent(int id);

    }
}
