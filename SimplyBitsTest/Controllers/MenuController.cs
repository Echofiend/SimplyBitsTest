using Newtonsoft.Json;
using SimplyBitsTest.Models;
using SimplyBitsTest.ViewModels;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SimplyBitsTest.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            using(var client = new WebClient())
            {
                string jsonData = client.DownloadString(ConfigurationManager.AppSettings["JsonDataServer"].ToString());

                dynamic dynObj = JsonConvert.DeserializeObject<dynamic>(jsonData);

                List<Group> groups = dynObj.groups.ToObject<List<Group>>();
                groups = groups.OrderBy(e => e.SortOrder).ToList();

                List<Section> sections = dynObj.sections.ToObject<List<Section>>();
                sections = sections.OrderBy(e => e.SortOrder).ToList();

                List<Item> items = dynObj.items.ToObject<List<Item>>();

                foreach(var g in groups)
                {
                    List<string> groupSections = dynObj.groupSections[g.PKID.ToString()].ToObject<List<string>>();
                    g.Sections = sections.Where(e => groupSections.Contains(e.PKID)).OrderBy(e => e.Description).ToList();

                    foreach(var s in g.Sections)
                    {
                        List<string> sectionItems = dynObj.sectionItems[s.PKID.ToString()].ToObject<List<string>>();
                        s.Items = items.Where(e => sectionItems.Contains(e.PKID)).OrderBy(e => e.Name).ToList(); 
                    }
                }

                MenuViewModel vm = new MenuViewModel() { Groups = groups };
                
                return View(vm);
            } 
        }
    }
}