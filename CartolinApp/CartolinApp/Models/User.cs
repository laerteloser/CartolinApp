﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolinApp.Models
{
    public class User
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}