namespace ass2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LookupInitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationships",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AssignedWorkers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Crises",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.DuplicateFiles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ethnicities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.FamilyViolenceFiles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Incidents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ReferralContacts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ReferralSources",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RepeatClients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RiskLevels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RiskStatus",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.StatusOfFiles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.VictimOfIncidents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VictimOfIncidents");
            DropTable("dbo.StatusOfFiles");
            DropTable("dbo.Services");
            DropTable("dbo.RiskStatus");
            DropTable("dbo.RiskLevels");
            DropTable("dbo.RepeatClients");
            DropTable("dbo.ReferralSources");
            DropTable("dbo.ReferralContacts");
            DropTable("dbo.Programs");
            DropTable("dbo.Incidents");
            DropTable("dbo.FamilyViolenceFiles");
            DropTable("dbo.Ethnicities");
            DropTable("dbo.DuplicateFiles");
            DropTable("dbo.Crises");
            DropTable("dbo.AssignedWorkers");
            DropTable("dbo.Ages");
            DropTable("dbo.AbuserRelationships");
        }
    }
}
