using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rmbh_backoffice.VC.Views
{
    public partial class HomeView : Form, IView
    {

        public HomeView()
        {
            InitializeComponent();
            cutomizeDesing();
        }
        public Form Form
        {
            get
            {
                return this;
            }
        }

        public string Title
        {
            get
            {
                return Text;
            }

            set
            {
                Text = value;
            }
        }

        private void cutomizeDesing()
        {
           
            panelFlashsCards.Visible = false;

        }
        private void hideSubMenu()
        {
          
            if (panelFlashsCards.Visible == true)
                panelFlashsCards.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            hideSubMenu();
        }
        
        private void btnUsersManagement_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            hideSubMenu();
        }
       
        private void btnTeamsManagement_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            hideSubMenu();
        }

        private void btnFlashsCards_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFlashsCards);
        }
        #region tool
        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new ClassManagementView());
            //.. 
            //.. code minh
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //.. 
            //.. code minh
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            //.. 
            //.. code minh
            hideSubMenu();
        }
        #endregion
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            hideSubMenu();
        }
        private Form acctiveform = null;
        private void openChildForm(Form childFrom)
        {
            if (acctiveform != null)
                acctiveform.Close();
            acctiveform = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childFrom);
            panelChildForm.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


    
    



