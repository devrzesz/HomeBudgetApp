namespace HomeBudgetWebApp.Models.Entities.Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BudgetAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        OpeningBalance = c.Single(),
                        Balance = c.Single(),
                        Type = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Type = c.Byte(nullable: false),
                        PayeeId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BudgetAccounts", t => t.PayeeId, cascadeDelete: true)
                .Index(t => t.PayeeId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MainCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.MainCategoryId, cascadeDelete: true)
                .Index(t => t.MainCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategories", "MainCategoryId", "dbo.Categories");
            DropForeignKey("dbo.Transactions", "PayeeId", "dbo.BudgetAccounts");
            DropIndex("dbo.SubCategories", new[] { "MainCategoryId" });
            DropIndex("dbo.Transactions", new[] { "PayeeId" });
            DropTable("dbo.SubCategories");
            DropTable("dbo.Payees");
            DropTable("dbo.Categories");
            DropTable("dbo.Transactions");
            DropTable("dbo.BudgetAccounts");
        }
    }
}
