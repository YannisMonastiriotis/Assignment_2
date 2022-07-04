namespace Assignment_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedingTrainer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TRAINERS (LastName,MiddleName,FirstName,Country,City,PostalCode,StreetName,StreetNo,Details,PhoneNum,Gender,Salary,EmailAddress,BirthDate) VALUES ('Monastiriotis', 'DimeBag', 'Giannis','Greece','Athens',11143,'Dassia',0,'Ola kala ola kala ola kala Ola kala Pane Ola kalaaaaaa',6977634451,'Male',10000,'hxo669@yahoo.gr','20120618 10:34:09 AM')");

        }



        public override void Down()
        {
        }
    }

}