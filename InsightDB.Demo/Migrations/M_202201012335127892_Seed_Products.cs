using FluentMigrator;
using System;
using System.Linq;
namespace InsightDB.Demo.Migrations
{
    [Migration(202201012335127892)]
    public class M_202201012335127892_Seed_Products : Migration
    {
        Random random = new Random();
        public override void Down()
        {
            Delete.FromTable("Product").AllRows();
        }

        public override void Up()
        {
            for (var x = 0; x < 30; x++)
            {
                Insert.IntoTable("Product").Row(new
                {
                    Name = GetRandomString(random.Next(4, 8)),
                    Description = GetRandomString(random.Next(4, 8)),
                    CategoryId = random.Next(1, 6),
                    Price = random.NextDouble()
                });
            }
        }

        public  string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
