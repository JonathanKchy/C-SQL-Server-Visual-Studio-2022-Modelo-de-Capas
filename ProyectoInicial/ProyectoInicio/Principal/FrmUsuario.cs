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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ObjUsuario=new ClsUsuario()
            {
                Nombre=TxtNombre.Text,
                Apellido1=TxtApellido1.Text,
                Apellido2=TxtApellido2.Text,
                FechaNacimiento=DtpFechaNacimiento.Value,
                Estado=ChkEstado.Checked
            };

            ObjUsuarioLn.Create(ref ObjUsuario);

            if (ObjUsuario.MensajeError==null)
            {
                MessageBox.Show("El ID: "+ObjUsuario.ValorScalar+", fue agregado correctamente");
                CargarListaUsuarios();
            }
            else
            {
                MessageBox.Show(ObjUsuario.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ObjUsuario = new ClsUsuario()
            {
                IdUsuario=Convert.ToByte(LblUsuario.Text),
                Nombre = TxtNombre.Text,
                Apellido1 = TxtApellido1.Text,
                Apellido2 = TxtApellido2.Text,
                FechaNacimiento = DtpFechaNacimiento.Value,
                Estado = ChkEstado.Checked
            };

            ObjUsuarioLn.Update(ref ObjUsuario);

            if (ObjUsuario.MensajeError == null)
            {
                MessageBox.Show("El  fue actualizado correctamente");
                CargarListaUsuarios();
            }
            else
            {
                MessageBox.Show(ObjUsuario.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvUsuarios.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjUsuario = new ClsUsuario()
                    {
                        IdUsuario = Convert.ToByte(DgvUsuarios.Rows[e.RowIndex].Cells["IdUsuarios"].Value.ToString())
                    };
                    ObjUsuarioLn.Read(ref ObjUsuario);
                    TxtNombre.Text = ObjUsuario.Nombre;
                    TxtApellido1.Text = ObjUsuario.Apellido1;
                    TxtApellido2.Text = ObjUsuario.Apellido2;
                    DtpFechaNacimiento.Value = ObjUsuario.FechaNacimiento;
                    ChkEstado.Checked = ObjUsuario.Estado;
                    LblUsuario.Text = ObjUsuario.IdUsuario.ToString();
                }
             
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ObjUsuario = new ClsUsuario()
            {
                IdUsuario = Convert.ToByte(LblUsuario.Text)
            };
            ObjUsuarioLn.Delete(ref ObjUsuario);
            CargarListaUsuarios();
        }
    }
}
