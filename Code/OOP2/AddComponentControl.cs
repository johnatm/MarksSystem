using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class AddComponentControl : UserControl
    {
        public AddComponentControl()
        {
            InitializeComponent();
        }
      
        public String componentID
        {
            get { return compID.Text; }
            set { compID.Text = value; }
        }

        public String componentName
        {
            get { return compName.Text; }
            set { compName.Text = value; }
        }

        public int componentWeight
        {

            get { return Int32.Parse(weight.Text); }
            set { value = Int32.Parse(weight.Text); }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void assName_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {     
            this.Parent.Controls.Remove(this);
        }
    }
}
