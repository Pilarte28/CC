using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCaribe2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            //DataSet ds = oper.ConsultaConResultado(" select * from EMPLEADO");

            DataSet ds = oper.ConsultaConResultado("select EMPLEADO.idemp as ID, EMPLEADO.nomemp as Nombres, EMPLEADO.apeemp as Apellidos, EMPLEADO.cedulaemp as Cedula, DEPARTAMENTO.desdep as Departamento, EMPLEADO.sueldoemp as Sueldo, EMPLEADO.sexoemp as Sexo FROM EMPLEADO left join DEPARTAMENTO on EMPLEADO.idemp = DEPARTAMENTO.iddep; ");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Perfiles frm = new Perfiles(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perfiles frm = new Perfiles(button2.ToString());
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Perfiles frm = new Perfiles(empleadosToolStripMenuItem.ToString());
            //Form f = new Perfiles());
            //frm.ShowDialog();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfiles frm = new Perfiles(perfilesToolStripMenuItem.ToString());
            //Form f = new Perfiles());
            frm.ShowDialog();
        }

        private void nominaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nomina frm = new Nomina();
            frm.ShowDialog();
        }
    }
}
