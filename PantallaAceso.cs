using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoConsulta
{
    public partial class PantallaAcceso : Form
    {

        public PantallaAcceso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtIngreso_Click(object sender, EventArgs e)
        {
            string usuarioComedor = TbUsuario.Text;
            PantallaMain FrmPantallaMain = new PantallaMain();
            FrmPantallaMain.Show();
            //if (CheckUser(usuarioComedor) != true)
            //{
            //    //abrir modal usuario no valido.
            //    TbUsuario.Text = "";
            //    TbUsuario.Focus();
            //}
            //else 
            //{//abrir la otra pagina//
            //    //enviar código y nombre.
            //      TbUsuario.Text = "";
            //      TbUsuario.Focus();
            //}

        }

        private bool CheckUser(string usuarioComedor)
        {
            bool encontrado = false;

            string queryCheck = "SELECT COUNT(NUM_EMP) FROM NOMINA..AN_COMEDOR_USUARIO WHERE USUARIO_COMEDOR='"+ usuarioComedor + "' AND F_BAJA='' AND F_SUSPENCION='' ";
            //EJECUTAR QUERY
            int userExist =1;//ejecutar query
            if (userExist == 1)
            {
                encontrado = true;
            }
            return encontrado;
        }

    }
}
