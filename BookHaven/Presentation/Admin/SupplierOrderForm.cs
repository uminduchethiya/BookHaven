using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Presentation.Admin
{
    public partial class SupplierOrderForm : Form
    {
        private readonly ISupplierOrderManagementService _supplierOrderService;

        public SupplierOrderForm(ISupplierOrderManagementService supplierOrderService)
        {
            InitializeComponent();
            _supplierOrderService = supplierOrderService ?? throw new ArgumentNullException(nameof(supplierOrderService));
            LoadSuppliers();
            LoadLowStockBooks();
        }
        private void LoadSuppliers()
        {
            cmbsupplier.Items.Clear();
            List<Supplier> suppliers = _supplierOrderService.GetAllSuppliers();

            foreach (var supplier in suppliers)
            {
                cmbsupplier.Items.Add(supplier.SupplierName);
            }
        }

        private void LoadLowStockBooks()
        {
            dtgsupplierorder.Columns.Clear(); // Clear existing columns (if any)
            dtgsupplierorder.Rows.Clear(); // Clear existing rows

            // Define Columns
            dtgsupplierorder.Columns.Add("BookId", "Book ID");
            dtgsupplierorder.Columns.Add("Title", "Title");
            dtgsupplierorder.Columns.Add("Author", "Author");
            dtgsupplierorder.Columns.Add("StockQuantity", "Stock Quantity");
            dtgsupplierorder.Columns.Add("Price", "Price");

            // Fetch Books with Stock < 20
            List<Book> lowStockBooks = _supplierOrderService.GetLowStockBooks();

            foreach (var book in lowStockBooks)
            {
                dtgsupplierorder.Rows.Add(book.BookId, book.Title, book.Author, book.StockQuantity, book.Price);
            }
        }

        private void cmbsupplier_TextChanged(object sender, EventArgs e)
        {
            // Trigger the search whenever the text changes
            SearchSupplier();
        }

        private void SearchSupplier()
        {
            string searchText = cmbsupplier.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText)) return;

            // Get suppliers that contain the entered text
            var matchingSuppliers = _supplierOrderService.GetAllSuppliers()
                .Where(s => s.SupplierName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(s => s.SupplierName)
                .ToList();

            cmbsupplier.Items.Clear();
            cmbsupplier.Items.AddRange(matchingSuppliers.Select(s => s.SupplierName).ToArray());

            cmbsupplier.DroppedDown = matchingSuppliers.Any();
            cmbsupplier.SelectionStart = cmbsupplier.Text.Length;
            cmbsupplier.SelectionLength = 0;
        }


        private void cmbsupplier_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user presses Enter, perform the search and open the dropdown
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Prevents the dropdown from closing on Enter key press
                SearchSupplier(); // Perform the search based on the typed text

                // Ensure the dropdown stays open with suggestions
                cmbsupplier.DroppedDown = true;
            }
        }


        private void cmbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgsupplierorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            if (cmbsupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtgsupplierorder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int supplierID = _supplierOrderService.GetAllSuppliers()
                .FirstOrDefault(s => s.SupplierName == cmbsupplier.SelectedItem.ToString())?.SupplierID ?? -1;

            if (supplierID == -1)
            {
                MessageBox.Show("Invalid supplier selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dtgsupplierorder.SelectedRows[0];
            int bookID = Convert.ToInt32(selectedRow.Cells["BookId"].Value);
            int quantity = 10; // You might want to ask the user for this.

            SupplierOrder order = new SupplierOrder
            {
                SupplierID = supplierID,
                BookID = bookID,
                Quantity = quantity,
                OrderDate = DateTime.Now,
                Status = "Pending"
            };

            try
            {
                _supplierOrderService.SaveSupplierOrder(order);
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLowStockBooks(); // Refresh the list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
