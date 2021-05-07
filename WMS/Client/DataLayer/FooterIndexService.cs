using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Client.DataLayer
{
    public class FooterIndexService

    {
  
        public async Task<IEnumerable<FooterIndexInfo>> GetFooterIndexInfos()
        {
                        string footermenujson = "[\r\n  {\r\n    \"id\": 1,\r\n    \"tabid\": \"files\",\r\n    \"tabName\": \"Files\",\r\n    \"pageName\": \"files\"\r\n  },\r\n  {\r\n    \"id\": 2,\r\n    \"tabid\": \"filehistory\",\r\n    \"tabName\": \"File History\",\r\n    \"pageName\": \"filehistory\"\r\n  },\r\n  {\r\n    \"id\": 3,\r\n    \"tabid\": \"property\",\r\n    \"tabName\": \"Property\",\r\n    \"pageName\": \"property\"\r\n  },\r\n  {\r\n    \"id\": 4,\r\n    \"tabid\": \"instruction\",\r\n    \"tabName\": \"Instruction\",\r\n    \"pageName\": \"instruction\"\r\n  }\r\n\r\n]";
           List<FooterIndexInfo> footerIndexInfos = JsonConvert.DeserializeObject<List<FooterIndexInfo>>(footermenujson);
       
            return footerIndexInfos;
        }
    }
}

   