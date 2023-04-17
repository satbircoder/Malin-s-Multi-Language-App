using Malin_s_AstroMath_App.Properties;
using System;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
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
            dataViewCalculations.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataViewCalculations.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataViewCalculations.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataViewCalculations.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataViewCalculations.AllowUserToAddRows = false;
        }

        private void buttonStarVelocity_Click(object sender, EventArgs e)
        {
            if (textBoxObsLength.Text != "" && textBoxRestLength.Text != "")
            {
                var velocity = connection().StarVelocity(double.Parse(textBoxObsLength.Text), double.Parse(textBoxRestLength.Text));
                if (velocity.Item3.Equals(true))
                {
                    for (int i = 0; i <= dataViewCalculations.Rows.Count;i++)
                    {
                        if (dataViewCalculations.Rows.Count == 0)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i, newRow);
                            dataViewCalculations.Rows[i].Cells[0].Value = (velocity.Item1 + velocity.Item2);
                            break;
                        }
                        if (dataViewCalculations.Rows[i].Cells[0].Value == null)
                        {
                            dataViewCalculations.Rows[i].Cells[0].Value = (velocity.Item1 + velocity.Item2);
                            break;
                        }

                        if (i == dataViewCalculations.Rows.Count-1 && dataViewCalculations.Rows[i].Cells[0].Value != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i + 1,newRow);
                            dataViewCalculations.Rows[i + 1].Cells[0].Value = (velocity.Item1 + velocity.Item2);
                            break;
                        }
                    }

                }
                else
                {
                    StatusBar.Text = velocity.ToString();
                }
            }
            else
            {
                StatusBar.Text = "Please enter the values";
            }
        }
        private void buttonStarDistance_Click(object sender, EventArgs e)
        {
            if(textBoxArcsecondAngle.Text != "")
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
                            dataViewCalculations.Rows[i].Cells[1].Value = (starDis.Item1 + starDis.Item2);
                            break;
                        }
                        if (dataViewCalculations.Rows[i].Cells[1].Value == null)
                        {
                            dataViewCalculations.Rows[i].Cells[1].Value = (starDis.Item1 + starDis.Item2);
                            break;
                        }

                        if (i == dataViewCalculations.Rows.Count-1  && dataViewCalculations.Rows[i].Cells[1].Value != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i+1, newRow);
                            dataViewCalculations.Rows[i+1].Cells[1].Value = (starDis.Item1 + starDis.Item2);
                            break;
                        }
                    }


                }
            }
            else
            {
                StatusBar.Text = "Please enter the values";
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
                            dataViewCalculations.Rows[i].Cells[2].Value = (kelvinTemp.Item1 + kelvinTemp.Item2);
                            break;
                        }
                        if (dataViewCalculations.Rows[i].Cells[2].Value == null)
                        {
                            dataViewCalculations.Rows[i].Cells[2].Value = (kelvinTemp.Item1 + kelvinTemp.Item2);
                            break;
                        }

                        if (i == dataViewCalculations.Rows.Count - 1 && dataViewCalculations.Rows[i].Cells[2].Value != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i + 1, newRow);
                            dataViewCalculations.Rows[i + 1].Cells[2].Value = (kelvinTemp.Item1 + kelvinTemp.Item2);
                            break;
                        }
                    }


                }
            }

        }

        private void buttonEventHorizon_Click(object sender, EventArgs e)
        {
            if (textBoxBlackholeMass.Text != "")
            {
                var blackholeInput =double.Parse(textBoxBlackholeMass.Text) * Math.Pow(10, double.Parse(textBoxPower.Text));
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
                            dataViewCalculations.Rows[i].Cells[3].Value = (blkholeResult +blkholeMass.Item2);
                            break;
                        }
                        if (dataViewCalculations.Rows[i].Cells[3].Value == null)
                        {
                            dataViewCalculations.Rows[i].Cells[3].Value = (blkholeResult + blkholeMass.Item2);
                            break;
                        }

                        if (i == dataViewCalculations.Rows.Count - 1 && dataViewCalculations.Rows[i].Cells[3].Value != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i + 1, newRow);
                            dataViewCalculations.Rows[i + 1].Cells[3].Value = (blkholeResult +blkholeMass.Item2);
                            break;
                        }
                    }


                }
            }
        }

        private void checkBoxMode_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMode.Text == "Night Mode Off")
            {
                BackgroundImage = null;
                BackColor = Color.FromArgb(20,20,20);
                dataViewCalculations.BackgroundColor = Color.DarkGray;
                
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                StatusBar.ForeColor = Color.FromArgb(r,g,b);
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.FromArgb(r, g, b);
                }
                menuStripMalin.ForeColor = Color.Black;
                buttonFrench.ForeColor = Color.Black;
                StatusBar.BackColor = BackColor;
                checkBoxMode.Text = "Night Mode On";
            }
            else
            {
                ResetFormat();
                checkBoxMode.Text = "Night Mode Off";
            }
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                BackgroundImage = null;
                BackColor = colorDialog.Color;
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                foreach(Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.FromArgb(r,g,b);
                }
                menuStripMalin.ForeColor = Color.Black;
            }
        }
        private void ResetFormat()
        {
           
            BackgroundImage = null;
            BackgroundImage = Resources.happy_face;
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
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormat();
            checkBoxMode.Text = "Night Mode Off";
        }
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { 
            e.Handled = true;
                StatusBar.Text = "Invalid Key Pressed";
            }
            if((e.KeyChar== '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled= true;
                StatusBar.Text = "Invalid Key Pressed";
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
    }
}
