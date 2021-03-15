﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071072_NguyenThanhPhong.Models
{
    [DataContract]
    public class WeatherInfo
    {
        [DataMember(Name ="location")]
        public string Location { get; set; }
        [DataMember(Name ="degree")]
        public float Degree { get; set; }
        [DataMember(Name = "dateTime")]
        public DateTime DateTime { get; set; }
    }
}
