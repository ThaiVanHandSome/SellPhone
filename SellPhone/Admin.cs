using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhone
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                pnlSubnav.Height -= pnlSubnav.MaximumSize.Height;
                if(pnlSubnav.Height == pnlSubnav.MinimumSize.Height)
                {
                    menuExpand = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                pnlSubnav.Height += pnlSubnav.MaximumSize.Height;
                if (pnlSubnav.Height == pnlSubnav.MaximumSize.Height)
                {
                    menuExpand = true;
                    timerMenu.Stop();
                }
                
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlSubnav.Height = 0;
        }

        private void btnBrandType_Click(object sender, EventArgs e)
        {
            BrandTypeControl brandControl = new BrandTypeControl();
            pnlContainer.Controls.Add(brandControl);
        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            EmployControl employcontrol = new EmployControl();
            pnlContainer.Controls.Add(employcontrol);
        }
    }
}
