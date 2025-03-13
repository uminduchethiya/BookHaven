using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;
using Microsoft.Data.SqlClient;

namespace BookHaven.Data.Repositories.DashboardManagementRepository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly string _connectionString;
        public DashboardRepository() {
            _connectionString = ConfigurationManager.ConnectionStrings["BookHavenDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new Exception("Connection string 'BookHavenDB' not found in App.config.");
            }
        }
        // Fetch Sales Count by Date
        public async Task<int> FetchSalesCountByDate(DateTime date)
        {
            var query = @"
                SELECT COUNT(*) 
                FROM CustomerTransactions
                WHERE CAST(Date AS DATE) = @Date";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Date", date);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        // Fetch Sales Count by Date Range (Weekly/Monthly)
        public async Task<int> FetchSalesCountByDateRange(DateTime startDate, DateTime endDate)
        {
            var query = @"
                SELECT COUNT(*) 
                FROM CustomerTransactions
                WHERE Date BETWEEN @StartDate AND @EndDate";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        // Fetch Sales Amount by Date
        public async Task<decimal> FetchSalesAmountByDate(DateTime date)
        {
            var query = @"
                SELECT SUM(TotalAmount) 
                FROM CustomerTransactions
                WHERE CAST(Date AS DATE) = @Date";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Date", date);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        // Fetch Sales Amount by Date Range
        public async Task<decimal> FetchSalesAmountByDateRange(DateTime startDate, DateTime endDate)
        {
            var query = @"
                SELECT SUM(TotalAmount) 
                FROM CustomerTransactions
                WHERE Date BETWEEN @StartDate AND @EndDate";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        // Fetch Total Orders Count
        public async Task<int> FetchTotalOrdersCount()
        {
            var query = "SELECT COUNT(*) FROM [Order]";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        // Fetch Orders by Status (Pending/Completed)
        public async Task<int> FetchOrdersCountByStatus(string status)
        {
            var query = "SELECT COUNT(*) FROM [Order] WHERE Status = @Status";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        // Fetch Total Customers Count
        public async Task<int> FetchTotalCustomersCount()
        {
            var query = "SELECT COUNT(*) FROM Customer";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        // Fetch Total Suppliers Count
        public async Task<int> FetchTotalSuppliersCount()
        {
            var query = "SELECT COUNT(*) FROM Supplier";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        // Fetch Total Books Count
        public async Task<int> FetchTotalBooksCount()
        {
            var query = "SELECT COUNT(*) FROM Book";
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        // Fetch Most Selling Book
        public async Task<Book> FetchMostSellingBook()
        {
            var query = @"
                SELECT TOP 1 b.BookId, b.Title, SUM(s.Quantity) AS TotalQuantity
                FROM SalesTransactionDetails s
                INNER JOIN Book b ON s.BookId = b.BookId
                GROUP BY b.BookId, b.Title
                ORDER BY TotalQuantity DESC";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new Book
                        {
                            BookId = reader.GetInt32(reader.GetOrdinal("BookId")),
                            Title = reader.GetString(reader.GetOrdinal("Title"))
                        };
                    }
                }
            }
            return null;
        }
    }
}
