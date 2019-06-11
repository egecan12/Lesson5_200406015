namespace Lesson5_200406015.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Brand", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Type", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Type", c => c.String());
            AlterColumn("dbo.Cars", "Model", c => c.String());
            AlterColumn("dbo.Cars", "Brand", c => c.String());
        }
    }
}
