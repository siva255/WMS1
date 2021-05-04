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
           string innertaskjson = "[\n  {\n    \"id\": 1,\n    \"ListName\" : \"Pending\",\n    \"checkboxId\": \"project1\",\n    \"checkboxname\": \"Project 1\",\n    \"projectdescrptionc1\": \"Project Decscrption1\",\n    \"projectdescrptionc2\": \"Project Decscrption1\",\n    \"dateTime\": \"11:26 29-04-2021\",\n    \"stageactivity\": \"StageActivity\"\n  },\n  {\n    \"id\": 1,\n    \"ListName\":  \"Yet To Start\",\n    \"checkboxId\": \"project1\",\n    \"checkboxname\": \"Project 1\",\n    \"projectdescrptionc1\": \"Project Decscrption1\",\n    \"projectdescrptionc2\": \"Project Decscrption1\",\n    \"dateTime\": \"11:26 29-04-2021\",\n    \"stageactivity\": \"StageActivity\"\n  }\n]\n\n";
           List<InnerTaskInfo> returnInnerInfoInfo = JsonConvert.DeserializeObject<List<InnerTaskInfo>>(innertaskjson);
       
            return returnInnerInfoInfo;
        }
    }
}

