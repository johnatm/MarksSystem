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
    public partial class ComponentControl : UserControl
    {
        public Component component { get; set; }
        public event SingleComponentChanged componentChanged;
        public delegate void SingleComponentChanged(object sender, ComponentChangedEvent changeEvent);

        public TextBox txtMarks
        {
            get { return txtMark; }
        }

        public ComponentControl(Component comp)
        {
            InitializeComponent();
            component = comp;
            lblName.Text = comp.ComponentName;
            lblPercentage.Text = comp.Weightage.ToString() + "%";
            txtMark.Text = comp.Marks.ToString();
            txtMark.TextChanged += delegate (object sender, EventArgs e)
            {
                ComponentChangedEvent changeEvent = new ComponentChangedEvent();
                changeEvent.component = component;
                componentChanged(sender, changeEvent);
            };
        }
    }
    public class ComponentChangedEvent : EventArgs
    {
        public Component component { get; set; }
    }
}