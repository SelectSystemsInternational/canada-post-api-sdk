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
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using CanadaPostApi.Client;

namespace CanadaPostApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizationApi : IApiAccessor
    {

        /// <summary>
        /// Get customer information
        /// </summary>
        /// <param name="errors">Errors</param>
        /// <returns>Customer</returns>
        public customer GetCustomerInformation(out string errors);

        /// <summary>
        /// Get service information
        /// </summary>
        /// <param name="service">Service</param>
        /// <param name="errors">Errors</param>
        /// <returns>Customer</returns>
        public InfoMessagesType GetServiceInfo(string service, out string errors);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthorizationApi : IAuthorizationApi
    {

        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorizationApi(String basePath, String userAgent)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
            this.Configuration.UserAgent = userAgent;

            ExceptionFactory = CanadaPostApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthorizationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CanadaPostApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Creates an authorizarion configuration
        /// </summary>
        /// <returns>Configuration</returns>
        public Configuration AuthorizationCreateConfiguration()
        {
            var authorization = Convert.ToBase64String(Encoding.Default.GetBytes(this.Configuration.Username + ":" + this.Configuration.Password));

            Configuration.AccessToken = authorization;
            Configuration.BasePath = Configuration.ApiClient.Configuration.BasePath;

            Configuration.AddApiKey("Authorization", this.Configuration.AccessToken);
            Configuration.AddApiKeyPrefix("Authorization", "Basic");

            Configuration.AddApiKey("User-Agent", this.Configuration.UserAgent);
            Configuration.AddApiKeyPrefix("User-Agent", "User-Agent");

            Configuration.AddApiKey("Accept-Language", this.Configuration.AcceptLanguage);
            Configuration.AddApiKeyPrefix("Accept-Language", "en-CA");

            Configuration.ApiClient.Configuration = Configuration;

            return Configuration;
        }

        /// <summary>
        /// Retrieve a previously created authorization token.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>token</returns>
        public String AuthorizationGetToken(string id)
        {
            return Configuration.AccessToken;
        }

        /// <summary>
        /// Get customer information
        /// </summary>
        /// <param name="errors">Errors</param>
        /// <returns>Customer</returns>
        public customer GetCustomerInformation(out string errors)
        {
            var parameters = new StringBuilder();
            var xmlWriter = XmlWriter.Create(parameters);
            xmlWriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\"");
            var serializerRequest = new XmlSerializer(typeof(customer));

            var method = WebRequestMethods.Http.Get;
            var acceptType = "application/vnd.cpc.customer+xml";
            var url = $"{Configuration.ApiClient.Configuration.BasePath}/rs/customer/" + Configuration.ApiClient.Configuration.CustomerNumber;
            var response = Configuration.ApiClient.Request(parameters.ToString(), method, acceptType, null, url, out errors);
            if (response == null)
                return null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var serializerResponse = new XmlSerializer(typeof(customer));
                    return (customer)serializerResponse.Deserialize(streamReader);
                }
            }
            catch (ApiException e)
            {
                errors = e.Message;
                return null;
            }
        }

        /// <summary>
        /// Get service information
        /// </summary>
        /// <param name="service">Service</param>
        /// <param name="errors">Errors</param>
        /// <returns>Customer</returns>
        public InfoMessagesType GetServiceInfo(string service, out string errors)
        {
            var parameters = new StringBuilder();
            var xmlWriter = XmlWriter.Create(parameters);
            xmlWriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\"");
            var serializerRequest = new XmlSerializer(typeof(customer));

            var method = WebRequestMethods.Http.Get;
            var acceptType = "application/vnd.cpc.serviceinfo-v2+xml";
            var url = $"{Configuration.ApiClient.Configuration.BasePath}/rs/serviceinfo/" + service;
            var response = Configuration.ApiClient.Request(parameters.ToString(), method, acceptType, null, url, out errors);
            if (response == null)
                return null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var serializerResponse = new XmlSerializer(typeof(InfoMessagesType));
                    return (InfoMessagesType)serializerResponse.Deserialize(streamReader);
                }
            }
            catch (ApiException e)
            {
                errors = e.Message;
                return null;
            }
        }
    }
}
