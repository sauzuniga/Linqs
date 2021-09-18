using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQDPRUEBAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            List<string> usuarios = new List<string>() { "Maria Villanueva enable" ,"Diego Rivera enable" ,"Diego Arismas disable","Naun Alvarez disable" ,"Cesar Galeas enable"  };
            string answers = txtanswer.Text;
            if (answers=="enable")
            { 
            IEnumerable<string> users = from i in usuarios
                                        where i.EndsWith(answers)
                                        select i;
                lbusuarios.Items.Add("Los usuarios activos son:");
                foreach (string i in users)
            lbusuarios.Items.Add( i );
            }
            else
            {
                IEnumerable<string> users = from i in usuarios
                                            where i.EndsWith(answers)
                                            select i;
                lbusuarios.Items.Add("Los usuarios inactivo son: " );
                foreach (string i in users)
                    lbusuarios.Items.Add(i);
            }
        }
    }
}
