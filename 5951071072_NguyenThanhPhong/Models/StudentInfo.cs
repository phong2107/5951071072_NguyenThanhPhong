using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071072_NguyenThanhPhong.Models
{
    public class StudentInfo
    {
        [DataMember(Name = "idStu")]
        public string idStu { get; set; }
        [DataMember(Name = "NameStu")]
        public String NameStu { get; set; }
        [DataMember(Name = "SdtStu")]
        public String SdtStu { get; set; }
    }
}