using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformeRV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.lblFecha.Text =  DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.generosYLibros' Puede moverla o quitarla según sea necesario.
            this.generosYLibrosTableAdapter.Fill(this.dsBD.generosYLibros);

            this.reportViewer1.RefreshReport();
        }
    }
}
