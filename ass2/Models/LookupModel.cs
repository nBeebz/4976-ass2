using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ass2.Models
{
    public class RiskLevel
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class Crisis
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class Service
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class Program
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class RiskStatus
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class AssignedWorker
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class ReferralSource
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class ReferralContact
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class Incident
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class AbuserRelationship
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class VictimOfIncident
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class FamilyViolenceFile
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class Ethnicity
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class Age
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class RepeatClient
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class DuplicateFile
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }
    public class StatusOfFile
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }
    }


}