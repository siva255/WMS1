using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Client.DataLayer
{
    public class TabRightTimeService
    {
  
        public async Task<IEnumerable<TabRightTimeInfo>> GetTabRightTimeInfos()
        {
            //string calenderjson = "[\r\n  {\r\n    \"id\": 1,\r\n    \"dayName\": \"Mon\",\r\n    \"monthName\": \"Jan\",\r\n    \"taskCount\": \"10\"\r\n  },\r\n  {\r\n    \"id\": 2,\r\n    \"dayName\": \"Tue\",\r\n    \"monthName\": \"Jan\",\r\n    \"taskCount\": \"11\"\r\n  }\r\n\r\n\r\n]";
            string RightTimejson = "[\r\n  {\r\n    \"id\": 0,\r\n    \"starttime\": \"15:42 04-05-2021\",\r\n    \"estamatedtime\": \"17:42 04-05-2021 [2Hrs]\",\r\n    \"duein\": \"1Hr 55mins\"\r\n  }\r\n]";
           List<TabRightTimeInfo> timeInfos = JsonConvert.DeserializeObject<List<TabRightTimeInfo>>(RightTimejson);
       
            return timeInfos;
        }
    }
}
