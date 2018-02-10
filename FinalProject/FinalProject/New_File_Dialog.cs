using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class New_File_Dialog : Form
    {
        Main_Form Parent_Form;

        public New_File_Dialog(Main_Form _form)
        {
            InitializeComponent();
            this.Parent_Form = _form;
        }

        private void New_File_Dialog_Load(object sender, EventArgs e)
        {
            Parent_Form.New_File_Choice = 0;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (radioButton_HTML.Checked)
            {
                Parent_Form.New_File_Choice = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a file type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // User-defined Functions
        //
    }
}
