using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTDD01
{
    public interface IPaymentTypeRepository
    {
        IReadOnlyList<PaymentType> GetAll();
    }

}
