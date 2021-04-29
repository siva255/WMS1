using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Client.DataLayer
{
    public class InnerTaskService

    {
  
        public async Task<IEnumerable<InnerTaskInfo>> GetInnerTaskInfos()
        {
           string innertaskjson = "[\r\n  {\r\n    \"id\": 1,\r\n    \"ListName\" : \"Pending\",\r\n    \"checkboxId\": \"project1\",\r\n    \"checkboxname\": \"Project 1\",\r\n    \"projectdescrptionc1\": \"Project Decscrption1\",\r\n    \"projectdescrptionc2\": \"Project Decscrption1\",\r\n    \"dateTime\": \"11:26 29-04-2021\",\r\n    \"stageactivity\": \"StageActivity\"\r\n  },\r\n  {\r\n    \"id\": 1,\r\n    \"ListName\":  \"Yet To Start\",\r\n    \"checkboxId\": \"project1\",\r\n    \"checkboxname\": \"Project 1\",\r\n    \"projectdescrptionc1\": \"Project Decscrption1\",\r\n    \"projectdescrptionc2\": \"Project Decscrption1\",\r\n    \"dateTime\": \"11:26 29-04-2021\",\r\n    \"stageactivity\": \"StageActivity\"\r\n  }\r\n]\r\n\r\n";
           List<InnerTaskInfo> returnInnerInfoInfo = JsonConvert.DeserializeObject<List<InnerTaskInfo>>(innertaskjson);
       
            return returnInnerInfoInfo;
        }
    }
}

