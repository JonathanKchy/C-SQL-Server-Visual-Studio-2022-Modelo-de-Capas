using Entidades.Usuarios;
using LogicaNegocio.Usuarios;
using System;
using System.Windows.Forms;

namespace ProyectoInicio.Principal
{
    public partial class FrmUsuario : Form
    {
        private ClsUsuario ObjUsuario=null;
        private readonly ClsUsuarioLn ObjUsuarioLn = new ClsUsuarioLn();


        public FrmUsuario()
        {
            InitializeComponent();
            CargarListaUsuarios();
        }


        private void CargarListaUsuarios()
        {
            ObjUsuario = new ClsUsuario();
            ObjUsuarioLn.Index(ref ObjUsuario);
            if(ObjUsuario.MensajeError == null)
            {
                DgvUsuarios.DataSource = ObjUsuario.DtResultado;

            }
            else
            {
                MessageBox.Show(ObjUsuario.MensajeError, "Mensaje de Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
