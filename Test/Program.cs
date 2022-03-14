using Timesheets.BL.Models;

People people=new People();
People people2 = new People();

//people.GetPerson(1);

//Console.WriteLine(people._pagePeople.Count);

//*******

//people2._pagePeople = people.PagePeople(3,10);

//foreach (var i in people2._pagePeople)
//{
//    Console.WriteLine($"{i.Id}  {i.FirstName}");
//}

//*******

people.DeletePerson(3);

foreach (var i in people.GetPeople())
{
    Console.WriteLine($"{i.Id}  {i.FirstName}");
}

