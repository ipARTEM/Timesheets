using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheets.BL.Models;
using Timesheets.DB;
using Xunit;

namespace xUnit01
{
    public class UnitTest2
    {
        [Fact]
        public void GetPeople_Test()
        {
            Mock<IPeople> people = new Mock<IPeople>();

            people.Setup(m => m.GetPeople()).Returns(new List<Person>()
            {
                new Person(){ Id = 1, Age =23},
                new Person(){ Id = 2, Age =38}
            });
        }
    }
}
