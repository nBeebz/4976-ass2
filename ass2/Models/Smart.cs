using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ass2.Models
{
    public class Smart
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Client")]
        public int ClientReferenceNum { get; set; }
        public int AccompanimentMinutes { get; set; }
        public int NumberTransportsProvided { get; set; }
        public bool ReferredToNursePractitioner { get; set; }


        public virtual List<Sex> Sexes { get; set; }
        public virtual List<MultiplePerpertrator> MultiplePerpertrators { get; set; }
        public virtual List<DrugAssault> DrugAssaults { get; set; }
        public virtual List<CityOfAssualt> CityOfAssualts { get; set; }
        public virtual List<CityOfResidence> CityOfResidences { get; set; }
        public virtual List<ReferringHospital> ReferringHospitals { get; set; }
        public virtual List<HospitalAttended> HospitalAttendeds { get; set; }
        public virtual List<SocialWorkAttendance> SocialWorkAttendances { get; set; }
        public virtual List<PoliceAttendance> PoliceAttendances { get; set; }
        public virtual List<VictimServicesAttendance> VictimServicesAttendances { get; set; }
        public virtual List<MedicalOnly> MedicalOnlies { get; set; }
        public virtual List<EvidenceStored> EvidenceStoreds { get; set; }
        public virtual List<HIVMeds> HIVMedses { get; set; }
        public virtual List<ReferredToCBVS> ReferredToCBVSes { get; set; }
        public virtual List<PoliceReported> PoliceReporteds { get; set; }
        public virtual List<ThirdPartyReport> ThirdPartyReports { get; set; }
        public virtual List<BadDateReport> BadDateReports { get; set; }


    }
}