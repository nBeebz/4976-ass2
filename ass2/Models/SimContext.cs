using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using ass2.Models;

namespace MigrationsDemo
{
    public class SimContext : DbContext
    {
        /* Client Entity Lookup Tables */
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

        /* Smart Entity Lookup Tables */
        public DbSet<SexWorkExploitation> SexWorkExploitation { get; set; }
        public DbSet<MultiplePerpetrators> MultiplePerpetrators { get; set; }
        public DbSet<DrugFacilitatedAssault> DrugFacilitatedAssault { get; set; }
        public DbSet<CityOfAssault> CityOfAssault { get; set; }
        public DbSet<CityOfResidence> CityOfResidence { get; set; }
        public DbSet<ReferringHospital> ReferringHospital { get; set; }
        public DbSet<HospitalAttended> HospitalAttended { get; set; }
        public DbSet<SocialWorkAttendance> SocialWorkAttendance { get; set; }
        public DbSet<PoliceAttendance> PoliceAttendance { get; set; }
        public DbSet<VictimServicesAttendance> VictimServicesAttendance { get; set; }
        public DbSet<MedicalOnly> MedicalOnly { get; set; }
        public DbSet<EvidenceStored> EvidenceStored { get; set; }
        public DbSet<HIVMeds> HIVMeds { get; set; }
        public DbSet<ReferredToCBVS> ReferredToCBVS { get; set; }
        public DbSet<PoliceReported> PoliceReported { get; set; }
        public DbSet<ThirdPartyReport> ThirdPartyReport { get; set; }
        public DbSet<BadDateReport> BadDateReport { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Smart> Smarts { get; set; } 

    }


}