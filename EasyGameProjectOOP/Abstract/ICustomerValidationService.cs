using EasyGameProjectOOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGameProjectOOP.Abstract
{
   public interface ICustomerValidationService
    {
        bool Validate(Customer customer);
    }
}
