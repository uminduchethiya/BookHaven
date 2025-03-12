using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Repositories.SupplierOrderManagementRepository
{
    public interface ISupplierOrderManagementRepository
    {
        List<Supplier> GetAllSuppliers();
        List<Book> GetLowStockBooks();
        void SaveSupplierOrder(SupplierOrder order); // Method for saving SupplierOrder
        
    }
}
