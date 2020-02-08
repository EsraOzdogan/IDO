using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ido
{
    public partial class Form1 : Form, IControlView, INereyeObserver
    {
        private IController control;
        private string nereye;
        

        public object ComboBox1 { get; private set; }
        public object NereyeToolComboBox { get; private set; }
        public bool NeredenToolComboBox { get; private set; }
        internal IController Control { get => control; set => control = value; }

        public Form1()
        {
            InitializeComponent();
            this.Control = Control;
        }

        /*public ControlView(IController control)
        {
            InitializeComponent();
            this.control = control;
        }*/

        public void updateNEREYE(string nereye)
        {
            comboBox1.Text = "" + nereye;
        }
        public void DisableNeredenComboBox()
        {
            this.NeredenToolComboBox = false;
        }

        public void DisableNereyeComboBox()
        {
            this.NereyeToolComboBox = false;
        }

        public void EnableNeredenComboBox()
        {
            this.NeredenToolComboBox = true;
        }

        public void EnableNereyeComboBox()
        {
               this.NereyeToolComboBox = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string deger = comboBox1.Text;
            deger = deger.Trim();
           /* string nereye = Convert.ToInt32(deger);*/
            Control.SetNEREYE(nereye);
        }

        

    }
}
