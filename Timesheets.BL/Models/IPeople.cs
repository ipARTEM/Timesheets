using System;
using System.Collections.Generic;
using System.Text;

using Timesheets.DB;

namespace Timesheets.BL.Models
{
    public interface IPeople
    {
         List<Person> GetPeople();
    }
}
