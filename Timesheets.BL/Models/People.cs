using System;
using System.Collections.Generic;
using System.Text;
using Timesheets.DB;

namespace Timesheets.BL.Models
{
    public class People : IPeople
    {
        private Repository _repository;

        public People()
        {
            _repository = new Repository();
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
        /// Отдать всех людей
        /// </summary>
        /// <returns></returns>
        public List<Person> GetPeople()
        {
            return _repository.Data;
        }

        /// <summary>
        /// Получение списка людей с пагинацией
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<List<Person>> PagePeople(int skip, int take)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Поиск человека по имени
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Person SearchPerson(string firstName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Обновление существующего человека в коллекции
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Person> UpdatePerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}
