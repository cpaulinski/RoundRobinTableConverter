using Google.GData.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GoogleSheetsRestfulApi
{
    class GoogleSheetsOauth2Impl : GoogleSheetsOAuth2
    {
        private OAuth2Parameters oAuth2Parameters { get; set; }

        private void setOAuth2ParametersWithConfigSettings()
        {
            oAuth2Parameters = new OAuth2Parameters();
            oAuth2Parameters.ClientId = ConfigurationManager.AppSettings["GoogleClientID"];
            oAuth2Parameters.ClientSecret = ConfigurationManager.AppSettings["GoogleClientSecret"];
            oAuth2Parameters.Scope = ConfigurationManager.AppSettings["GoogleScope"];
        }

        private void setAuthorizationUrl()
        {
            string authorizationUrl = OAuthUtil.CreateOAuth2AuthorizationUrl(oAuth2Parameters);
            Console.WriteLine(authorizationUrl);
            Console.WriteLine("Please visit the URL above to authorize your OAuth "
              + "request token.  Once that is complete, type in your access code to "
              + "continue...");
            oAuth2Parameters.AccessCode = Console.ReadLine();
        }

        private void setAuthorizationToken()
        {
            OAuthUtil.GetAccessToken(oAuth2Parameters);
            string accessToken = oAuth2Parameters.AccessToken;
            Console.WriteLine("OAuth Access Token: " + accessToken);
        }

        public void authorizeWithGoogle()
        {
            setOAuth2ParametersWithConfigSettings();
            setAuthorizationUrl();
            setAuthorizationToken();
        }
    }
}
