using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Providers
{
    public class StudentsProvider
    {
        public SqlConnection _connection;

        public StudentsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Student> GetAll()
        {
            List<Student> selectStudents = new List<Student>();

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        SELECT
                            [students].[Id],
                            [students].[FullName],
                            [students].[Gender],
                            [students].[Phone],
                            [students].[GroupId],

                            [groups].[Id],
                            [groups].[Name],
                            [groups].[YearCreation],
                            [groups].[SpecialtyId],

                            [specialties].[Id],
                            [specialties].[Code],
                            [specialties].[Name]
                    FROM
                        [students]

                    LEFT JOIN
                        [groups]
                    ON
                        [students].[GroupId] = [groups].[Id]

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
                        Student newStudent = new Student
                        {
                            Id = reader.GetInt32(0),
                            FullName = reader.GetString(1),
                            Gender = reader.GetString(2),
                            Phone = reader.GetString(3),
                            GroupId = reader.GetInt32(4),
                            Group = new StudentsGroup
                            {
                                Id = reader.GetInt32(4),
                                Name = reader.GetString(6),
                                YearCreation = reader.GetInt32(7),
                                SpecialtyId = reader.GetInt32(8),
                                Specialty = new Specialty
                                {
                                    Id = reader.GetInt32(8),
                                    Code = reader.GetString(10),
                                    Name = reader.GetString(11)
                                }
                            }
                        };

                        selectStudents.Add(newStudent);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return selectStudents;
        }

        public Student Get(int id)
        {
            Student selectStudent = null;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        SELECT
                            [students].[Id],
                            [students].[FullName],
                            [students].[Gender],
                            [students].[Phone],
                            [students].[GroupId],

                            [groups].[Id],
                            [groups].[Name],
                            [groups].[YearCreation],
                            [groups].[SpecialtyId],

                            [specialties].[Id],
                            [specialties].[Code],
                            [specialties].[Name]
                    FROM
                        [students]

                    LEFT JOIN
                        [groups]
                    ON
                        [students].[GroupId] = [groups].[Id]

                    RIGHT JOIN
                        [specialties]
                    ON
                        [groups].[SpecialtyId] = [specialties].[Id]
                    
                    WHERE
                        [students].[Id] = @Id
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        selectStudent = new Student
                        {
                            Id = reader.GetInt32(0),
                            FullName = reader.GetString(1),
                            Gender = reader.GetString(2),
                            Phone = reader.GetString(3),
                            GroupId = reader.GetInt32(4),
                            Group = new StudentsGroup
                            {
                                Id = reader.GetInt32(4),
                                Name = reader.GetString(6),
                                YearCreation = reader.GetInt32(7),
                                SpecialtyId = reader.GetInt32(8),
                                Specialty = new Specialty
                                {
                                    Id = reader.GetInt32(8),
                                    Code = reader.GetString(10),
                                    Name = reader.GetString(11)
                                }
                            }
                        };
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return selectStudent;
        }

        public bool Add(Student student)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        INSERT INTO [students]
                            ([FullName], [Gender], [Phone], [GroupId])
                        VALUES
                            (@FullName, @Gender, @Phone, @GroupId)
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@FullName", student.FullName);
                command.Parameters.AddWithValue("@Gender", student.Gender);
                command.Parameters.AddWithValue("@Phone", student.Phone);
                command.Parameters.AddWithValue("@GroupId", student.GroupId);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Update(int id, Student student)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        UPDATE
                            [students]
                        SET
                            [FullName] = @FullName,
                            [Gender] = @Gender,
                            [Phone] = @Phone,
                            [GroupId] = @GroupId
                        WHERE
                            [id] = @Id
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@FullName", student.FullName);
                command.Parameters.AddWithValue("@Gender", student.Gender);
                command.Parameters.AddWithValue("@Phone", student.Phone);
                command.Parameters.AddWithValue("@GroupId", student.GroupId);
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
