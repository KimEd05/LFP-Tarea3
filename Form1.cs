using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cadena = txtCadena.Text;
            string expresion = null;

            switch (comboBox.SelectedIndex)
            {
                case 0:
                    expresion = @"^\d+(.\d+)?$";
                    break;
                case 1:
                    expresion = @"^0*10*(10*10*)*$";
                    break;
                case 2:
                    expresion = @"^\d+((\+|\-|\*|\/)(\d)+)+$";
                    break;
                case 3:
                    expresion = @"^[A-Z][\w]*[\d]+[\w]*$";
                    break;
                case 4:
                    expresion = @"^(((http)(s)?\:\/\/)?[a-z]+.[\w]+[.a-z]+)$";
                    break;
                case 5:
                    expresion = @"^[\w|\-|\.]+\@[a-z]+[.a-z]+$";
                    break;
                case 6:
                    expresion = @"^([0-2][\d]|3[0-1])(\/)(0[1-9]|1[0-2])(\/)(2\d{3}|3000)$";
                    break;
                case 7:
                    expresion = @"^(True)|(False)+((\&\&|\|\|)(True)|(False))*$";
                    break;
                case 8:
                    expresion = @"^((25[0-5]|2[0-4][\d]|[1]?[\d][\d]?)(.)){3}(25[0-5]|2[0-4][\d]|[1]?[\d][\d]?)$";
                    break;
                case 9:
                    expresion = @"^(System.out.println)[(]\""(\w?\s?)+\""[)]$";
                    break;
                default:
                    break;
            }

            labelExpresion.Text = expresion;

            Match match = Regex.Match(cadena, expresion);
            if (match.Success)
            {
                labelValidacion.Text = "Cadena válida";
                labelValidacion.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelValidacion.Text = "Cadena inválida";
                labelValidacion.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void labelValidacion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
