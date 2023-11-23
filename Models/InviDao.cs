using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Invitacion.Models
{
	public class InviDao
	{
		public void InsertarLog(string nombres, string asistencia, string mensaje)
		{
			Conexion conexion = new Conexion();
			using (OracleConnection con = new OracleConnection(conexion.cadenaSQL_Oracle))
			{
				con.Open();

				OracleTransaction myTrans = null;
				OracleCommand cmd = con.CreateCommand();

				myTrans = con.BeginTransaction(IsolationLevel.ReadCommitted);
				cmd.Transaction = myTrans;

				try
				{
					cmd = new OracleCommand("pkg_log_webpay.WP_LOG_INT", con)
					{
						CommandType = CommandType.StoredProcedure
					};

					cmd.Parameters.Add("pNOMBRES", OracleDbType.Varchar2).Value = nombres;
					cmd.Parameters.Add("pASISTENCIA", OracleDbType.Varchar2).Value = asistencia;
					cmd.Parameters.Add("pMENSAJE", OracleDbType.Varchar2).Value = mensaje;

					cmd.ExecuteNonQuery();
					myTrans.Commit();
				}
				catch (Exception e)
				{
					myTrans.Rollback();
					throw new Exception(e.Message);
				}

			}
		}
	}
}
