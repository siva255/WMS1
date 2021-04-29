using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Client.DataLayer
{
    public class UpperMenuService

    {
  
        public async Task<IEnumerable<UpperMenuInfo>> GetUpperMenuInfos()
        {
                        string uppermenujson = "[{\r\n\t\t\"id\": 1,\r\n\t\t\"Tabid\": \"Mytask\",\r\n\t\t\"TabName\": \"My Task \",\r\n\t\t\"PageName\": \"mytask\"\r\n\t},\r\n\t{\r\n\t\t\"id\": 2,\r\n\t\t\"Tabid\": \"Dashbord\",\r\n\t\t\"TabName\": \"Dashbord \",\r\n\t\t\"PageName\": \"dashbord2\"\r\n\t},\r\n\t{\r\n\t\t\"id\": 3,\r\n\t\t\"Tabid\": \"Report\",\r\n\t\t\"TabName\": \"Report \",\r\n\t\t\"PageName\": \"report3\"\r\n\t}\r\n]";
           List<UpperMenuInfo> returnupperInfo = JsonConvert.DeserializeObject<List<UpperMenuInfo>>(uppermenujson);
       
            return returnupperInfo;
        }
    }
}

