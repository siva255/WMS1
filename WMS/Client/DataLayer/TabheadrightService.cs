using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Client.DataLayer
{
    public class TabheadrightService

    {
  
        public async Task<IEnumerable<TabheadrightInfo>> GetTabheadrightInfos()
        {
           string innertaskjson = "[\n  {\n    \"id\": 1,\n    \"listName\": \"Current Stage\",\n    \"checkboxId\": \"project1\",\n    \"checkboxname\": \"Project 1\",\n    \"projectdescrptionc1\": \"Project Decscrption1\",\n    \"projectdescrptionc2\": \"Project Decscrption1\",\n    \"dateTime\": \"11:26 03-05-2021\",\n    \"stageactivity\": \"StageActivity\",\n    \"pause\": \"Pause\",\n    \"reject\": \"Reject\",\n    \"finish\": \"Finish\"\n  }\n]\n";
           List<TabheadrightInfo> returnTabheadrightInfo = JsonConvert.DeserializeObject<List<TabheadrightInfo>>(innertaskjson);
       
            return returnTabheadrightInfo;
        }
    }
}

