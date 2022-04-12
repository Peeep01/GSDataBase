using Microsoft.EntityFrameworkCore;
using System;



namespace GSDataBase
{
    public class MyContext : DbContext
    {
        // соединений с сервером
        private static readonly string connectionString =
        "Server = 192.168.10.134; DataBase = Gosling228; User id = stud; password = stud";


        //провайдер
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        // поля коллекции модели
        public DbSet<DB.Model.Group> Groups { get; set; }
        public DbSet<DB.Model.Student> Students { get; set; }
        public DbSet<DB.Model.Predmet> Predmets { get; set; }
        public DbSet<DB.Model.StudentMarks> StudentMarks { get; set; }
    }
}
