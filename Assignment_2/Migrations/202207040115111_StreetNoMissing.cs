namespace Assignment_2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class StreetNoMissing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainers", "StreetNo", c => c.Int());
        }

        public override void Down()
        {
            DropColumn("dbo.Trainers", "StreetNo");
        }
    }
}