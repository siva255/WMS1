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
            string menujson = "[\n  {\n    \"menuId\": 1,\n    \"parentMenuId\": 0,\n    \"pageName\": \"mybin\",\n    \"menuName\": \"My Bin\",\n    \"iconName\": \"\"\n  },\n  {\n    \"menuId\": 3,\n    \"parentMenuId\": 1,\n    \"pageName\": \"dashboard\",\n    \"menuName\": \"Dashboard\",\n    \"iconName\": \"\"\n  },\n  {\n    \"menuId\": 4,\n    \"parentMenuId\": 1,\n    \"pageName\": \"mytask\",\n    \"menuName\": \"My Tasks\",\n    \"iconName\": \"\"\n  },\n  {\n    \"menuId\": 2,\n    \"parentMenuId\": 0,\n    \"pageName\": \"Report\",\n    \"menuName\": \"Reports\",\n    \"iconName\": \"\"\n  },\n\n  {\n    \"menuId\": 5,\n    \"parentMenuId\": 2,\n    \"pageName\": \"mytask\",\n    \"menuName\": \"Report X\",\n    \"iconName\": \"\"\n  },\n  {\n    \"menuId\": 6,\n    \"parentMenuId\": 2,\n    \"pageName\": \"mytask\",\n    \"menuName\": \"Report y\",\n    \"iconName\": \"\"\n  }\n\n]\n";
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
