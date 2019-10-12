using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyExplorer
{
    public partial class NewName : Form
    {
        public NewName()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            set { this.labelOverTextBox.Text = value; }
        }

        public string TextBoxText
        {
            get { return this.textBoxNewName.Text; }
            set { this.textBoxNewName.Text = value; }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.textBoxNewName.Text != "")
                this.Close();
            else
                MessageBox.Show("Текстовое поле не заполнено. Операция прервана",
                    "Операция прервана", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);                   
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}