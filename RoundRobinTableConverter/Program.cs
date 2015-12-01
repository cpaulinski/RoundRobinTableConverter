using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
//using Microsoft.Practices.EnterpriseLibrary.Logging;

/**
    This tool is to retrieve the Round Robin Table from Google Sheets,
    convert the data into a more readable format on a different sheet,
    and perform calculations to sort winners based on tiebreakers
*/
namespace RoundRobinTableConverter
{
    class RoundRobinTableConverter
    {
        //private static LogWriter writer = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();

        static void Main(string[] args)
        {
            //TODO: add RESTful service to retrieve and post google sheets information
            //GoogleSheetsRestfulApi api = new GoogleSheetsRestfulApi();

            //TODO: add project to perform calculations to the data:
            //  1. Put Win-Loss in correct columns
            //  2. Add data for sorting tiebreakers
        }
    }
}
