using EasyGameProjectOOP.Abstract;
using EasyGameProjectOOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGameProjectOOP.Concrete
{
    class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = customer.FirstName;
            customer1.LastName = customer.LastName;
            customer1.CardNumber = customer.CardNumber;
            customer1.BirthDate = customer.BirthDate;
            customer1.NationalNumber = customer.NationalNumber;
            Console.WriteLine("Kullanıcı Başarı İle Eklendi");
        }

        public void Delete(Customer customer)
        {
            Customer customer1 = new Customer();
            customer.FirstName = "";
            customer.LastName = "";
            customer.CardNumber = "";
            customer.NationalNumber = "";
            Console.WriteLine("Kullanıcı başarı ile silindi");
        }

        public void Update(Customer customer)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = customer.FirstName;
            customer1.LastName = customer.LastName;
            customer1.CardNumber = customer.CardNumber;
            customer1.BirthDate = customer.BirthDate;
            customer1.NationalNumber = customer.NationalNumber;
            Console.WriteLine("Kullanıcı Başarı İle Güncellendi");
        }
    }
}
