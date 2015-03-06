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
        [ForeignKey("id")]
        public Client Client { get; set; }
        public int AccompanimentMinutes { get; set; }
        public int NumberTransportsProvided { get; set; }
        public bool ReferredToNursePractitioner { get; set; }


        public SexWorkExploitation SexWorkExploitation { get; set; }
        public MultiplePerpetrators MultiplePerpertrators { get; set; }
        public DrugFacilitatedAssault DrugFacilitatedAssaults { get; set; }
        public CityOfAssault CityOfAssault { get; set; }
        public CityOfResidence CityOfResidence { get; set; }
        public ReferringHospital ReferringHospital { get; set; }
        public HospitalAttended HospitalAttended { get; set; }
        public SocialWorkAttendance SocialWorkAttendance { get; set; }
        public PoliceAttendance PoliceAttendance { get; set; }
        public VictimServicesAttendance VictimServicesAttendance { get; set; }
        public MedicalOnly MedicalOnly { get; set; }
        public EvidenceStored EvidenceStored { get; set; }
        public HIVMeds HIVMeds { get; set; }
        public ReferredToCBVS ReferredToCBVS { get; set; }
        public PoliceReported PoliceReported { get; set; }
        public ThirdPartyReport ThirdPartyReport { get; set; }
        public BadDateReport BadDateReport { get; set; }


    }
}