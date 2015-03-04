using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ass2.Models
{
    public class Client
    {
        [Key]
        public int id { get; set; }
        [KeyAttribute()]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientReferenceNum { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string PoliceFileNum { get; set; }
        public int CourtFileNum { get; set; }
        public int SWCFileNum { get; set; }
        public string RiskAssessmentAssigned { get; set; }
        public string AbuserName { get; set; }
        public char Gender { get; set; }
        public int NumOfChildUnderSix { get; set; }
        public int NumOfChildUnderTwelve { get; set; }
        public int NumOfChildUnderEighteen { get; set; }
        public DateTime DateLastTransferred { get; set; }
        public DateTime DateClosed { get; set; }
        public DateTime DateReopened { get; set; }


        public virtual List<FiscalYear> FiscalYears{ get; set; }
        public virtual List<RiskLevel> RiskLevels { get; set; }
        public virtual List<Crisis> Crisises { get; set; }
        public virtual List<Service> Services { get; set; }
        public virtual List<Program> Programs { get; set; }
        public virtual List<RiskStatus> RiskStatuses { get; set; }
        public virtual List<AssignedWorker> AssignedWorkers { get; set; }
        public virtual List<ReferralSource> ReferralSources { get; set; }
        public virtual List<ReferralContact> ReferralContacts { get; set; }
        public virtual List<Incident> Incidents { get; set; }
        public virtual List<AbuserRelationship> AbuserRelationships { get; set; }
        public virtual List<VictimOfIncident> VictimOfIncidents { get; set; }
        public virtual List<FamilyViolenceFile> FamilyViolenceFiles { get; set; }
        public virtual List<Ethnicity> Ethnicities { get; set; }
        public virtual List<Age> Age { get; set; }
        public virtual List<RepeatClient> RepeatClients { get; set; }
        public virtual List<DuplicateFile> DuplicateFiles { get; set; }

    }
}