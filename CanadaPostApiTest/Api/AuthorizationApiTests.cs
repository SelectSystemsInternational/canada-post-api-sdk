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

using NUnit.Framework;

using CanadaPostApi.Api;
using CanadaPostApi.Client;

namespace CanadaPostApi.Test
{
    /// <summary>
    ///  Class for testing AuthorizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuthorizationApiTests
    {
        private AuthorizationApi authorizationApi;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            string useragent = "Canada Post SDK; .NetStandard 2.1;";

            // Sandbox
            authorizationApi = new AuthorizationApi("https://ct.soa-gw.canadapost.ca", useragent);

            authorizationApi.Configuration.Username = "6e93d53968881714";
            authorizationApi.Configuration.Password = "0bfa9fcb9853d1f51ee57a";
            authorizationApi.Configuration.CustomerNumber = "2004381";
            authorizationApi.Configuration.Account = "2004381";

            var response = authorizationApi.AuthorizationCreateConfiguration();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthorizationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthorizationApi
            Assert.IsInstanceOf<AuthorizationApi>(authorizationApi, "instance is a AuthorizationApi");
        }
                
        /// <summary>
        /// Test RatesCreate
        /// </summary>
        [Test]
        public void AuthorizationCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value

            var response = authorizationApi.AuthorizationCreateConfiguration();

            Assert.IsInstanceOf<Configuration>(response, "response is Configuration");
        }
        
        /// <summary>
        /// Test RatesGet
        /// </summary>
        [Test]
        public void AuthorizationGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value

            string id = null;

            AuthorizationCreateTest();

            var response = authorizationApi.AuthorizationGetToken(id);

            Assert.IsInstanceOf<String>(response, "response is ApiKey");
        }


        /// <summary>
        /// Test get customer information
        /// </summary>
        [Test]
        public void GetCustomerInformation()
        {
            string responseAsString = String.Empty;

            var response = authorizationApi.AuthorizationCreateConfiguration();

            // Retrieve values from customer object
            var customer = authorizationApi.GetCustomerInformation(out string errors);
            if (customer != null)
            {
                // Retrieve values from customer object
                responseAsString += "Customer Number: " + customer.customernumber + "\r\n";
                responseAsString += "\r\nContract Ids:\r\n";

                if (customer.contracts != null)
                {
                    foreach (var contractId in customer.contracts)
                    {
                        responseAsString += "- " + contractId + "\r\n";
                    }
                }

                responseAsString += "\r\nPayers:\r\n";
                foreach (PayerType payer in customer.authorizedpayers)
                {
                    responseAsString += "- Customer Number: " + payer.payernumber + "\r\n";
                    var i = 0;
                    foreach (String methodOfPayment in payer.methodsofpayment)
                    {
                        if (i == 0)
                        {
                            responseAsString += "  Payment Method:\r\n";
                        }
                        i++;
                        responseAsString += "  - " + methodOfPayment + "\r\n";
                    }
                    responseAsString += "\r\n";
                }

                if (customer.links != null)
                {
                    foreach (LinkType link in customer.links)
                    {
                        responseAsString += link.rel + ": " + link.href + "\r\n";
                    }
                }
            }
            else
            {
                responseAsString += " Api Error: " + errors + "\r\n";
            }

            Assert.IsInstanceOf(typeof(string), responseAsString, "instance is a string");
        }

        /// <summary>
        /// Test get customer information
        /// </summary>
        [Test]
        public void GetServiceStatus()
        {
            string responseAsString = String.Empty;

            var response = authorizationApi.AuthorizationCreateConfiguration();

            // Retrieve values from object

            var infoMessages = authorizationApi.GetServiceInfo("shipment", out string errors);
            if (infoMessages != null)
            {
                if (infoMessages.infomessage != null)
                {
                    foreach (InfoMessageType infoMessage in infoMessages.infomessage)
                    {
                        responseAsString += " Message Type is :" + infoMessage.messagetype + "\r\n";
                        responseAsString += " Message Text is :" + infoMessage.messagetext + "\r\n";
                        responseAsString += " Message Start Time is :" + infoMessage.fromdatetime + "\r\n";
                        responseAsString += " Message End Time is :" + infoMessage.todatetime + "\r\n";
                    }
                }
                else
                {
                    responseAsString += " Shipment Service is operating" + "\r\n";
                }
            }
            else if (!string.IsNullOrWhiteSpace(errors))
            {
                responseAsString += " Api Error: " + errors + "\r\n";
            }

            infoMessages = authorizationApi.GetServiceInfo("customer", out errors);
            if (infoMessages != null)
            {
                if (infoMessages.infomessage != null)
                {
                    foreach (InfoMessageType infoMessage in infoMessages.infomessage)
                    {
                        responseAsString += " Message Type is :" + infoMessage.messagetype + "\r\n";
                        responseAsString += " Message Text is :" + infoMessage.messagetext + "\r\n";
                        responseAsString += " Message Start Time is :" + infoMessage.fromdatetime + "\r\n";
                        responseAsString += " Message End Time is :" + infoMessage.todatetime + "\r\n";
                    }
                }
                else
                {
                    responseAsString += " Customer Service is operating" + "\r\n";
                }
            }
            else if (!string.IsNullOrWhiteSpace(errors))
            {
                responseAsString += " Api Error: " + errors + "\r\n";
            }

            infoMessages = authorizationApi.GetServiceInfo("manifest", out errors);
            if (infoMessages != null)
            {
                if (infoMessages.infomessage != null)
                {
                    foreach (InfoMessageType infoMessage in infoMessages.infomessage)
                    {
                        responseAsString += " Message Type is :" + infoMessage.messagetype + "\r\n";
                        responseAsString += " Message Text is :" + infoMessage.messagetext + "\r\n";
                        responseAsString += " Message Start Time is :" + infoMessage.fromdatetime + "\r\n";
                        responseAsString += " Message End Time is :" + infoMessage.todatetime + "\r\n";
                    }
                }
                else
                {
                    responseAsString += " Manifest Service is operating" + "\r\n";
                }
            }
            else if (!string.IsNullOrWhiteSpace(errors))
            {
                responseAsString += " Api Error: " + errors + "\r\n";
            }

            infoMessages = authorizationApi.GetServiceInfo("barcode", out errors);
            if (infoMessages != null)
            {
                if (infoMessages.infomessage != null)
                {
                    foreach (InfoMessageType infoMessage in infoMessages.infomessage)
                    {
                        responseAsString += " Message Type is :" + infoMessage.messagetype + "\r\n";
                        responseAsString += " Message Text is :" + infoMessage.messagetext + "\r\n";
                        responseAsString += " Message Start Time is :" + infoMessage.fromdatetime + "\r\n";
                        responseAsString += " Message End Time is :" + infoMessage.todatetime + "\r\n";
                    }
                }
                else
                {
                    responseAsString += " Barcode Service is operating" + "\r\n";
                }
            }
            else if (!string.IsNullOrWhiteSpace(errors))
            {
                responseAsString += " Api Error: " + errors + "\r\n";
            }

            infoMessages = authorizationApi.GetServiceInfo("uamailing", out errors);
            if (infoMessages != null)
            {
                if (infoMessages.infomessage != null)
                {
                    foreach (InfoMessageType infoMessage in infoMessages.infomessage)
                    {
                        responseAsString += " Message Type is :" + infoMessage.messagetype + "\r\n";
                        responseAsString += " Message Text is :" + infoMessage.messagetext + "\r\n";
                        responseAsString += " Message Start Time is :" + infoMessage.fromdatetime + "\r\n";
                        responseAsString += " Message End Time is :" + infoMessage.todatetime + "\r\n";
                    }
                }
                else
                {
                    responseAsString += " Mailing Service is operating" + "\r\n";
                }
            }
            else if (!string.IsNullOrWhiteSpace(errors))
            {
                responseAsString += " Api Error: " + errors + "\r\n";
            }

            infoMessages = authorizationApi.GetServiceInfo("authreturn", out errors);
            if (infoMessages != null)
            {
                if (infoMessages.infomessage != null)
                {
                    foreach (InfoMessageType infoMessage in infoMessages.infomessage)
                    {
                        responseAsString += " Message Type is :" + infoMessage.messagetype + "\r\n";
                        responseAsString += " Message Text is :" + infoMessage.messagetext + "\r\n";
                        responseAsString += " Message Start Time is :" + infoMessage.fromdatetime + "\r\n";
                        responseAsString += " Message End Time is :" + infoMessage.todatetime + "\r\n";
                    }
                }
                else
                {
                    responseAsString += " AuthReturn Service is operating" + "\r\n";
                }
            }
            else if (!string.IsNullOrWhiteSpace(errors))
            {
                responseAsString += " Api Error: " + errors + "\r\n";
            }

            infoMessages = authorizationApi.GetServiceInfo("shiprate", out errors);
            if (infoMessages != null)
            {
                if (infoMessages.infomessage != null)
                {
                    foreach (InfoMessageType infoMessage in infoMessages.infomessage)
                    {
                        responseAsString += " Message Type is :" + infoMessage.messagetype + "\r\n";
                        responseAsString += " Message Text is :" + infoMessage.messagetext + "\r\n";
                        responseAsString += " Message Start Time is :" + infoMessage.fromdatetime + "\r\n";
                        responseAsString += " Message End Time is :" + infoMessage.todatetime + "\r\n";
                    }
                }
                else
                {
                    responseAsString += " Shipping Rate Service is operating" + "\r\n";
                }
            }
            else if (!string.IsNullOrWhiteSpace(errors))
            {
                responseAsString += " Api Error: " + errors + "\r\n";
            }

            infoMessages = authorizationApi.GetServiceInfo("outlet", out errors);
            if (infoMessages != null)
            {
                if (infoMessages.infomessage != null)
                {
                    foreach (InfoMessageType infoMessage in infoMessages.infomessage)
                    {
                        responseAsString += " Message Type is :" + infoMessage.messagetype + "\r\n";
                        responseAsString += " Message Text is :" + infoMessage.messagetext + "\r\n";
                        responseAsString += " Message Start Time is :" + infoMessage.fromdatetime + "\r\n";
                        responseAsString += " Message End Time is :" + infoMessage.todatetime + "\r\n";
                    }
                }
                else
                {
                    responseAsString += " Outlet Service is operating" + "\r\n";
                }
            }
            else if (!string.IsNullOrWhiteSpace(errors))
            {
                responseAsString += " Api Error: " + errors + "\r\n";
            }

            Assert.IsInstanceOf(typeof(string), responseAsString, "instance is a string");
        }
    }

}
