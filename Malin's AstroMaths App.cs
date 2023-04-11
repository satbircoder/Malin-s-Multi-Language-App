using System;
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
                var blkholeMass = connection().EventHorizon(double.Parse(textBoxBlackholeMass.Text));
                if (blkholeMass.Item3.Equals(true))
                {
                    for (int i = 0; i <= dataViewCalculations.Rows.Count; i++)
                    {
                        if (dataViewCalculations.Rows.Count == 0)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i, newRow);
                            dataViewCalculations.Rows[i].Cells[3].Value = (blkholeMass.Item1 + blkholeMass.Item2);
                            break;
                        }
                        if (dataViewCalculations.Rows[i].Cells[3].Value == null)
                        {
                            dataViewCalculations.Rows[i].Cells[3].Value = (blkholeMass.Item1 + blkholeMass.Item2);
                            break;
                        }

                        if (i == dataViewCalculations.Rows.Count - 1 && dataViewCalculations.Rows[i].Cells[3].Value != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataViewCalculations);
                            dataViewCalculations.Rows.Insert(i + 1, newRow);
                            dataViewCalculations.Rows[i + 1].Cells[3].Value = (blkholeMass.Item1 + blkholeMass.Item2);
                            break;
                        }
                    }


                }
            }
        }

        
    }
}
