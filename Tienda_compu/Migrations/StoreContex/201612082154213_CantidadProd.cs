namespace Tienda_compu.Migrations.StoreContex
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CantidadProd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "Cantidad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "Cantidad");
        }
    }
}
