using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using ass2.Models;

namespace MigrationsDemo
{
    public class SimContext : DbContext
    {
        public DbSet<FiscalYear> FiscalYears { get; set; }
        public DbSet<RiskLevel> RiskLevels { get; set; }
        public DbSet<Crisis> Crises { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<RiskStatus> RiskStatuses { get; set; }
        public DbSet<AssignedWorker> AssignedWorkers { get; set; }
        public DbSet<ReferralSource> ReferralSources { get; set; }
        public DbSet<ReferralContact> ReferralContacts { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<AbuserRelationship> AbuserRelationships { get; set; }
        public DbSet<VictimOfIncident> VictimOfIncidents { get; set; }
        public DbSet<FamilyViolenceFile> FamilyViolenceFiles { get; set; }
        public DbSet<Ethnicity> Ethnicities { get; set; }
        public DbSet<Age> Ages { get; set; }
        public DbSet<RepeatClient> RepeatClients { get; set; }
        public DbSet<DuplicateFile> DuplicateFiles { get; set; }
        public DbSet<StatusOfFile> StatusOfFiles { get; set; }

        public virtual DbSet<ass2.Models.Client> Clients { get; set; }

    }


}