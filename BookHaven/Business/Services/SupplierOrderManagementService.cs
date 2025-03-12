using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.SupplierOrderManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Business.Services
{
    public class SupplierOrderManagementService : ISupplierOrderManagementService
    {
        private readonly ISupplierOrderManagementRepository _supplierOrderRepository;

        public SupplierOrderManagementService()
        {
            _supplierOrderRepository = new SupplierOrderManagementRepository();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _supplierOrderRepository.GetAllSuppliers();
        }

        public List<Book> GetLowStockBooks()
        {
            return _supplierOrderRepository.GetLowStockBooks();
        }
        // Method to save the SupplierOrder
        // Method to save the SupplierOrder
        public void SaveSupplierOrder(SupplierOrder order)
        {
            // Call the repository method to save the order
            _supplierOrderRepository.SaveSupplierOrder(order);
        }


       
    }
}
