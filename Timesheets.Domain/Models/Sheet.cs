using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Domain.Models
{
    public class Sheet
    {
        public Guid IdSheet { get;  }

        public bool IsSuccessful { get;  }

        public DateTime DateTimeOperation { get;  }  

        public decimal Money { get;  }

        public Sheet(Guid idSheet, bool isSuccessful, DateTime  dateTimeOperation, decimal money)
        {

            IdSheet = idSheet;
            IsSuccessful = isSuccessful;
            DateTimeOperation = dateTimeOperation;
            Money = money;

        }


    }
}
