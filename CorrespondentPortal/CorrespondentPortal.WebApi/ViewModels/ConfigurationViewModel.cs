using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.ViewModels
{
    public class ConfigurationViewModel
    {
        public KeyValuePair<string,string>[] Configurations { get; set; }
        public string BaseUrl { get; set; }

        public ConfigurationViewModel(KeyValuePair<string, string>[] configurations, string baseUrl)
        {
            Configurations = configurations;
            BaseUrl = baseUrl;
        }
    }
}
