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
        [Key][Column(Order = 0)]
        public int id { get; set; }
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


        public FiscalYear FiscalYear{ get; set; }
        public RiskLevel RiskLevel { get; set; }
        public Crisis Crisis { get; set; }
        public Service Service { get; set; }
        public Program Program { get; set; }
        public RiskStatus RiskStatus { get; set; }
        public AssignedWorker AssignedWorker { get; set; }
        public ReferralSource ReferralSource { get; set; }
        public ReferralContact ReferralContact { get; set; }
        public Incident Incident { get; set; }
        public AbuserRelationship AbuserRelationship { get; set; }
        public VictimOfIncident VictimOfIncident { get; set; }
        public FamilyViolenceFile FamilyViolenceFile { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public Age Age { get; set; }
        public RepeatClient RepeatClient { get; set; }
        public DuplicateFile DuplicateFile { get; set; }

    }
}