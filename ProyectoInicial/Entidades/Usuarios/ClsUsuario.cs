using System;
using System.Data;

namespace Entidades.Usuarios
{
    public class ClsUsuario
    {
        #region Atributos privados
        private byte _idUsuario;
        private string _nombre, _apellido1,_apellido2;
        private DateTime _fechaNacimiento;
        private bool _estado;

        //atributos que se conectan a la BD
        private string _mensajeError, _valorScalar;
        private DataTable _dtResultado;

       
        #endregion

        #region Atributos publicos
        public byte IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
       
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        public string MensajeError { get => _mensajeError; set => _mensajeError = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public DataTable DtResultado { get => _dtResultado; set => _dtResultado = value; }
        public string Apellido1 { get => _apellido1; set => _apellido1 = value; }
        public string Apellido2 { get => _apellido2; set => _apellido2 = value; }
        #endregion
    }
}
