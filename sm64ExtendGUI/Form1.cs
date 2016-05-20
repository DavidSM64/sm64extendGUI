using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class TitleBar : Form
    {
        public TitleBar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                romLoc.Text = openFileDialog1.FileName;
            }
        }

        private void customButton_CheckedChanged(object sender, EventArgs e)
        {
            customPanel.Visible = true;
            basicPanel.Visible = false;
        }

        private void basicButton_CheckedChanged(object sender, EventArgs e)
        {
            basicPanel.Visible = true;
            customPanel.Visible = false;
        }

        private void extendButton_Click(object sender, EventArgs e)
        {
            if (romLoc.Text.Length == 0)
            {
                MessageBox.Show("You did not specify a ROM file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string arguments = "";

            if (basicButton.Checked)
            {
                if (option24MB.Checked)
                    arguments += "-s 24 ";
                else if (option32MB.Checked)
                    arguments += "-s 32 ";
                else if (option48MB.Checked)
                    arguments += "-s 48 ";
                else
                    arguments += "-s 64 ";
            }
            else
            {
                // Remove whitespace from text boxes.
                custExtRomSize.Text = custExtRomSize.Text.Replace(" ", "");
                custPadMIO0.Text = custPadMIO0.Text.Replace(" ", "");
                custBytePad.Text = custBytePad.Text.Replace(" ", "");

                if (System.Text.RegularExpressions.Regex.IsMatch(custExtRomSize.Text, "[^0-9]"))
                {
                    MessageBox.Show("Invalid extended ROM value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(custPadMIO0.Text, "[^0-9]"))
                {
                    MessageBox.Show("Invalid MIO0 padding value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(custBytePad.Text, "[^0-9]"))
                {
                    MessageBox.Show("Invalid byte padding value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int size = Int32.Parse(custExtRomSize.Text);
                if (size < 12 || size > 64)
                {
                    MessageBox.Show("Invalid ROM size value, must be between 12 MB and 64 MB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                arguments += "-s " + custExtRomSize.Text + " ";
                arguments += "-p " + custPadMIO0.Text + " ";
                arguments += "-a " + custBytePad.Text + " ";
                if (custDumpMIO0.Checked)
                    arguments += "-d ";
                if (custFillMIO0.Checked)
                    arguments += "-f ";
            }

            arguments += "\""+romLoc.Text+"\""; // Add rom location to argument list
            Process p = new Process();
            p.StartInfo.FileName = "sm64extend.exe";
            p.StartInfo.Arguments = arguments;
            p.Start();
            p.WaitForExit();
            if (p.ExitCode == 0)
            {
                MessageBox.Show("Your ROM has been extended!\n Arguments passed:\n" + arguments, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Uh-oh, Something bad happend! Exit code: "+p.ExitCode+ "\n Arguments passed:\n" + arguments, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
