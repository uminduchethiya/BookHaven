using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Data.Repositories.DashboardManagementRepository
{
    public interface IDashboardRepository
    {
        // Sales Count Overview
        Task<int> FetchSalesCountByDate(DateTime date);
        Task<int> FetchSalesCountByDateRange(DateTime startDate, DateTime endDate);

        // Sales Amount Overview
        Task<decimal> FetchSalesAmountByDate(DateTime date);
        Task<decimal> FetchSalesAmountByDateRange(DateTime startDate, DateTime endDate);

        // Orders Overview
        Task<int> FetchTotalOrdersCount();
        Task<int> FetchOrdersCountByStatus(string status);

        // System Overview
        Task<int> FetchTotalCustomersCount();
        Task<int> FetchTotalSuppliersCount();
        Task<int> FetchTotalBooksCount();
        Task<Book> FetchMostSellingBook();
    }
}
