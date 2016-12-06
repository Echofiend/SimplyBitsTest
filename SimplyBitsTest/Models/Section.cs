using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplyBitsTest.Models
{
    public class Section
    {
        public string PKID { get; set; }
        public string LocationID { get; set; }
        public string Description { get; set; }
        public string SortOrder { get; set; }
        public object ScheduleID { get; set; }
        public string GroupID { get; set; }
        public string Type { get; set; }
        public string DeletedWhen { get; set; }
        public string ExcludeOnline { get; set; }
        public string AccountID { get; set; }

        [JsonIgnore]
        public List<Item> Items { get; set; }
    }
}