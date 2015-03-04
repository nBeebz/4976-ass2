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


        }
    }
}
