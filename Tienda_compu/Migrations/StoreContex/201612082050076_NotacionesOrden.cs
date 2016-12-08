namespace Tienda_compu.Migrations.StoreContex
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotacionesOrden : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ordens", "Username", c => c.String());
            AlterColumn("dbo.Ordens", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Ordens", "Apellido", c => c.String(nullable: false));
            AlterColumn("dbo.Ordens", "Direccion", c => c.String(nullable: false));
            AlterColumn("dbo.Ordens", "ciudad", c => c.String(nullable: false));
            AlterColumn("dbo.Ordens", "Pais", c => c.String(nullable: false));
            AlterColumn("dbo.Ordens", "correo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ordens", "correo", c => c.String());
            AlterColumn("dbo.Ordens", "Pais", c => c.String());
            AlterColumn("dbo.Ordens", "ciudad", c => c.String());
            AlterColumn("dbo.Ordens", "Direccion", c => c.String());
            AlterColumn("dbo.Ordens", "Apellido", c => c.String());
            AlterColumn("dbo.Ordens", "Nombre", c => c.String());
            DropColumn("dbo.Ordens", "Username");
        }
    }
}
