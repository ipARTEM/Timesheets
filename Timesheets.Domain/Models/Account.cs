using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Domain.Models
{
    /// <summary>
    /// Сущность счёта
    /// </summary>
    public class  Account            //Rich Model
    {
        public Guid NumberAccount { get;  }

        public string NameAccount { get;  }

        public string NameBank { get;  }

        public string NameHolder { get;  }

        public decimal MoneyBalance { get; private set; }

        public DateTime DateOfCreation { get; }

        public string Condition { get; private set; }

        public List<Sheet>? Sheets { get; private set;  }    

        /// <summary>
        /// Инициализация счёта
        /// </summary>
        /// <param name="numberAccount"></param>
        /// <param name="nameAccount"></param>
        /// <param name="nameBank"></param>
        /// <param name="nameHolder"></param>
        /// <param name="condition"></param>
        public Account(Guid numberAccount, string nameAccount, string nameBank, string nameHolder, DateTime dateOfCreation, string condition)
        {
            NumberAccount = numberAccount;
            NameAccount = nameAccount;
            NameBank = nameBank;
            NameHolder = nameHolder;
            MoneyBalance = 0;
            DateOfCreation = dateOfCreation;
            Condition = condition;
        }

        /// <summary>
        /// Включение записи в счёт
        /// </summary>
        /// <param name="idSheet"></param>
        /// <param name="dateTimeOperation"></param>
        /// <param name="money"></param>
        public void IncludeSheets(Guid idSheet, DateTime dateTimeOperation, decimal money)
        {
            bool isSuccessful=false;

            if (MoneyBalance + money >= 0)
            {
                isSuccessful = true;
                MoneyBalance += money;
                Sheet sheet = new ( idSheet, isSuccessful, dateTimeOperation, money);
                Sheets.Add(sheet);
            }
            else
            {
                Sheet sheet = new (idSheet, isSuccessful, dateTimeOperation, money);
                Sheets.Add(sheet);
            }
        }
    }
}
