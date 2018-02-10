using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class Main_Form : Form
    {
        New_File_Dialog newFileDialog;
        //public string test = "Testing variable from Main_Form";

        public Main_Form()
        {
            InitializeComponent();

            groupBox_Global_Attributes.Visible = false;

            label_Attribute_1.Visible = false;
            textBox_Attribute_1.Visible = false;

            label_Attribute_2.Visible = false;
            textBox_Attribute_2.Visible = false;

            label_Attribute_3.Visible = false;
            comboBox_Attribute_3.Visible = false;
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            comboBox_Element.DropDownWidth = Drop_Down_Width(comboBox_Element);
            label_Tag_Description.Text = "";

        }

        private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newFileDialog = new New_File_Dialog(this);
            newFileDialog.Show();
        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog.FileName);

                textBox_Main.Text = inputFile.ReadToEnd();

                inputFile.Close();
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            string inputText = "";

            switch (comboBox_Element.SelectedIndex)
            {
                case 0:
                    inputText = "<!-- " + textBox_Input.Text + " -->";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 1:
                    inputText = "<a "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\" "
                                + label_Attribute_1.Text.ToLower() + "\"" + textBox_Attribute_1.Text + "\""
                                + ">"
                                + textBox_Input.Text
                                + "</a>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 2:
                    inputText = "<audio "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\" "
                                + label_Attribute_1.Text.ToLower() + "\"" + textBox_Attribute_1.Text + "\" "
                                + label_Attribute_2.Text.ToLower() + "\"" + textBox_Attribute_2.Text + "\""
                                + ">"
                                + textBox_Input.Text
                                + "</audio>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 3:
                    inputText = "<button "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\""
                                + ">"
                                + textBox_Input.Text
                                + "</button>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 4:
                    inputText = "<div "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\""
                                + ">"
                                + textBox_Input.Text
                                + "</div>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 5:
                    inputText = "<form "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\" "
                                + label_Attribute_1.Text.ToLower() + "\"" + textBox_Attribute_1.Text + "\""
                                + label_Attribute_2.Text.ToLower() + "\"" + textBox_Attribute_2.Text + "\""
                                + ">"
                                + "\r\n\t"
                                + textBox_Input.Text
                                + "<input type=\"\" name\"\" />"
                                + "\r\n\t"
                                + "</form>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 6:
                    int header_choice = comboBox_Attribute_3.SelectedIndex;
                    if(header_choice > -1)
                    {
                        inputText = "<h"
                                    + (header_choice + 1) + " "
                                    + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                    + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\""
                                    + ">"
                                    + textBox_Input.Text
                                    + "</h>";
                        textBox_Main.Paste(inputText);
                        textBox_Main.Paste(Environment.NewLine);
                    }
                    else
                    {
                        MessageBox.Show("Please select a header size.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 7:
                    inputText = "<iframe "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\" "
                                + label_Attribute_1.Text.ToLower() + "\"" + textBox_Attribute_1.Text + "\" "
                                + label_Attribute_2.Text.ToLower() + "\"" + textBox_Attribute_2.Text + "\""
                                + ">"
                                + textBox_Input.Text
                                + "</iframe>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 8:
                    inputText = "<img "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\" "
                                + label_Attribute_1.Text.ToLower() + "\"" + textBox_Attribute_1.Text + "\" "
                                + label_Attribute_2.Text.ToLower() + "\"" + textBox_Attribute_2.Text + "\""
                                + ">"
                                + textBox_Input.Text
                                + "</img>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 9:
                    inputText = "<ol "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\""
                                + ">"
                                + "<li>"
                                + textBox_Input.Text
                                + "</li>"
                                + "\r"
                                + "</ol>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 10:
                    inputText = "<p "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\""
                                + ">"
                                + textBox_Input.Text
                                + "</p>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 11:
                    inputText = "<select "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\" "
                                + label_Attribute_1.Text.ToLower() + "\"" + textBox_Attribute_1.Text + "\""
                                + ">"
                                + "<option value=\"\">"
                                + textBox_Input.Text
                                + "</option>"
                                + "\r"
                                + "</>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 12:
                    inputText = "<span "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\""
                                + ">"
                                + textBox_Input.Text
                                + "</span>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 13:
                    inputText = "<table "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\""
                                + ">"
                                + "<tr>"
                                + "\r"
                                + "<td>"
                                + textBox_Input.Text
                                + "</td>"
                                + "\r"
                                + "</tr>"
                                + "\r\n\t"
                                + "</table>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                case 14:
                    inputText = "<ul "
                                + label_ID.Text.ToLower() + "\"" + textBox_ID.Text + "\" "
                                + label_Class.Text.ToLower() + "\"" + textBox_Class.Text + "\""
                                + ">"
                                + "<li>"
                                + textBox_Input.Text
                                + "</li>"
                                + "\r"
                                + "</ul>";
                    textBox_Main.Paste(inputText);
                    textBox_Main.Paste(Environment.NewLine);
                    break;

                default:
                    textBox_Input.Text = "";
                    break;
            }
            
            textBox_ID.Text = "";
            textBox_Class.Text = "";
            textBox_Attribute_1.Text = "";
            textBox_Attribute_2.Text = "";
            textBox_Input.Text = "";
        }

        private void Button_Insert_Line_Break_Click(object sender, EventArgs e)
        {
            textBox_Main.Paste("<br />");
            textBox_Main.Paste(Environment.NewLine);
        }

        private void Button_Insert_Horizontal_Line_Click(object sender, EventArgs e)
        {
            textBox_Main.Paste("<hr />");
            textBox_Main.Paste(Environment.NewLine);
        }

        private void ComboBox_Element_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_ID.Text = "";
            textBox_Class.Text = "";
            textBox_Attribute_1.Text = "";
            textBox_Attribute_2.Text = "";

            switch (comboBox_Element.SelectedIndex)
            {
                case 0:
                    label_Tag_Description.Text = "Comment";

                    groupBox_Global_Attributes.Visible = false;

                    label_Attribute_1.Visible = false;
                    label_Attribute_1.Text = "";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 1:
                    label_Tag_Description.Text = "Anchor";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = true;
                    label_Attribute_1.Text = "HREF=";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = true;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 2:
                    label_Tag_Description.Text = "Audio";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = true;
                    label_Attribute_1.Text = "SRC=";

                    label_Attribute_2.Visible = true;
                    label_Attribute_2.Text = "Type=";

                    textBox_Attribute_1.Visible = true;
                    textBox_Attribute_2.Visible = true;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 3:
                    label_Tag_Description.Text = "Button";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = false;
                    label_Attribute_1.Text = "";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 4:
                    label_Tag_Description.Text = "Divisor";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = false;
                    label_Attribute_1.Text = "";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 5:
                    label_Tag_Description.Text = "Form";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = true;
                    label_Attribute_1.Text = "Type=";

                    label_Attribute_2.Visible = true;
                    label_Attribute_2.Text = "Value=";

                    textBox_Attribute_1.Visible = true;
                    textBox_Attribute_2.Visible = true;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 6:
                    label_Tag_Description.Text = "Header";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = false;
                    label_Attribute_1.Text = "";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = true;
                    label_Attribute_3.Text = "Header Size";

                    comboBox_Attribute_3.Visible = true;

                    comboBox_Attribute_3.Items.AddRange(new object[]
                        {"1",
                        "2",
                        "3",
                        "4",
                        "5",}
                    );
                    break;

                case 7:
                    label_Tag_Description.Text = "Internal Frame";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = true;
                    label_Attribute_1.Text = "Height=";

                    label_Attribute_2.Visible = true;
                    label_Attribute_2.Text = "Width=";

                    textBox_Attribute_1.Visible = true;
                    textBox_Attribute_2.Visible = true;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 8:
                    label_Tag_Description.Text = "Image";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = true;
                    label_Attribute_1.Text = "SRC=";

                    label_Attribute_2.Visible = true;
                    label_Attribute_2.Text = "ALT=";

                    textBox_Attribute_1.Visible = true;
                    textBox_Attribute_2.Visible = true;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 9:
                    label_Tag_Description.Text = "Ordered List";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = false;
                    label_Attribute_1.Text = "";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 10:
                    label_Tag_Description.Text = "Paragraph";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = false;
                    label_Attribute_1.Text = "";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 11:
                    label_Tag_Description.Text = "Select (Drop-down)";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = true;
                    label_Attribute_1.Text = "Value=";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = true;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 12:
                    label_Tag_Description.Text = "Span";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = false;
                    label_Attribute_1.Text = "";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 13:
                    label_Tag_Description.Text = "Table";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = false;
                    label_Attribute_1.Text = "";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                case 14:
                    label_Tag_Description.Text = "Unordered List";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = false;
                    label_Attribute_1.Text = "";

                    label_Attribute_2.Visible = false;
                    label_Attribute_2.Text = "";

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;
                    break;

                default:
                    label_Tag_Description.Text = "";

                    groupBox_Global_Attributes.Visible = true;

                    label_Attribute_1.Visible = false;
                    label_Attribute_2.Visible = false;

                    textBox_Attribute_1.Visible = false;
                    textBox_Attribute_2.Visible = false;

                    label_Attribute_3.Visible = false;
                    comboBox_Attribute_3.Visible = false;

                    break;
            }
        }

        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamWriter saveFile;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFile = new StreamWriter(saveFileDialog.FileName);

                string saveContent = textBox_Main.Text;

                saveFile.WriteLine(saveContent);

                saveFile.Close();
            }
        }

        //
        // User-defined Functions
        //
        int Drop_Down_Width(ComboBox myCombo)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in myCombo.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }
        
        public void Tab_Create_HTML()
        {
            textBox_Main.Focus();
            textBox_Main.Text = "<!DOCTYPE html>\r\n<html>\r\n\t<head>\r\n\t\t<title></title>\r\n\t</head>\r\n\r\n\t<body>\r\n\t\t\r\n\t</body>\r\n</html>";
            textBox_Main.SelectionStart = textBox_Main.Text.Length-18;
        }

        //
        // Listen to variable change
        //
        public static int _New_File_Choice = 0;

        public int New_File_Choice
        {
            get
            {
                return _New_File_Choice;
            }
            set
            {
                _New_File_Choice = value;

                if (_New_File_Choice == 1)
                {
                    Tab_Create_HTML();
                }

            }
        }
    }
}
