﻿using Libraria.Data;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace Libraria
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AppConfig //: AppConfigInterface
    {
        public string Connection { get; set; }
    }
}
