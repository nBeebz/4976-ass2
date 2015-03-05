namespace ass2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmartLookupAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BadDateReports",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CityOfAssaults",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CityOfResidences",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.DrugFacilitatedAssaults",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.EvidenceStoreds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.HIVMeds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.HospitalAttendeds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.MedicalOnlies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.MultiplePerpetrators",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PoliceAttendances",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PoliceReporteds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ReferredToCBVS",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ReferringHospitals",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SexWorkExploitations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SocialWorkAttendances",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ThirdPartyReports",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.VictimServicesAttendances",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VictimServicesAttendances");
            DropTable("dbo.ThirdPartyReports");
            DropTable("dbo.SocialWorkAttendances");
            DropTable("dbo.SexWorkExploitations");
            DropTable("dbo.ReferringHospitals");
            DropTable("dbo.ReferredToCBVS");
            DropTable("dbo.PoliceReporteds");
            DropTable("dbo.PoliceAttendances");
            DropTable("dbo.MultiplePerpetrators");
            DropTable("dbo.MedicalOnlies");
            DropTable("dbo.HospitalAttendeds");
            DropTable("dbo.HIVMeds");
            DropTable("dbo.EvidenceStoreds");
            DropTable("dbo.DrugFacilitatedAssaults");
            DropTable("dbo.CityOfResidences");
            DropTable("dbo.CityOfAssaults");
            DropTable("dbo.BadDateReports");
        }
    }
}
