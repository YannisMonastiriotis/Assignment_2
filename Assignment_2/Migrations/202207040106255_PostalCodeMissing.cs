namespace Assignment_2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PostalCodeMissing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainers", "PostalCode", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Trainers", "PostalCode");
        }
    }
}