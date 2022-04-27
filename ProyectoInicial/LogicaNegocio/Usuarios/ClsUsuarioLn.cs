using AccesoDatos.DataBase;
using Entidades.Usuarios;
using System;
using System.Data;

namespace LogicaNegocio.Usuarios
{
    public class ClsUsuarioLn
    {

        #region Variables Privadas
        private ClsDataBase ObjDataBase = null;

        #endregion

        #region Metodo Index
        public void Index(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Usuarios",
                NombreSP = "[SCH_GENERAL].[SP_Usuarios_Index]",
                Scalar = false

            };
        }
        #endregion

        #region CRUD Usuario

        #endregion

        #region Metodos Privados
        private void Ejecutar(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB==null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjUsuario.MensajeError = ObjDataBase.MensajeErrorDB;
                }
                else
                {
                    ObjUsuario.DtResultado=ObjDataBase.DsResultados.Tables[0];
                    if (ObjUsuario.DtResultado.Rows.Count==1)
                    {
                        foreach (DataRow item in ObjUsuario.DtResultado.Rows)
                        {
                            ObjUsuario.IdUsuario = Convert.ToByte(item["IdUsuario"].ToString());
                            ObjUsuario.Nombre = item["Nombre"].ToString();
                            ObjUsuario.Apellido1 = item["Apellido1"].ToString();
                            ObjUsuario.Apellido2 = item["Apellido2"].ToString();
                            ObjUsuario.FechaNacimiento = Convert.ToDateTime(item["FechaNacimiento"].ToString());
                            ObjUsuario.Estado = Convert.ToBoolean(item["Estado"].ToString());
                        }
                    }
                }
            }
        }
        #endregion
    }
}
