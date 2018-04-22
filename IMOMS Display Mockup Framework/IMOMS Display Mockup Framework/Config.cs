using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMOMS_Display_Mockup_Framework
{
    class Config
    {
        public const int OrderIdColumnIndex = 0;
        public const int ComponentIdColumnIndex = 1;
        public const int DisplayIdColumnIndex = 1;
        public const int MoveUpColumnIndex = 2;
        public const int MoveDownColumnIndex = 3;
        public const int RemoveColumnIndex = 4;

        public static string compFolder = ConfigurationManager.AppSettings["CompFolder"];
        public static string displayFolder = ConfigurationManager.AppSettings["DisplayFolder"];
        public static string dashboardFolder = ConfigurationManager.AppSettings["DashboardFolder"];
        public static string ribbonFolder = ConfigurationManager.AppSettings["RibbonFolder"];
        public static string displayConfigFolder = ConfigurationManager.AppSettings["DisplayConfigFilesFolder"];
        public static string dashboardConfigFolder = ConfigurationManager.AppSettings["DashboardConfigFilesFolder"];
    }
}
