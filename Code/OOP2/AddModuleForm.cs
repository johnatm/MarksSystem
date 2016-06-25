using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class AddModuleForm : Form
    {
        MainForm context;

        public AddModuleForm(MainForm context)
        {
            InitializeComponent();
            this.context = context;
        }

        
        List<AddComponentControl> componentControls = new List<AddComponentControl>();

        String error, error1, error2, error3;

        private void addButton_Click(object sender, EventArgs e)
        {
            AddComponentControl acc = new AddComponentControl();
            componentControls.Add(acc);
            flowLayoutPanel1.Controls.Add(acc);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Module mod = new Module();

            List<Component> componentInfo = new List<Component>();
            foreach(AddComponentControl control in componentControls)
            {
                Component comp = new Component();
                comp.ComponentID = control.componentID;
                comp.ComponentName = control.componentName;
                comp.ModuleID = mCode.Text;
                comp.Weightage = control.componentWeight;
                componentInfo.Add(comp);
            }


            Boolean isValid = true;

            //Regex rgx1 = new Regex("^[0-9A-Za-z ]+$");
            //if (!rgx1.IsMatch(mName.Text))
            //{
            //    error = "The module name must contain only letters";
            //    isValid = false;
            //}
            //else
            //{
            mod.ModuleID = mCode.Text;
            //}

            //Regex rgx = new Regex(("^[A-Za-z]{4}[0-9]{3}$"));
            //if (!rgx.IsMatch(mCode.Text))
            //{
            //    error1 = "The first 4 charaters of module code needs to letters only and last 3 characters needs to be numbers only. eg: ECSI404";
            //    isValid = false;
            //}
            //else
            //{
            mod.ModuleName = mName.Text;
            //}

            //Regex rgx2 = new Regex(("^(?:100|[1-9]?[0-9])$"));
            //if (!rgx2.IsMatch(mCredits.Text))
            //{
            //    error2 = "Module credits needs to between 0-100";
            //    isValid = false;
            //}
            //else
            //{
            mod.Credits = Int32.Parse(mCredits.Text);
            //}

            if (isValid)
            {
                try
                {
                    using(var dbCtx = new Entities())
                    {
                        dbCtx.Modules.Add(mod);
                        dbCtx.SaveChanges();

                        foreach (Component element in componentInfo)
                        {
                            dbCtx.Components.Add(element);
                        }

                        dbCtx.SaveChanges();

                        MessageBox.Show("Module added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        context.addModule(mod);

                        foreach (Component element in componentInfo)
                        {
                            mod.Components.Add(element);
                        }
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                Console.WriteLine(error + "--" + error1 + "--" + error2 + "--" + error3);
                MessageBox.Show("1. " + error + "\r\n" + "2. " + error1 + "\r\n" + "3. " + error2);
            } 
        }
    }
}
