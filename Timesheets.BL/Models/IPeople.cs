using System;
using System.Collections.Generic;
using System.Text;

using Timesheets.DB;

namespace Timesheets.BL.Models
{
    public interface IPeople
    {
        List<Person> GetPeople();

        Person SearchPerson(string firstName);

        List<Person> PagePeople(int skip, int take);

        List<Person> AddPerson (Person person);

        List<Person> UpdatePerson (Person person);

        List <Person> DeletePerson (int id);
    }
}
