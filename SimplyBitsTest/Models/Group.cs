using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyBitsTest.Models
{
    public class Group
    {
        public string PKID { get; set; }
        public string LocationID { get; set; }
        public string Description { get; set; }
        public string SortOrder { get; set; }
        public string ScheduleID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string UseDays { get; set; }
        public string DeletedWhen { get; set; }
        public string ExcludeOnline { get; set; }
        public string AccountID { get; set; }

        [JsonIgnore]
        public List<Section> Sections { get; set; }
    }
}