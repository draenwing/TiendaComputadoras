namespace Tienda_compu.Migrations.StoreContex
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datosRequeridos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categorias", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Productoes", "Nombre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Productoes", "Marca", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Productoes", "Ram", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Productoes", "Almacenamiento", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Productoes", "Peso", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Productoes", "TipoPantalla", c => c.String(nullable: false, maxLength: 70));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Productoes", "TipoPantalla", c => c.String());
            AlterColumn("dbo.Productoes", "Peso", c => c.String());
            AlterColumn("dbo.Productoes", "Almacenamiento", c => c.String());
            AlterColumn("dbo.Productoes", "Ram", c => c.String());
            AlterColumn("dbo.Productoes", "Marca", c => c.String());
            AlterColumn("dbo.Productoes", "Nombre", c => c.String());
            AlterColumn("dbo.Categorias", "Nombre", c => c.String());
        }
    }
}
