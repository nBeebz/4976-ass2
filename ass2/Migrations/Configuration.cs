namespace ass2.Migrations
{
    using ass2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MigrationsDemo.SimContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(MigrationsDemo.SimContext context)
        {
            context.RiskLevels.AddOrUpdate(
                a => a.id,
                new RiskLevel { value = "High" },
                new RiskLevel { value = "DVU" },
                new RiskLevel { value = "None" }
            );

            context.Crises.AddOrUpdate(
                a => a.id,
                new Crisis { value = "Call" },
                new Crisis { value = "Accompaniment" },
                new Crisis { value = "Drop-In" }
            );

            context.Services.AddOrUpdate(
                a => a.id,
                new Service { value = "File" },
                new Service { value = "N/A" }
            );

            context.Programs.AddOrUpdate(
                a => a.id,
                new Program { value = "Crisis" },
                new Program { value = "Court" },
                new Program { value = "SMART" },
                new Program { value = "DVU" },
                new Program { value = "MCFD" }
            );

            context.RiskStatuses.AddOrUpdate(
                a => a.id,
                new RiskStatus { value = "Pending" },
                new RiskStatus { value = "Complete" },
                new RiskStatus { value = "None" }
            );

            context.AssignedWorkers.AddOrUpdate(
                a => a.id,
                new AssignedWorker { value = "Michelle" },
                new AssignedWorker { value = "Tyra" },
                new AssignedWorker { value = "Louise" },
                new AssignedWorker { value = "Angela" },
                new AssignedWorker { value = "Dave" },
                new AssignedWorker { value = "Troy" },
                new AssignedWorker { value = "Michael" },
                new AssignedWorker { value = "Manpreet" },
                new AssignedWorker { value = "Patrick" },
                new AssignedWorker { value = "None" }
            );

            context.ReferralSources.AddOrUpdate(
                a => a.id,
                new ReferralSource { value = "Community Agency" },
                new ReferralSource { value = "Family/Friend" },
                new ReferralSource { value = "Government" },
                new ReferralSource { value = "CVAP" },
                new ReferralSource { value = "CBVS" }
            );

            context.ReferralContacts.AddOrUpdate(
                a => a.id,
                new ReferralContact { value = "PBVS" },
                new ReferralContact { value = "MCFD" },
                new ReferralContact { value = "PBVS" },
                new ReferralContact { value = "VictimLINK" },
                new ReferralContact { value = "TH" },
                new ReferralContact { value = "Self" },
                new ReferralContact { value = "FNS" },
                new ReferralContact { value = "Other" },
                new ReferralContact { value = "Medical" }
            );

            context.Incidents.AddOrUpdate(
                a => a.id,
                new Incident { value = "Abduction" },
                new Incident { value = "Adult Historical Sexual Assault" },
                new Incident { value = "Adult Sexual Assault" },
                new Incident { value = "Partner Assault" },
                new Incident { value = "Attempted Murder" },
                new Incident { value = "Child Physical Assault" },
                new Incident { value = "Child Sexual Abuse/Exploitation" },
                new Incident { value = "Criminal Harassment/Stalking" },
                new Incident { value = "Elder Abuse" },
                new Incident { value = "Human Trafficking" },
                new Incident { value = "Murder" },
                new Incident { value = "N/A" },
                new Incident { value = "Other" },
                new Incident { value = "Other Assault" },
                new Incident { value = "Other Crime – DV" },
                new Incident { value = "Other Familial Assault" },
                new Incident { value = "Threatening" },
                new Incident { value = "Youth Sexual Assault/Exploitation" }
            );

            context.AbuserRelationships.AddOrUpdate(
                a => a.id,
                new AbuserRelationship { value = "Acquaintance" },
                new AbuserRelationship { value = "Bad Date" },
                new AbuserRelationship { value = "DNA" },
                new AbuserRelationship { value = "Ex-Partner" },
                new AbuserRelationship { value = "Friend" },
                new AbuserRelationship { value = "Multiple Perps" },
                new AbuserRelationship { value = "N/A" },
                new AbuserRelationship { value = "Other" },
                new AbuserRelationship { value = "Other Familial" },
                new AbuserRelationship { value = "Parent" },
                new AbuserRelationship { value = "Partner" },
                new AbuserRelationship { value = "Sibling" },
                new AbuserRelationship { value = "Stranger" }
            );

            context.VictimOfIncidents.AddOrUpdate(
                a => a.id,
                new VictimOfIncident { value = "Primary" },
                new VictimOfIncident { value = "Secondary" }
            );

            context.FamilyViolenceFiles.AddOrUpdate(
                a => a.id,
                new FamilyViolenceFile { value = "Yes" },
                new FamilyViolenceFile { value = "No" },
                new FamilyViolenceFile { value = "N/A" }
            );

            context.Ethnicities.AddOrUpdate(
                a => a.id,
                new Ethnicity { value = "Indigenous" },
                new Ethnicity { value = "Asian" },
                new Ethnicity { value = "Black" },
                new Ethnicity { value = "Caucasian" },
                new Ethnicity { value = "Declined" },
                new Ethnicity { value = "Latin" },
                new Ethnicity { value = "Middle Eastern" },
                new Ethnicity { value = "Other" },
                new Ethnicity { value = "South Asian" },
                new Ethnicity { value = "South East Asian" }
            );

            context.Ages.AddOrUpdate(
                a => a.id,
                new Age { value = "Adult: 25 - 64" },
                new Age { value = "Youth: 12 - 19" },
                new Age { value = "Youth: 18 - 24" },
                new Age { value = "Child: 13 or under" },
                new Age { value = "Senior:  65+" }
            );

            context.RepeatClients.AddOrUpdate(
                a => a.id,
                new RepeatClient { value = "Yes" },
                new RepeatClient { value = "No" }
            );

            context.DuplicateFiles.AddOrUpdate(
                a => a.id,
                new DuplicateFile { value = "Yes" },
                new DuplicateFile { value = "No" }
            );

            context.StatusOfFiles.AddOrUpdate(
                a => a.id,
                new StatusOfFile { value = "Reopened" },
                new StatusOfFile { value = "Closed" },
                new StatusOfFile { value = "Open" }
            );

            context.SexWorkExploitation.AddOrUpdate(
	            a => a.id,
	            new SexWorkExploitation { value = "Yes" },
	            new SexWorkExploitation { value = "No" },
	            new SexWorkExploitation { value = "N/A" }
            );

            context.MultiplePerpetrators.AddOrUpdate(
	            a => a.id,
	            new MultiplePerpetrators { value = "Yes" },
	            new MultiplePerpetrators { value = "No" },
	            new MultiplePerpetrators { value = "N/A" }
            );

            context.DrugFacilitatedAssault.AddOrUpdate(
	            a => a.id,
	            new DrugFacilitatedAssault { value = "Yes" },
	            new DrugFacilitatedAssault { value = "No" },
	            new DrugFacilitatedAssault { value = "N/A" }
            );

            context.CityOfAssault.AddOrUpdate(
	            a => a.id,
	            new CityOfAssault { value = "Surrey" },
	            new CityOfAssault { value = "Abbotsford" },
	            new CityOfAssault { value = "Agassiz" },
	            new CityOfAssault { value = "BostonBar" },
	            new CityOfAssault { value = "Burnaby" },
	            new CityOfAssault { value = "Chilliwack" },
	            new CityOfAssault { value = "Coquitlam" },
	            new CityOfAssault { value = "Delta" },
	            new CityOfAssault { value = "HarrisonHotSprings" },
	            new CityOfAssault { value = "Hope" },
	            new CityOfAssault { value = "Langley" },
	            new CityOfAssault { value = "MapleRidge" },
	            new CityOfAssault { value = "Mission" },
	            new CityOfAssault { value = "NewWestminster" },
	            new CityOfAssault { value = "PittMeadows" },
	            new CityOfAssault { value = "PortCoquitlam" },
	            new CityOfAssault { value = "PortMoody" },
	            new CityOfAssault { value = "Vancouver" },
	            new CityOfAssault { value = "WhiteRock" },
	            new CityOfAssault { value = "Yale" },
	            new CityOfAssault { value = "Other–BC" },
	            new CityOfAssault { value = "Out-of-Province" },
	            new CityOfAssault { value = "International" }
            );

            context.CityOfResidence.AddOrUpdate(
	            a => a.id,
	            new CityOfResidence { value = "Surrey" },
	            new CityOfResidence { value = "Abbotsford" },
	            new CityOfResidence { value = "Agassiz" },
	            new CityOfResidence { value = "BostonBar" },
	            new CityOfResidence { value = "Burnaby" },
	            new CityOfResidence { value = "Chilliwack" },
	            new CityOfResidence { value = "Coquitlam" },
	            new CityOfResidence { value = "Delta" },
	            new CityOfResidence { value = "HarrisonHotSprings" },
	            new CityOfResidence { value = "Hope" },
	            new CityOfResidence { value = "Langley" },
	            new CityOfResidence { value = "MapleRidge" },
	            new CityOfResidence { value = "Mission" },
	            new CityOfResidence { value = "NewWestminster" },
	            new CityOfResidence { value = "PittMeadows" },
	            new CityOfResidence { value = "PortCoquitlam" },
	            new CityOfResidence { value = "PortMoody" },
	            new CityOfResidence { value = "Vancouver" },
	            new CityOfResidence { value = "WhiteRock" },
	            new CityOfResidence { value = "Yale" },
	            new CityOfResidence { value = "Other–BC" },
	            new CityOfResidence { value = "Out-of-Province" },
	            new CityOfResidence { value = "International" }
            );

            context.ReferringHospital.AddOrUpdate(
	            a => a.id,
	            new ReferringHospital { value = "Abbotsford Regional Hospital" },
	            new ReferringHospital { value = "Surrey Memorial Hospital" },
	            new ReferringHospital { value = "Burnaby Hospital" },
	            new ReferringHospital { value = "Chilliwack General Hospital" },
	            new ReferringHospital { value = "Delta Hospital" },
	            new ReferringHospital { value = "Eagle Ridge Hospital" },
	            new ReferringHospital { value = "Fraser Canyon Hospital" },
	            new ReferringHospital { value = "Langley Hospital" },
	            new ReferringHospital { value = "Mission Hospital" },
	            new ReferringHospital { value = "Peace Arch Hospital" },
	            new ReferringHospital { value = "Ridge Meadows Hospital" },
	            new ReferringHospital { value = "Royal Columbia Hospital" }
            );

            context.HospitalAttended.AddOrUpdate(
	            a => a.id,
	            new HospitalAttended { value = "Abbotsford Regional Hospital" },
	            new HospitalAttended { value = "Surrey Memorial Hospital" },
	            new HospitalAttended { value = "Burnaby Hospital" },
	            new HospitalAttended { value = "Chilliwack General Hospital" },
	            new HospitalAttended { value = "Delta Hospital" },
	            new HospitalAttended { value = "Eagle Ridge Hospital" },
	            new HospitalAttended { value = "Fraser Canyon Hospital" },
	            new HospitalAttended { value = "Langley Hospital" },
	            new HospitalAttended { value = "Mission Hospital" },
	            new HospitalAttended { value = "Peace Arch Hospital" },
	            new HospitalAttended { value = "Ridge Meadows Hospital" },
	            new HospitalAttended { value = "Royal Columbia Hospital" }
            );

            context.SocialWorkAttendance.AddOrUpdate(
	            a => a.id,
	            new SocialWorkAttendance { value = "Yes" },
	            new SocialWorkAttendance { value = "No" },
	            new SocialWorkAttendance { value = "N/A" }
            );

            context.PoliceAttendance.AddOrUpdate(
	            a => a.id,
	            new PoliceAttendance { value = "Yes" },
	            new PoliceAttendance { value = "No" },
	            new PoliceAttendance { value = "N/A" }
            );

            context.VictimServicesAttendance.AddOrUpdate(
	            a => a.id,
	            new VictimServicesAttendance { value = "Yes" },
	            new VictimServicesAttendance { value = "No" },
	            new VictimServicesAttendance { value = "N/A" }
            );

            context.MedicalOnly.AddOrUpdate(
	            a => a.id,
	            new MedicalOnly { value = "Yes" },
	            new MedicalOnly { value = "No" },
	            new MedicalOnly { value = "N/A" }
            );

            context.EvidenceStored.AddOrUpdate(
	            a => a.id,
	            new EvidenceStored { value = "Yes" },
	            new EvidenceStored { value = "No" },
	            new EvidenceStored { value = "N/A" }
            );

            context.HIVMeds.AddOrUpdate(
	            new HIVMeds { value = "Yes" },
	            new HIVMeds { value = "No" },
	            new HIVMeds { value = "N/A" }
            );

            context.ReferredToCBVS.AddOrUpdate(
	            a => a.id,
	            new ReferredToCBVS { value = "Yes" },
	            new ReferredToCBVS { value = "No" },
	            new ReferredToCBVS { value = "PVBS Only" },
	            new ReferredToCBVS { value = "N/A" }
            );

            context.PoliceReported.AddOrUpdate(
	            a => a.id,
	            new PoliceReported { value = "Yes" },
	            new PoliceReported { value = "No" },
	            new PoliceReported { value = "N/A" }
            );

            context.ThirdPartyReport.AddOrUpdate(
	            a => a.id,
	            new ThirdPartyReport { value = "Yes" },
	            new ThirdPartyReport { value = "No" },
	            new ThirdPartyReport { value = "N/A" }
            );

            context.BadDateReport.AddOrUpdate(
	            a => a.id,
	            new BadDateReport { value = "Yes" },
	            new BadDateReport { value = "No" },
	            new BadDateReport { value = "N/A" }
            );
        }
    }
}
