namespace Tienda_compu.Migrations.StoreContex
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregandoImagen : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        ImageName = c.String(maxLength: 255),
                        FileType = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Productoes", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.Productoes", "ImageUrl", c => c.String(nullable: false));
            DropColumn("dbo.Productoes", "Cantidad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productoes", "Cantidad", c => c.Int(nullable: false));
            DropForeignKey("dbo.Images", "ProductId", "dbo.Productoes");
            DropIndex("dbo.Images", new[] { "ProductId" });
            DropColumn("dbo.Productoes", "ImageUrl");
            DropTable("dbo.Images");
        }
    }
}
