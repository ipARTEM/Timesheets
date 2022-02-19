using System;
using System.Collections.Generic;
using System.Text;
using Timesheets.DB;

namespace Timesheets.BL.Models
{
    public class People : IPeople
    {
        public List<Person> GetPeople()
        {
            Repository  repository = new Repository();

            return repository.GetPeople();
        }
    }
}
