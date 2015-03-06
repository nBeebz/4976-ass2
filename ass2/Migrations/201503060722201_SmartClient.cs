namespace ass2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmartClient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(),
                        FirstName = c.String(),
                        PoliceFileNum = c.String(),
                        CourtFileNum = c.Int(nullable: false),
                        SWCFileNum = c.Int(nullable: false),
                        RiskAssessmentAssigned = c.String(),
                        AbuserName = c.String(),
                        NumOfChildUnderSix = c.Int(nullable: false),
                        NumOfChildUnderTwelve = c.Int(nullable: false),
                        NumOfChildUnderEighteen = c.Int(nullable: false),
                        DateLastTransferred = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReopened = c.DateTime(nullable: false),
                        AbuserRelationship_id = c.Int(),
                        Age_id = c.Int(),
                        AssignedWorker_id = c.Int(),
                        Crisis_id = c.Int(),
                        DuplicateFile_id = c.Int(),
                        Ethnicity_id = c.Int(),
                        FamilyViolenceFile_id = c.Int(),
                        FiscalYear_id = c.Int(),
                        Incident_id = c.Int(),
                        Program_id = c.Int(),
                        ReferralContact_id = c.Int(),
                        ReferralSource_id = c.Int(),
                        RepeatClient_id = c.Int(),
                        RiskLevel_id = c.Int(),
                        RiskStatus_id = c.Int(),
                        Service_id = c.Int(),
                        VictimOfIncident_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AbuserRelationships", t => t.AbuserRelationship_id)
                .ForeignKey("dbo.Ages", t => t.Age_id)
                .ForeignKey("dbo.AssignedWorkers", t => t.AssignedWorker_id)
                .ForeignKey("dbo.Crises", t => t.Crisis_id)
                .ForeignKey("dbo.DuplicateFiles", t => t.DuplicateFile_id)
                .ForeignKey("dbo.Ethnicities", t => t.Ethnicity_id)
                .ForeignKey("dbo.FamilyViolenceFiles", t => t.FamilyViolenceFile_id)
                .ForeignKey("dbo.FiscalYears", t => t.FiscalYear_id)
                .ForeignKey("dbo.Incidents", t => t.Incident_id)
                .ForeignKey("dbo.Programs", t => t.Program_id)
                .ForeignKey("dbo.ReferralContacts", t => t.ReferralContact_id)
                .ForeignKey("dbo.ReferralSources", t => t.ReferralSource_id)
                .ForeignKey("dbo.RepeatClients", t => t.RepeatClient_id)
                .ForeignKey("dbo.RiskLevels", t => t.RiskLevel_id)
                .ForeignKey("dbo.RiskStatus", t => t.RiskStatus_id)
                .ForeignKey("dbo.Services", t => t.Service_id)
                .ForeignKey("dbo.VictimOfIncidents", t => t.VictimOfIncident_id)
                .Index(t => t.AbuserRelationship_id)
                .Index(t => t.Age_id)
                .Index(t => t.AssignedWorker_id)
                .Index(t => t.Crisis_id)
                .Index(t => t.DuplicateFile_id)
                .Index(t => t.Ethnicity_id)
                .Index(t => t.FamilyViolenceFile_id)
                .Index(t => t.FiscalYear_id)
                .Index(t => t.Incident_id)
                .Index(t => t.Program_id)
                .Index(t => t.ReferralContact_id)
                .Index(t => t.ReferralSource_id)
                .Index(t => t.RepeatClient_id)
                .Index(t => t.RiskLevel_id)
                .Index(t => t.RiskStatus_id)
                .Index(t => t.Service_id)
                .Index(t => t.VictimOfIncident_id);
            
            CreateTable(
                "dbo.FiscalYears",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Smarts",
                c => new
                    {
                        id = c.Int(nullable: false),
                        AccompanimentMinutes = c.Int(nullable: false),
                        NumberTransportsProvided = c.Int(nullable: false),
                        ReferredToNursePractitioner = c.Boolean(nullable: false),
                        BadDateReport_id = c.Int(),
                        CityOfAssault_id = c.Int(),
                        CityOfResidence_id = c.Int(),
                        DrugFacilitatedAssaults_id = c.Int(),
                        EvidenceStored_id = c.Int(),
                        HIVMeds_id = c.Int(),
                        HospitalAttended_id = c.Int(),
                        MedicalOnly_id = c.Int(),
                        MultiplePerpertrators_id = c.Int(),
                        PoliceAttendance_id = c.Int(),
                        PoliceReported_id = c.Int(),
                        ReferredToCBVS_id = c.Int(),
                        ReferringHospital_id = c.Int(),
                        SexWorkExploitation_id = c.Int(),
                        SocialWorkAttendance_id = c.Int(),
                        ThirdPartyReport_id = c.Int(),
                        VictimServicesAttendance_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.BadDateReports", t => t.BadDateReport_id)
                .ForeignKey("dbo.CityOfAssaults", t => t.CityOfAssault_id)
                .ForeignKey("dbo.CityOfResidences", t => t.CityOfResidence_id)
                .ForeignKey("dbo.Clients", t => t.id)
                .ForeignKey("dbo.DrugFacilitatedAssaults", t => t.DrugFacilitatedAssaults_id)
                .ForeignKey("dbo.EvidenceStoreds", t => t.EvidenceStored_id)
                .ForeignKey("dbo.HIVMeds", t => t.HIVMeds_id)
                .ForeignKey("dbo.HospitalAttendeds", t => t.HospitalAttended_id)
                .ForeignKey("dbo.MedicalOnlies", t => t.MedicalOnly_id)
                .ForeignKey("dbo.MultiplePerpetrators", t => t.MultiplePerpertrators_id)
                .ForeignKey("dbo.PoliceAttendances", t => t.PoliceAttendance_id)
                .ForeignKey("dbo.PoliceReporteds", t => t.PoliceReported_id)
                .ForeignKey("dbo.ReferredToCBVS", t => t.ReferredToCBVS_id)
                .ForeignKey("dbo.ReferringHospitals", t => t.ReferringHospital_id)
                .ForeignKey("dbo.SexWorkExploitations", t => t.SexWorkExploitation_id)
                .ForeignKey("dbo.SocialWorkAttendances", t => t.SocialWorkAttendance_id)
                .ForeignKey("dbo.ThirdPartyReports", t => t.ThirdPartyReport_id)
                .ForeignKey("dbo.VictimServicesAttendances", t => t.VictimServicesAttendance_id)
                .Index(t => t.id)
                .Index(t => t.BadDateReport_id)
                .Index(t => t.CityOfAssault_id)
                .Index(t => t.CityOfResidence_id)
                .Index(t => t.DrugFacilitatedAssaults_id)
                .Index(t => t.EvidenceStored_id)
                .Index(t => t.HIVMeds_id)
                .Index(t => t.HospitalAttended_id)
                .Index(t => t.MedicalOnly_id)
                .Index(t => t.MultiplePerpertrators_id)
                .Index(t => t.PoliceAttendance_id)
                .Index(t => t.PoliceReported_id)
                .Index(t => t.ReferredToCBVS_id)
                .Index(t => t.ReferringHospital_id)
                .Index(t => t.SexWorkExploitation_id)
                .Index(t => t.SocialWorkAttendance_id)
                .Index(t => t.ThirdPartyReport_id)
                .Index(t => t.VictimServicesAttendance_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Smarts", "VictimServicesAttendance_id", "dbo.VictimServicesAttendances");
            DropForeignKey("dbo.Smarts", "ThirdPartyReport_id", "dbo.ThirdPartyReports");
            DropForeignKey("dbo.Smarts", "SocialWorkAttendance_id", "dbo.SocialWorkAttendances");
            DropForeignKey("dbo.Smarts", "SexWorkExploitation_id", "dbo.SexWorkExploitations");
            DropForeignKey("dbo.Smarts", "ReferringHospital_id", "dbo.ReferringHospitals");
            DropForeignKey("dbo.Smarts", "ReferredToCBVS_id", "dbo.ReferredToCBVS");
            DropForeignKey("dbo.Smarts", "PoliceReported_id", "dbo.PoliceReporteds");
            DropForeignKey("dbo.Smarts", "PoliceAttendance_id", "dbo.PoliceAttendances");
            DropForeignKey("dbo.Smarts", "MultiplePerpertrators_id", "dbo.MultiplePerpetrators");
            DropForeignKey("dbo.Smarts", "MedicalOnly_id", "dbo.MedicalOnlies");
            DropForeignKey("dbo.Smarts", "HospitalAttended_id", "dbo.HospitalAttendeds");
            DropForeignKey("dbo.Smarts", "HIVMeds_id", "dbo.HIVMeds");
            DropForeignKey("dbo.Smarts", "EvidenceStored_id", "dbo.EvidenceStoreds");
            DropForeignKey("dbo.Smarts", "DrugFacilitatedAssaults_id", "dbo.DrugFacilitatedAssaults");
            DropForeignKey("dbo.Smarts", "id", "dbo.Clients");
            DropForeignKey("dbo.Smarts", "CityOfResidence_id", "dbo.CityOfResidences");
            DropForeignKey("dbo.Smarts", "CityOfAssault_id", "dbo.CityOfAssaults");
            DropForeignKey("dbo.Smarts", "BadDateReport_id", "dbo.BadDateReports");
            DropForeignKey("dbo.Clients", "VictimOfIncident_id", "dbo.VictimOfIncidents");
            DropForeignKey("dbo.Clients", "Service_id", "dbo.Services");
            DropForeignKey("dbo.Clients", "RiskStatus_id", "dbo.RiskStatus");
            DropForeignKey("dbo.Clients", "RiskLevel_id", "dbo.RiskLevels");
            DropForeignKey("dbo.Clients", "RepeatClient_id", "dbo.RepeatClients");
            DropForeignKey("dbo.Clients", "ReferralSource_id", "dbo.ReferralSources");
            DropForeignKey("dbo.Clients", "ReferralContact_id", "dbo.ReferralContacts");
            DropForeignKey("dbo.Clients", "Program_id", "dbo.Programs");
            DropForeignKey("dbo.Clients", "Incident_id", "dbo.Incidents");
            DropForeignKey("dbo.Clients", "FiscalYear_id", "dbo.FiscalYears");
            DropForeignKey("dbo.Clients", "FamilyViolenceFile_id", "dbo.FamilyViolenceFiles");
            DropForeignKey("dbo.Clients", "Ethnicity_id", "dbo.Ethnicities");
            DropForeignKey("dbo.Clients", "DuplicateFile_id", "dbo.DuplicateFiles");
            DropForeignKey("dbo.Clients", "Crisis_id", "dbo.Crises");
            DropForeignKey("dbo.Clients", "AssignedWorker_id", "dbo.AssignedWorkers");
            DropForeignKey("dbo.Clients", "Age_id", "dbo.Ages");
            DropForeignKey("dbo.Clients", "AbuserRelationship_id", "dbo.AbuserRelationships");
            DropIndex("dbo.Smarts", new[] { "VictimServicesAttendance_id" });
            DropIndex("dbo.Smarts", new[] { "ThirdPartyReport_id" });
            DropIndex("dbo.Smarts", new[] { "SocialWorkAttendance_id" });
            DropIndex("dbo.Smarts", new[] { "SexWorkExploitation_id" });
            DropIndex("dbo.Smarts", new[] { "ReferringHospital_id" });
            DropIndex("dbo.Smarts", new[] { "ReferredToCBVS_id" });
            DropIndex("dbo.Smarts", new[] { "PoliceReported_id" });
            DropIndex("dbo.Smarts", new[] { "PoliceAttendance_id" });
            DropIndex("dbo.Smarts", new[] { "MultiplePerpertrators_id" });
            DropIndex("dbo.Smarts", new[] { "MedicalOnly_id" });
            DropIndex("dbo.Smarts", new[] { "HospitalAttended_id" });
            DropIndex("dbo.Smarts", new[] { "HIVMeds_id" });
            DropIndex("dbo.Smarts", new[] { "EvidenceStored_id" });
            DropIndex("dbo.Smarts", new[] { "DrugFacilitatedAssaults_id" });
            DropIndex("dbo.Smarts", new[] { "CityOfResidence_id" });
            DropIndex("dbo.Smarts", new[] { "CityOfAssault_id" });
            DropIndex("dbo.Smarts", new[] { "BadDateReport_id" });
            DropIndex("dbo.Smarts", new[] { "id" });
            DropIndex("dbo.Clients", new[] { "VictimOfIncident_id" });
            DropIndex("dbo.Clients", new[] { "Service_id" });
            DropIndex("dbo.Clients", new[] { "RiskStatus_id" });
            DropIndex("dbo.Clients", new[] { "RiskLevel_id" });
            DropIndex("dbo.Clients", new[] { "RepeatClient_id" });
            DropIndex("dbo.Clients", new[] { "ReferralSource_id" });
            DropIndex("dbo.Clients", new[] { "ReferralContact_id" });
            DropIndex("dbo.Clients", new[] { "Program_id" });
            DropIndex("dbo.Clients", new[] { "Incident_id" });
            DropIndex("dbo.Clients", new[] { "FiscalYear_id" });
            DropIndex("dbo.Clients", new[] { "FamilyViolenceFile_id" });
            DropIndex("dbo.Clients", new[] { "Ethnicity_id" });
            DropIndex("dbo.Clients", new[] { "DuplicateFile_id" });
            DropIndex("dbo.Clients", new[] { "Crisis_id" });
            DropIndex("dbo.Clients", new[] { "AssignedWorker_id" });
            DropIndex("dbo.Clients", new[] { "Age_id" });
            DropIndex("dbo.Clients", new[] { "AbuserRelationship_id" });
            DropTable("dbo.Smarts");
            DropTable("dbo.FiscalYears");
            DropTable("dbo.Clients");
        }
    }
}
