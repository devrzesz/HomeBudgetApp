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
                        Name = c.String(),
                        OpeningBalance = c.Single(nullable: false),
                        Balance = c.Single(nullable: false),
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
                        BudgetAccount_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BudgetAccounts", t => t.BudgetAccount_Id)
                .Index(t => t.BudgetAccount_Id);
            
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
            DropForeignKey("dbo.Transactions", "BudgetAccount_Id", "dbo.BudgetAccounts");
            DropIndex("dbo.SubCategories", new[] { "MainCategoryId" });
            DropIndex("dbo.Transactions", new[] { "BudgetAccount_Id" });
            DropTable("dbo.SubCategories");
            DropTable("dbo.Payees");
            DropTable("dbo.Categories");
            DropTable("dbo.Transactions");
            DropTable("dbo.BudgetAccounts");
        }
    }
}
