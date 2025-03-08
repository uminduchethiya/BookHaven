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
    public partial class AdminDashboard : Form
    {
        private int sidebarExpandedWidth = 250; // Full size
        private int sidebarCollapsedWidth = 80; // Minimized size
        private bool isSidebarExpanded = true; // Track sidebar state

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            int stepSize = 30; // Increase speed by changing the step size

            if (isSidebarExpanded)
            {
                // Collapse Sidebar Faster
                if (sidebar.Width > sidebarCollapsedWidth)
                {
                    sidebar.Width -= stepSize; // ✅ Faster collapse
                }
                else
                {
                    sidebartimer.Stop();
                    isSidebarExpanded = false;
                }
            }
            else
            {
                // Expand Sidebar Faster
                if (sidebar.Width < sidebarExpandedWidth)
                {
                    sidebar.Width += stepSize; // ✅ Faster expand
                }
                else
                {
                    sidebartimer.Stop();
                    isSidebarExpanded = true;
                }
            }
        }

        private void menupicbox_Click(object sender, EventArgs e)
        {
            sidebartimer.Start(); // ✅ Correct timer reference
        }
    }
}
