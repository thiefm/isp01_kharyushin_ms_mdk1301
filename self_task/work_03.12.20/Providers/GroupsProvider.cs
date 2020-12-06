using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Providers
{
    public class GroupsProvider
    {
        public SqlConnection _connection;

        public GroupsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<StudentsGroup> GetAll()
        {
            List<StudentsGroup> selectGroups = new List<StudentsGroup>();

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        SELECT
                            [groups].[Id],
                            [groups].[Name],
                            [groups].[YearCreation],
                            [groups].[SpecialtyId],

                            [specialties].[Id],
                            [specialties].[Code],
                            [specialties].[Name]
                    FROM
                        [groups]

                    LEFT JOIN
                        [specialties]
                    ON
                        [groups].[SpecialtyId] = [specialties].[Id]
                    ",
                    _connection
                );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudentsGroup newGroup = new StudentsGroup
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            YearCreation = reader.GetInt32(2),
                            SpecialtyId = reader.GetInt32(3),
                            Specialty = new Specialty
                            {
                                Id = reader.GetInt32(3),
                                Code = reader.GetString(5),
                                Name = reader.GetString(6)
                            }
                        };

                        selectGroups.Add(newGroup);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return selectGroups;
        }

        public StudentsGroup Get(int id)
        {
            StudentsGroup selectGroup = new StudentsGroup();

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        SELECT
                            [groups].[Id],
                            [groups].[Name],
                            [groups].[YearCreation],
                            [groups].[SpecialtyId],

                            [specialties].[Id],
                            [specialties].[Code],
                            [specialties].[Name]
                    FROM
                        [groups]

                    LEFT JOIN
                        [specialties]
                    ON
                        [groups].[SpecialtyId] = [specialties].[Id]

                    WHERE
                        [groups].[Id] = @Id
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        selectGroup = new StudentsGroup
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            YearCreation = reader.GetInt32(2),
                            SpecialtyId = reader.GetInt32(3),
                            Specialty = new Specialty
                            {
                                Id = reader.GetInt32(3),
                                Code = reader.GetString(5),
                                Name = reader.GetString(6)
                            }
                        };
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return selectGroup;
        }

        public bool Add(StudentsGroup group)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        INSERT INTO [groups]
                            ([Name], [YearCreation], [SpecialtyId])
                        VALUES
                            (@Name, @YearCreation, @SpecialtyId)
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@Name", group.Name);
                command.Parameters.AddWithValue("@YearCreation", group.YearCreation);
                command.Parameters.AddWithValue("@SpecialtyId", group.SpecialtyId);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Update(int id, StudentsGroup group)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        UPDATE
                            [groups]
                        SET
                            [Name] = @Name,
                            [YearCreation] = @YearCreation,
                            [SpecialtyId] = @SpecialtyId
                        WHERE
                            [Id] = @Id
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@Name", group.Name);
                command.Parameters.AddWithValue("@YearCreation", group.YearCreation);
                command.Parameters.AddWithValue("@SpecialtyId", group.SpecialtyId);
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
