namespace Invitacion.Models
{
    public class Conexion
    {
        public string cadenaSQL_Oracle;
        private string cadenaSQL_CCloud = string.Empty;
        public Conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();

            cadenaSQL_CCloud = configuration.GetValue<string>("ConnectionStrings:" + configuration.GetValue<string>("ConnectionStrings:BdCli"));
            cadenaSQL_Oracle = configuration.GetValue<string>("ConnectionStrings:" + configuration.GetValue<string>("ConnectionStrings:BdCsa"));
        }
        public string getCadenaSQL()
        {
            return cadenaSQL_CCloud;
        }
    }
}
