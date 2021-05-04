using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Client.DataLayer
{
    public class TaskdatatableService

    {
  
        public async Task<IEnumerable<TaskdatatableInfo>> GetdatatableInfos()
        {
           string datatablejson = "[\r\n  {\r\n    \"id\": 0,\r\n    \"slno\": 1,\r\n    \"chaptername\": \"Chapter Name\",\r\n    \"duedate\": \"Due date\",\r\n    \"status\": \"Status\",\r\n    \"actions\": \"Actions\"\r\n  },\r\n  {\r\n    \"id\": 1,\r\n    \"slno\": 2,\r\n    \"chaptername\": \"Chapter Name\",\r\n    \"duedate\": \"Due date\",\r\n    \"status\": \"Status\",\r\n    \"actions\": \"Actions\"\r\n  },\r\n  {\r\n    \"id\": 2,\r\n    \"slno\": 3,\r\n    \"chaptername\": \"Chapter Name\",\r\n    \"duedate\": \"Due date\",\r\n    \"status\": \"Status\",\r\n    \"actions\": \"Actions\"\r\n  },\r\n  {\r\n    \"id\": 3,\r\n    \"slno\": 4,\r\n    \"chaptername\": \"Chapter Name\",\r\n    \"duedate\": \"Due date\",\r\n    \"status\": \"Status\",\r\n    \"actions\": \"Actions\"\r\n  },\r\n  {\r\n    \"id\": 4,\r\n    \"slno\": 5,\r\n    \"chaptername\": \"Chapter Name\",\r\n    \"duedate\": \"Due date\",\r\n    \"status\": \"Status\",\r\n    \"actions\": \"Actions\"\r\n  },\r\n  {\r\n    \"id\": 5,\r\n    \"slno\": 6,\r\n    \"chaptername\": \"Chapter Name\",\r\n    \"duedate\": \"Due date\",\r\n    \"status\": \"Status\",\r\n    \"actions\": \"Actions\"\r\n  }\r\n]\r\n";
           List<TaskdatatableInfo> datatableinfo = JsonConvert.DeserializeObject<List<TaskdatatableInfo>>(datatablejson);
       
            return datatableinfo;
        }
    }
}

