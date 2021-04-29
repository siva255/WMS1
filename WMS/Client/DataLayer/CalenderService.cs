using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Client.DataLayer
{
    public class CalenderService
    {
  
        public async Task<IEnumerable<CalenderInfo>> GetCalenderInfos()
        {
            //string calenderjson = "[\r\n  {\r\n    \"id\": 1,\r\n    \"dayName\": \"Mon\",\r\n    \"monthName\": \"Jan\",\r\n    \"taskCount\": \"10\"\r\n  },\r\n  {\r\n    \"id\": 2,\r\n    \"dayName\": \"Tue\",\r\n    \"monthName\": \"Jan\",\r\n    \"taskCount\": \"11\"\r\n  }\r\n\r\n\r\n]";
            string calenderjson = "[{\"id\":1,\"dayName\":\"Mon\",\"monthName\":\"Jan\",\"taskCount\":\"10\"},{\"id\":2,\"dayName\":\"Tue\",\"monthName\":\"Jan\",\"taskCount\":\"11\"},{\"id\":3,\"dayName\":\"wed\",\"monthName\":\"Jan\",\"taskCount\":\"12\"},{\"id\":4,\"dayName\":\"Thu\",\"monthName\":\"Jan\",\"taskCount\":\"13\"},{\"id\":5,\"dayName\":\"Fri\",\"monthName\":\"Jan\",\"taskCount\":\"14\"},{\"id\":6,\"dayName\":\"Sat\",\"monthName\":\"Jan\",\"taskCount\":\"15\"},{\"id\":7,\"dayName\":\"Sun\",\"monthName\":\"Jan\",\"taskCount\":\"16\"}]";
           List<CalenderInfo> returnCalenderInfo = JsonConvert.DeserializeObject<List<CalenderInfo>>(calenderjson);
       
            return returnCalenderInfo;
        }
    }
}
