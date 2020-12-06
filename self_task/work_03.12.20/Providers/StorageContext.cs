using System.Data.SqlClient;

namespace WindowsFormsApp6.Providers
{
    public class StorageContext
    {
        public StudentsProvider Students { get; }
        public GroupsProvider Groups { get; }
        public SpecialtiesProvider Specialties { get; }

        public StorageContext()
        {
            var connection = CreateConnection();
            Students = new StudentsProvider(connection);
            Groups = new GroupsProvider(connection);
            Specialties = new SpecialtiesProvider(connection);
        }

        private SqlConnection CreateConnection()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = @"localhost",
                InitialCatalog = "second_storage",
                IntegratedSecurity = true
            };

            var strConnection = builder.ToString();
            return new SqlConnection(strConnection);
        }
    }
}
