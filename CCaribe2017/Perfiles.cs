using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCaribe2017
{
    public partial class Perfiles : Form
    {
        public Perfiles(string idemp)
        {
            InitializeComponent();
            llena_departamento();
            llena_sexo();
            if (idemp != null)
            {
                buscar(idemp);
            }
        }

        private void llena_departamento()
        {

            Operaciones oper = new Operaciones();
            DataSet ds = oper.ConsultaConResultado(" select * from DEPARTAMENTO ");
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.ValueMember = "iddep";
            comboBox2.DisplayMember = "desdep";
        }

        private void llena_sexo()
        {

            Operaciones oper = new Operaciones();
            DataSet ds = oper.ConsultaConResultado(" select sexoemp from EMPLEADO ");
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "sexoemp";
            comboBox1.DisplayMember = "sexoemp";
        }

        private void buscar(string id)
        {
            try
            {
                Operaciones oper = new Operaciones();
                DataSet ds = oper.ConsultaConResultado(" select * from EMPLEADO WHERE idemp='" + id + "'  ");
                //"select EMPLEADO.idemp as ID,  DEPARTAMENTO.desdep as Departamento, EMPLEADO.sueldoemp as Sueldo, EMPLEADO.sexoemp as Sexo FROM EMPLEADO left join DEPARTAMENTO on EMPLEADO.idemp = DEPARTAMENTO.iddep; "
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    if (fila["idemp"] != null) textBox2.Text = fila["idemp"].ToString();
                    if (fila["nomemp"] != null) textBox1.Text = fila["nomemp"].ToString();
                    if (fila["apeemp"] != null) textBox5.Text = fila["apeemp"].ToString();
                    if (fila["iddep"] != null) comboBox2.SelectedValue = fila["iddep"].ToString();
                    if (fila["cedulaemp"] != null) textBox3.Text = fila["cedulaemp"].ToString();
                    if (fila["diremp"] != null) textBox10.Text = fila["diremp"].ToString();
                    if (fila["estadoemp"] != null) textBox9.Text = fila["estadoemp"].ToString();
                    if (fila["sueldoemp"] != null) textBox8.Text = fila["sueldoemp"].ToString();
                    if (fila["sexoemp"] != null) comboBox1.Text = fila["sexoemp"].ToString();
                }

            }
            catch (Exception)
            {               
                //throw;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Perfiles_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            oper.ConsultaSinResultado(" INSERT INTO EMPLEADO (nomemp, apeemp)VALUES('" + textBox1.Text.ToString() + "','" + textBox5.Text.ToString() + "')");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            oper.ConsultaSinResultado(" UPDATE EMPLEADO SET nomemp='" + textBox1.Text.ToString() + "', apeemp='" + textBox5.Text.ToString() + "', iddep='" + comboBox2.SelectedValue + "' WHERE idemp='" + textBox2.Text + "'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscar(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Operaciones oper = new Operaciones();
           // DataSet ds = oper.ConsultaConResultado(" select * from EMPLEADO WHERE idemp='" + textBox2.Text + "' ");
            //ds.WriteXml("c:\\sistema\\db1.xml");

            //frmVisor f = new frmVisor("Empleado.rpt");
            //f.Show();

        }
    }
}
