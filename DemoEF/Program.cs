using DemoEF;
using DemoEF.Models;
using Microsoft.Data.SqlClient; // ADO
using Microsoft.EntityFrameworkCore; // EF + Microsoft.EntityFrameworkCore.SqlServer


const string connectionString = @"server=(localdb)\MSSQLLocalDB;database=DemoEF;integrated security=true;trustServerCertificate=true";

DbContextOptions options =
        new DbContextOptionsBuilder()
            .UseSqlServer(connectionString).Options;
using MyDBContext context = new MyDBContext(options);

foreach (Personnage p in GetAll())
{
    Console.WriteLine(p.Nom);
    Console.WriteLine(p.Job.Nom);
}

IEnumerable<Personnage> GetAll()
{
    return context.Personnage
        .Include(p => p.Job)
        //.Where(p => p.JobId == 1)
        .ToList();
}

using SqlConnection connection = new(connectionString);


//IEnumerable<Personnage> GetAll()
//{
//    connection.Open();
//    using SqlCommand command = connection.CreateCommand();
//    command.CommandText = "SELECT * FROM Personnage";
//    using SqlDataReader reader = command.ExecuteReader();
//    while (reader.Read())
//    {
//        yield return new Personnage
//        {
//            Id = (int)reader["Id"],
//            Nom = (string)reader["Nom"],
//            PvMax = (int)reader["PvMax"],
//            DateDeCreation = (DateTime)reader["DateDeCreation"],
//            Vivant = (bool)reader["Vivant"],
//            JobId = (int)reader["JobId"],
//        };
//    }

//    connection.Close();
//}