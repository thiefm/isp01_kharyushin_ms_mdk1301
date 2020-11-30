using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp5.Models;

namespace WindowsFormsApp5.Providers
{
    class SpecialtiesProvider
    {
        private SqlConnection _connection;

        public SpecialtiesProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Specialty> GetAll()
        {
            List<Specialty> result = new List<Specialty>();

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"SELECT
                        [id],
                        [code],
                        [name]
                    FROM
                        [Specialties]",
                    _connection
                );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var specialty = new Specialty
                        {
                            Id = reader.GetInt32(0),
                            Code = reader.GetString(1),
                            Name = reader.GetString(2)
                        };

                        result.Add(specialty);
                    }
                }

                return result;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Add(Specialty specialty)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        INSERT INTO [Specialties]
                            ([code], [name])
                        VALUES
                            (@Code, @Name)
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@Code", specialty.Code);
                command.Parameters.AddWithValue("@Name", specialty.Name);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Update(int id, Specialty specialty)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        UPDATE [Specialties]
                        SET
                            [code] = @Code, 
                            [name] = @Name
                        WHERE
                            [id] = @Id
                    "
                    ,
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Code", specialty.Code);
                command.Parameters.AddWithValue("@Name", specialty.Name);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        DELETE FROM
                            [Specialties]
                        WHERE
                            [id] = @Id
                    "
                    ,
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
    }
}
