namespace Tienda_compu.Migrations.StoreContex
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrdenNotacion : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ordens", "Nombre", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Ordens", "Apellido", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Ordens", "CodigoPostal", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ordens", "CodigoPostal", c => c.String());
            AlterColumn("dbo.Ordens", "Apellido", c => c.String(nullable: false));
            AlterColumn("dbo.Ordens", "Nombre", c => c.String(nullable: false));
        }
    }
}
