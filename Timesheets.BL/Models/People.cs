using System;
using System.Collections.Generic;
using System.Text;
using Timesheets.DB;

namespace Timesheets.BL.Models
{
    public class People : IPeople
    {
        private Repository _repository;

        public List<Person> pagePeople { get; set; }

        public People()
        {
            _repository = new Repository();
            pagePeople = new List<Person>();
        }

        /// <summary>
        /// Добавить человека
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public List<Person> AddPerson(Person person)
        {
            _repository.Data.Add(person);

            return _repository.Data;
        }

        /// <summary>
        /// Удалить человека
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Person> DeletePerson(int id)
        {
            foreach (var i in _repository.Data)
            {
                if (i.Id==id)
                {
                    _repository.Data.Remove(i);
                }
            }
            return _repository.Data;
        }

        /// <summary>
        /// Получить всех людей
        /// </summary>
        /// <returns></returns>
        public List<Person> GetPeople()
        {
            return _repository.Data;
        }

        /// <summary>
        /// Получение списка людей с пагинацией
        /// </summary>
        /// <param name="skip">Пропускать</param>
        /// <param name="take">Брать</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Person> PagePeople(int skip, int take)
        {
            return pagePeople = _repository.GetRange(2, 5);
        }

        /// <summary>
        /// Поиск человека по имени
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Person SearchPerson( string firstName)
        {
            foreach (var i in _repository.Data)
            {
                if (i.FirstName==firstName)
                {
                    i.FirstName = firstName;
                    return i;
                }
            }
            return null;
        }

        /// <summary>
        /// Обновление существующего человека в коллекции
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Person> UpdatePerson(Person p)
        {
            foreach (var i in _repository.Data)
            {
                if (i.Id== p.Id)
                {
                    i.FirstName=p.FirstName;
                    i.LastName=p.LastName;
                    i.Email=p.Email;
                    i.Company=p.Company;
                    i.Age=p.Age;
                    return _repository.Data;
                }
            }
            return _repository.Data;
        }
    }
}
