using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ass2.Models
{
        public class SexWorkExploitation
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class MultiplePerpetrators
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class DrugFacilitatedAssault
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class CityOfAssault
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class CityOfResidence
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class ReferringHospital
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class HospitalAttended
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class SocialWorkAttendance
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class PoliceAttendance
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class VictimServicesAttendance
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class MedicalOnly
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class EvidenceStored
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class HIVMeds
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class ReferredToCBVS
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class PoliceReported
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class ThirdPartyReport
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
        public class BadDateReport
        {
            [Key]
            public int id { get; set; }
            public string value { get; set; }
        }
}