using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Business.Interfaces
{
    interface IOrderManagementService
    {
        List<Customer> GetCustomerByPhone(string phoneNumber);
        List<Book> GetBookByTitle(string title);
        void SaveOrder(Order order);
    }
}
