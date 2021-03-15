using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoanLeMyLinh_5951071049.Models
{
    [DataContract]
    public class Student
    {
        [DataMember(Name = "Lop")]
        public string Lop { get; set; }
        [DataMember(Name = "Ten")]
        public string Ten { get; set; }
        [DataMember(Name = "Mssv")]
        public string Mssv { get; set; }
        [DataMember(Name = "Dia chi")]
        public string DiaChi { get; set; }
        [DataMember(Name = "DateTime")]
        public DateTime Datetime { get; set; }
    }
}