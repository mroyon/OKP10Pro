using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{
    public class UserHubModels
    {
        public string username { get; set; }
        public Guid userguid { get; set; }
        public long masteruserid { get; set; }
        public HashSet<string> connectionids { get; set; }

    }
}
