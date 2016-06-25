using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OOP2
{
    public partial class ModuleControl : UserControl
    {
        public Module module { get; set; }
        public String marks {
            set {
                lblModuleMark.Text = value;
                if (Int32.Parse(value) < 30)
                {
                    lblModuleResult.Text = "FAIL";
                    lblModuleResult.ForeColor = Color.Red;
                } else
                {
                    lblModuleResult.Text = "PASS";
                    lblModuleResult.ForeColor = Color.Green;
                }
            }
        }

        public event ComponentChanged childComponentChanged;
        public delegate void ComponentChanged(Module m);

        public ModuleControl(Module module)
        {
            InitializeComponent();
            this.module = module;
            foreach ( Component comp in module.Components)
            {
                ComponentControl cmpc = new ComponentControl(comp);
                cmpc.componentChanged += childComponentChangedCallback;
                pnlComponent.Controls.Add(cmpc);

            }

            lblModuleCode.Text = module.ModuleID;
            lblModuleName.Text = module.ModuleName;
            lblCredits.Text = module.Credits.ToString();
        }

        private void childComponentChangedCallback(object sender, ComponentChangedEvent changeEvent)
        {
            TextBox source = (TextBox)sender;
            Regex reg = new Regex("^(?:100|[1-9]?[0-9])$");
            String marks = source.Text;

            if (reg.IsMatch(marks))
            {       
                changeEvent.component.Marks = Int32.Parse(marks);
                using(var db = new Entities())
                {
                    db.SaveChanges();
                }
                childComponentChanged(module);
            } else
            {
                MessageBox.Show("Invalid Mark", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
