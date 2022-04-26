using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.DataBase
{
    public class ClsDataBase
    {
        #region variables privadas
        //permite crear la conexión con la base de datos
        private SqlConnection _objSqlConnection;
        //permite hacer una lectura de datos "select"
        private SqlDataAdapter _objSqlDataAdapter;
        //permite crear, actualizar y borrar datos
        private SqlCommand _objSqlCommand;
        //lista de tablas en respuesta a SqlDataAdapter
        private DataSet _dsResultados;
        //tabla para pasar a SqlAdapter y AqlCommand
        private DataTable _dtParametros;
        //nombre de la tabla es cuando reciba los DataSet (Resultados)
        private string _nombreTabla;
        //SP=Procedimiento Almacenado, valorScalar es porque quiero que me retorne algo despues de una accion en la BD
        private string _nombreSP,_mensajeErrorDB, _valorScalar, _nombreDB;
        private bool _scalar;

        #endregion

        #region variables públicas
        public SqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public SqlDataAdapter ObjSqlDataAdapter { get => _objSqlDataAdapter; set => _objSqlDataAdapter = value; }
        public SqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }
        public DataSet DsResultados { get => _dsResultados; set => _dsResultados = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string NombreTabla { get => _nombreTabla; set => _nombreTabla = value; }
        public string NombreSP { get => _nombreSP; set => _nombreSP = value; }
        public string MensajeErrorDB { get => _mensajeErrorDB; set => _mensajeErrorDB = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public string NombreDB { get => _nombreDB; set => _nombreDB = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }
        #endregion

        #region Constructores

        public ClsDataBase()
        {
            DtParametros = new DataTable("SpParametros");
            DtParametros.Columns.Add("Nombre");
            DtParametros.Columns.Add("TipoDato");
            DtParametros.Columns.Add("Valor");

            NombreDB = "DB_BasePruebas";
        }

        #endregion

        #region métodos privados
        //no retornan nada porque trabajan con parametros por referencia
        private void CrearConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            switch (ObjDataBase.NombreDB)
            {
                //cpnexión a base de datos
                case "DB_BasePruebas":
                    ObjDataBase.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConexión_DB_BasePruebas);
                    break;

                case "OtraDataBase":

                    break;
                default:
                    break;
            }
        }
        private void ValidarConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {

        }
        private void AgregarParametros(ref ClsDataBase ObjDataBase)
        {
            
        }
        private void PrepararConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {

        }
        private void EjecutarDataAdapter(ref ClsDataBase ObjDataBase)
        {

        }
        private void EjecutarCommand(ref ClsDataBase ObjDataBase)
        {

        }
       

        #endregion

        #region métodos públicos

        #endregion

    }
}
