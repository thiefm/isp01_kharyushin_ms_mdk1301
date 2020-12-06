using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Providers
{
    public class SpecialtiesProvider
    {
        public SqlConnection _connection;

        public SpecialtiesProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Specialty> GetAll()
        {
            List<Specialty> selectSpecialties = new List<Specialty>();

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        SELECT
                            [Id],
                            [Code],
                            [Name]
                        FROM
                            [specialties]
                    ",
                    _connection
                );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Specialty newSpecialty = new Specialty
                        {
                            Id = reader.GetInt32(0),
                            Code = reader.GetString(1),
                            Name = reader.GetString(2)
                        };

                        selectSpecialties.Add(newSpecialty);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return selectSpecialties;
        }

        public Specialty Get(int id)
        {
            Specialty selectSpecialty = new Specialty();

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        SELECT
                            [specialties].[Id],
                            [specialties].[Code],
                            [specialties].[Name]
                    FROM
                        [specialties]
                    WHERE
                        [specialties].[Id] = @Id
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        selectSpecialty = new Specialty
                        {
                            Id = reader.GetInt32(0),
                            Code = reader.GetString(1),
                            Name = reader.GetString(2)
                        };
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return selectSpecialty;
        }

        public bool Add(Specialty specialty)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        INSERT INTO [specialties]
                            ([Code], [Name])
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
                        UPDATE
                            [specialties]
                        SET
                            [Code] = @Code,
                            [Name] = @Name
                        WHERE
                            [Id] = @Id
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@Code", specialty.Code);
                command.Parameters.AddWithValue("@Name", specialty.Name);
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
