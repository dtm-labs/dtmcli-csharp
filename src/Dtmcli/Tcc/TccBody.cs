﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Dtmcli
{
    public class TccBody
    {
        [JsonPropertyName("gid")]
        public string Gid { get; set; }

        [JsonPropertyName("trans_type")]
        public string Trans_Type { get; set; }
    }
}
