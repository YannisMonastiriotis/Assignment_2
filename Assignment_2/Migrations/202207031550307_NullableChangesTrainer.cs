namespace Assignment_2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class NullableChangesTrainer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trainers", "Salary", c => c.Decimal(precision: 18, scale: 2));
        }

        public override void Down()
        {
            AlterColumn("dbo.Trainers", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}