using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RivaCompanySoftware
{
    public partial class MainForm : Form
    {
        //check witch button is clicked

        public MainForm()
        {
            InitializeComponent();
            homePage.BringToFront();
            activeButton.Height = homePageButton.Height;
            activeButton.Left = homePageButton.Right;
            activeButton.BringToFront();

            showPage = 1;
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            homePage.BringToFront();
            activeButton.Height = homePageButton.Height;
            activeButton.Top = homePageButton.Top;
            activeButton.BringToFront();
            showPage = 1;

        }

        private void rivaCompanyButton_Click(object sender, EventArgs e)
        {
            navBarCompany.BringToFront();
            activeButton.Height = rivaCompanyButton.Height;
            activeButton.Top = rivaCompanyButton.Top;
            activeButton.BringToFront();
            showPage = 2;
        }

        private void rivaAccesButton_Click(object sender, EventArgs e)
        {
            navBarStores.BringToFront();
            activeButton.Height = rivaAccesButton.Height;
            activeButton.Top = rivaAccesButton.Top;
            activeButton.BringToFront();
            showPage = 3;
        }

        private void rivaDrinksButton_Click(object sender, EventArgs e)
        {
            navBarStores.BringToFront();
            activeButton.Height = rivaDrinksButton.Height;
            activeButton.Top = rivaDrinksButton.Top;
            activeButton.BringToFront();
            showPage = 4;
        }

        private void rivaMeatButton_Click(object sender, EventArgs e)
        {
            navBarStores.BringToFront();
            activeButton.Height = rivaMeatButton.Height;
            activeButton.Top = rivaMeatButton.Top;
            activeButton.BringToFront();
            showPage = 5;
        }

        private void rivaVitaButton_Click(object sender, EventArgs e)
        {
            navBarStores.BringToFront();
            activeButton.Height = rivaVitaButton.Height;
            activeButton.Top = rivaVitaButton.Top;
            activeButton.BringToFront();
            showPage = 6;
        }
        
    }
}
