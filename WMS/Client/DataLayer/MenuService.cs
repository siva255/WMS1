using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Client.DataLayer
{
    public class MenuService
    {
  
        public async Task<IEnumerable<MenuInfo>> GetMenuData()
        {
            string menujson = "[\r\n  {\r\n    \"menuId\": 1,\r\n    \"parentMenuId\": 0,\r\n    \"pageName\": \"mybin\",\r\n    \"menuName\": \"My Bin\",\r\n    \"iconName\": \"\"\r\n  },\r\n  {\r\n    \"menuId\": 3,\r\n    \"parentMenuId\": 1,\r\n    \"pageName\": \"dashbord\",\r\n    \"menuName\": \"Dashboard\",\r\n    \"iconName\": \"\"\r\n  },\r\n  {\r\n    \"menuId\": 4,\r\n    \"parentMenuId\": 1,\r\n    \"pageName\": \"mytask\",\r\n    \"menuName\": \"My Tasks\",\r\n    \"iconName\": \"\"\r\n  },\r\n  {\r\n    \"menuId\": 2,\r\n    \"parentMenuId\": 0,\r\n    \"pageName\": \"Report\",\r\n    \"menuName\": \"Reports\",\r\n    \"iconName\": \"\"\r\n  },\r\n\r\n  {\r\n    \"menuId\": 5,\r\n    \"parentMenuId\": 2,\r\n    \"pageName\": \"Report\",\r\n    \"menuName\": \"Report X\",\r\n    \"iconName\": \"\"\r\n  },\r\n  {\r\n    \"menuId\": 6,\r\n    \"parentMenuId\": 2,\r\n    \"pageName\": \"Report\",\r\n    \"menuName\": \"Report y\",\r\n    \"iconName\": \"\"\r\n  }\r\n\r\n]\r\n";
            //menujson = menujson + ",{\"menuId\": 2,  'parentMenuId': 0,  'pageName': '',  'menuName': 'Report',  'iconName': ''}";
            //menujson = menujson + ",{\"menuId\": 3,  'parentMenuId': 1,  'pageName': '',  'menuName': 'DashBord',  'iconName': ''}";
            //menujson = menujson + ",{\"menuId\": 4,  'parentMenuId': 1,  'pageName': '',  'menuName': 'MyTask',  'iconName': ''}";
            //menujson = menujson + ",{\"menuId\": 5,  'parentMenuId': 2,  'pageName': '',  'menuName': 'Report X',  'iconName': ''}";
            //menujson = menujson + ",{\"menuId\": 6,  'parentMenuId': 2,  'pageName': '',  'menuName': 'Report Y',  'iconName': ''}";
            // var menufile = System.IO.File.ReadAllText($"{System.IO.Directory.GetCurrentDirectory()}{@"\wwwroot\AppData\Menu.json"}");
           List<MenuInfo> menuInfos = JsonConvert.DeserializeObject<List<MenuInfo>>(menujson);
       
            return menuInfos;
        }
    }
}
