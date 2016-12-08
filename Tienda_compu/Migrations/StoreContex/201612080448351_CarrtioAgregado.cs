namespace Tienda_compu.Migrations.StoreContex
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarrtioAgregado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carritoes",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        ProductoId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        ShoppingCartViewModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.RecordId)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.ShoppingCartViewModels", t => t.ShoppingCartViewModel_Id)
                .Index(t => t.ProductoId)
                .Index(t => t.ShoppingCartViewModel_Id);
            
            CreateTable(
                "dbo.OrdenDetalles",
                c => new
                    {
                        OrdenDetalleId = c.Int(nullable: false, identity: true),
                        OrdenId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrdenDetalleId)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ordens", t => t.OrdenId, cascadeDelete: true)
                .Index(t => t.OrdenId)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Ordens",
                c => new
                    {
                        OrdenId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Direccion = c.String(),
                        ciudad = c.String(),
                        CodigoPostal = c.String(),
                        Pais = c.String(),
                        telefono = c.String(),
                        correo = c.String(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrdenId);
            
            CreateTable(
                "dbo.ShoppingCartViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carritoes", "ShoppingCartViewModel_Id", "dbo.ShoppingCartViewModels");
            DropForeignKey("dbo.OrdenDetalles", "OrdenId", "dbo.Ordens");
            DropForeignKey("dbo.OrdenDetalles", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.Carritoes", "ProductoId", "dbo.Productoes");
            DropIndex("dbo.OrdenDetalles", new[] { "ProductoId" });
            DropIndex("dbo.OrdenDetalles", new[] { "OrdenId" });
            DropIndex("dbo.Carritoes", new[] { "ShoppingCartViewModel_Id" });
            DropIndex("dbo.Carritoes", new[] { "ProductoId" });
            DropTable("dbo.ShoppingCartViewModels");
            DropTable("dbo.Ordens");
            DropTable("dbo.OrdenDetalles");
            DropTable("dbo.Carritoes");
        }
    }
}
