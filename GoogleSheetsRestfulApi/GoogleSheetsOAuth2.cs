using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.GData.Client;
using Google.GData.Spreadsheets;


namespace GoogleSheetsRestfulApi
{
    interface GoogleSheetsOAuth2
    {
        //OAuth2Parameters getOAuth2Parameters();

        void authorizeWithGoogle();
    }
}
