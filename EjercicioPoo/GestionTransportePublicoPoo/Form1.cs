using GestionTransportePublicoPoo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTransportePublicoPoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVisualizarPasajeros_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var numUpDowns = GetNumUpDowns();

            if (numUpDowns.Count > 0)
            {
                numUpDowns.Sort((x,y) => x.Name.CompareTo(y.Name)); // Ordeno la lista ya que vienen los taxis primeros y por numero descendente
                foreach (var numUpDown in numUpDowns)
                {
                    if (numUpDown.Tag.ToString() == "taxi")
                    {
                        var taxi = new Taxi((int)numUpDown.Value);
                        if (taxi.GetPasajeros() == 0)
                        {
                            listBox1.Items.Add($"El taxi numero {numUpDown.Name[numUpDown.Name.Length - 1]} no reporta pasajeros.");
                        }
                        else
                        {
                            listBox1.Items.Add($"El taxi numero {numUpDown.Name[numUpDown.Name.Length - 1]} tiene {taxi.GetPasajeros()} pasajeros.");
                        }
                    }
                    else if(numUpDown.Tag.ToString() == "omnibus") 
                    {
                        var omnibus = new Omnibus((int)numUpDown.Value);
                        if (omnibus.GetPasajeros() == 0)
                        {
                            listBox1.Items.Add($"El omnibus numero {numUpDown.Name[numUpDown.Name.Length -1]} no reporta pasajeros.");
                        }
                        else
                        {
                            listBox1.Items.Add($"El omnibus numero {numUpDown.Name[numUpDown.Name.Length - 1]} tiene {omnibus.GetPasajeros()} pasajeros.");
                        }
                    }
                }
                listBox1.Items.Insert(5, string.Empty); // Separacion entre tipos de vehiculos
            }
            

        }
        private List<NumericUpDown> GetNumUpDowns()
        {
            var numUpDowns = new List<NumericUpDown>();
            foreach (Control c in Controls)
            {
                if (c is NumericUpDown)
                {
                    numUpDowns.Add((NumericUpDown) c);
                }
            }
            return numUpDowns;
        }

        private void nudTaxi_ValueChanged(object sender, EventArgs e)
        {
            var nud = (NumericUpDown) sender;
            if (nud.Value > 4)
            {
                MessageBox.Show("El taxi permite hasta 4 pasajeros. Por favor, ingrese un numero valido.", "Ingrese un numero valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nud.Value = 0;
                return;
            }
            
        }
        private void nudOmnibus_ValueChanged(object sender, EventArgs e)
        {
            var nud = (NumericUpDown)sender;

            if (nud.Value > 100)
            {
                MessageBox.Show("El omnibus permite hasta 100 pasajeros. Por favor, ingrese un numero valido.", "Ingrese un numero valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nud.Value = 0;
                return;
            }
        }

    }
}
