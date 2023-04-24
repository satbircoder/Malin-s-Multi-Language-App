using Malin_s_AstroMath_App.Properties;
using System;
using System.Data.SqlTypes;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Resources;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace Malin_s_AstroMath_App
{
    public partial class AstroMathApp : Form
    {
        public AstroMathApp()
        {

            InitializeComponent();

        }
        
        private IAstroContract connection()
        {
            Console.WriteLine("Client Started");
            string address = "net.pipe://localhost/pipeastromaths";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
            return channel;
        }
      
        private void AstroMathApp_Load(object sender, EventArgs e)
        {
            dataViewCalculations.AllowUserToAddRows = false;
        }
       
        private void buttonStarVelocity_Click(object sender, EventArgs e)
        {
            if (textBoxObsLength.Text != "" && textBoxRestLength.Text != "")
            {
                var velocity = connection().StarVelocity(double.Parse(textBoxObsLength.Text), double.Parse(textBoxRestLength.Text));
                if (velocity.Item3.Equals(true))
                {
                    for (int i = 0; i <= dataViewCalculations.Rows.Count; i++)
                    {
                        if (dataViewCalculations.Rows.Count == 0)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i, newRow);
                            dataViewCalculations.Rows[i].Cells[0].Value = (velocity.Item1 +" "+ stringtranslation.meters_per_second);
                            break;
                        }
                        if (dataViewCalculations.Rows[i].Cells[0].Value == null)
                        {
                            dataViewCalculations.Rows[i].Cells[0].Value = (velocity.Item1 + " " + stringtranslation.meters_per_second);
                            break;
                        }
                        if (i == dataViewCalculations.Rows.Count - 1 && dataViewCalculations.Rows[i].Cells[0].Value != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i + 1, newRow);
                            dataViewCalculations.Rows[i + 1].Cells[0].Value = (velocity.Item1 + " " + stringtranslation.meters_per_second);
                            break;
                        }
                    }
                    StatusBar.Text = stringtranslation.Success_Message;
                }
                else
                {
                    StatusBar.Text = stringtranslation.invalid_input;
                }
            }
            else
            {
                StatusBar.Text = stringtranslation.empty_input;
            }
        }
        private void buttonStarDistance_Click(object sender, EventArgs e)
        {
            if (textBoxArcsecondAngle.Text != "")
            {
                var starDis = connection().StarDistance(double.Parse(textBoxArcsecondAngle.Text));
                if (starDis.Item3.Equals(true))
                {
                    for (int i = 0; i <= dataViewCalculations.Rows.Count; i++)
                    {
                        if (dataViewCalculations.Rows.Count == 0)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i, newRow);
                            dataViewCalculations.Rows[i].Cells[1].Value = (starDis.Item1 + " "+stringtranslation.Parsecs);
                            break;
                        }
                        if (dataViewCalculations.Rows[i].Cells[1].Value == null)
                        {
                            dataViewCalculations.Rows[i].Cells[1].Value = (starDis.Item1 + " " + stringtranslation.Parsecs);
                            break;
                        }

                        if (i == dataViewCalculations.Rows.Count - 1 && dataViewCalculations.Rows[i].Cells[1].Value != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i + 1, newRow);
                            dataViewCalculations.Rows[i + 1].Cells[1].Value = (starDis.Item1 + " " + stringtranslation.Parsecs);
                            break;
                        }
                    }
                    StatusBar.Text = stringtranslation.Success_Message;
                }
                else
                {
                    StatusBar.Text = stringtranslation.invalid_input;
                }
            }
            else
            {
                StatusBar.Text = stringtranslation.empty_input;
            }
        }
        private void buttonKelvinTemp_Click(object sender, EventArgs e)
        {

            if (textBoxCelsius.Text != "")
            {
                var kelvinTemp = connection().KelvinTemperature(double.Parse(textBoxCelsius.Text));
                if (kelvinTemp.Item3.Equals(true))
                {
                    for (int i = 0; i <= dataViewCalculations.Rows.Count; i++)
                    {
                        if (dataViewCalculations.Rows.Count == 0)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i, newRow);
                            dataViewCalculations.Rows[i].Cells[2].Value = (kelvinTemp.Item1 + " " +stringtranslation.Kelvin);
                            break;
                        }
                        if (dataViewCalculations.Rows[i].Cells[2].Value == null)
                        {
                            dataViewCalculations.Rows[i].Cells[2].Value = (kelvinTemp.Item1 + " " + stringtranslation.Kelvin);
                            break;
                        }

                        if (i == dataViewCalculations.Rows.Count - 1 && dataViewCalculations.Rows[i].Cells[2].Value != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i + 1, newRow);
                            dataViewCalculations.Rows[i + 1].Cells[2].Value = (kelvinTemp.Item1 + " " + stringtranslation.Kelvin);
                            break;
                        }
                    }
                StatusBar.Text = stringtranslation.Success_Message;
                }
                else
                {
                    StatusBar.Text = stringtranslation.invalid_input;
                }
            }
            else
            {
                StatusBar.Text = stringtranslation.empty_input;
            }

        }

        private void buttonEventHorizon_Click(object sender, EventArgs e)
        {
            if (textBoxBlackholeMass.Text != "")
            {
                var blackholeInput = double.Parse(textBoxBlackholeMass.Text) * Math.Pow(10, double.Parse(textBoxPower.Text));
                var blkholeMass = connection().EventHorizon(blackholeInput);
                if (blkholeMass.Item3.Equals(true))
                {
                    var blkholeResult = string.Format("{0:E2}", blkholeMass.Item1);
                    for (int i = 0; i <= dataViewCalculations.Rows.Count; i++)
                    {
                        if (dataViewCalculations.Rows.Count == 0)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i, newRow);
                            dataViewCalculations.Rows[i].Cells[3].Value = (blkholeResult + " "+stringtranslation.Meters);
                            break;
                        }
                        if (dataViewCalculations.Rows[i].Cells[3].Value == null)
                        {
                            dataViewCalculations.Rows[i].Cells[3].Value = (blkholeResult + " " + stringtranslation.Meters);
                            break;
                        }

                        if (i == dataViewCalculations.Rows.Count - 1 && dataViewCalculations.Rows[i].Cells[3].Value != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i + 1, newRow);
                            dataViewCalculations.Rows[i + 1].Cells[3].Value = (blkholeResult + " " + stringtranslation.Meters);
                            break;
                        }
                    }
                    StatusBar.Text = stringtranslation.Success_Message;
                }
                else
                {
                    StatusBar.Text = stringtranslation.invalid_input;
                }
            }
            else
            {
                StatusBar.Text = stringtranslation.empty_input;
            }
        }

        private void checkBoxMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMode.Text == Properties.stringtranslation.Night_Mode_Off)
            {
                BackgroundImage = null;
                BackColor = Color.FromArgb(20, 20, 20);
                dataViewCalculations.BackgroundColor = Color.DarkGray;

                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                StatusBar.ForeColor = Color.FromArgb(r, g, b);
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.FromArgb(r, g, b);
                }
                menuStripMalin.ForeColor = Color.Black;
                buttonFrench.ForeColor = Color.Black;
                StatusBar.BackColor = BackColor;
                dataViewCalculations.ForeColor = Color.Black;
                checkBoxMode.Text = Properties.stringtranslation.Night_Mode_On;
            }
            else
            {
                ResetFormat();
                checkBoxMode.Text = Properties.stringtranslation.Night_Mode_Off;
            }
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                BackgroundImage = null;
                BackColor = colorDialog.Color;
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.FromArgb(r, g, b);
                }
                menuStripMalin.ForeColor = Color.Black;
                dataViewCalculations.ForeColor = Color.Black;
            }
        }
        private void ResetFormat()
        {
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.happy_face;
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ForeColor = Color.Black;
            }
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                groupBox.ForeColor = Color.Black;
            }
            foreach (var buttons in Controls.OfType<Button>())
            {
                buttons.ForeColor = Color.Black;
            }
            StatusBar.BackColor = Color.Silver;
            StatusBar.ForeColor = Color.Black;
            dataViewCalculations.BackgroundColor = Color.Silver;
            menuStripMalin.ForeColor = Color.Black;
            dataViewCalculations.ForeColor = Color.Black;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormat();
            checkBoxMode.Text = Properties.stringtranslation.Night_Mode_Off;
        }
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                StatusBar.Text = Properties.stringtranslation.invalid_key;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                StatusBar.Text = Properties.stringtranslation.invalid_key; 
            }
        }

        private void textBoxObsLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }

        private void textBoxRestLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }

        private void textBoxArcsecondAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }

        private void textBoxCelsius_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }

        private void textBoxBlackholeMass_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress(sender, e);
        }
        private void ChangeLanguage(string language)
        {
            
            var result = MessageBox.Show(stringtranslation.Change_Language_Warning,stringtranslation.System_Information,MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    break;
            }
            Controls.Clear();
            InitializeComponent();
            }
            else
            {
                StatusBar.Text = stringtranslation.Operation_Cancel;
            }
        }

        private void buttonFrench_Click(object sender, EventArgs e)
        {
            ChangeLanguage("French");
            dataViewCalculations.AllowUserToAddRows = false;
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
            dataViewCalculations.AllowUserToAddRows = false;
        }

        private void buttonGerman_Click(object sender, EventArgs e)
        {
            ChangeLanguage("German");
            dataViewCalculations.AllowUserToAddRows = false;
        }
    } 
}
