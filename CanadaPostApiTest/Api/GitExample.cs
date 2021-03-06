/* 
 * Canada Post Api
 *
 * Api SDK Initial build
 *
 * REST XML Spec version: 2022-05-30
 * 
 * Generated by: https://www.selectsystems.com.au/
 */

using System;
using System.Diagnostics;

using CanadaPostApi.Api;

namespace CanadaPostApi.Example
{
    /// <summary>
    ///  Class for testing Api

    public class ApiExample
    {
        AuthorizationApi authorizationApi;
        RatesApi RatesApi;
        //PaymentsApi paymentsApi;

        public void main()
        {
            // Configure API key authorization, get an Access Token

            try
            {
                string useragent = "Canada Post SDK; .NetStandard 2.1;";

                // Sandbox
                authorizationApi = new AuthorizationApi("https://ct.soa-gw.canadapost.ca", useragent);

                authorizationApi.Configuration.Username = "6e93d53968881714";
                authorizationApi.Configuration.Password = "0bfa9fcb9853d1f51ee57a";
                authorizationApi.Configuration.CustomerNumber = "2004381";
                authorizationApi.Configuration.Account = "2004381";

                var response = authorizationApi.AuthorizationCreateConfiguration();

                // Create Acces Token
                var authentication = authorizationApi.AuthorizationCreateConfiguration();

                RatesApi = new RatesApi(authorizationApi.Configuration);

                Debug.WriteLine(authentication);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi: " + e.Message);
            }
        }
    }
}

