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
    public interface IRatesApi : IApiAccessor
    {

        /// <summary>
        /// Get shipping rates for a mailing scenario
        /// </summary>
        /// <param name="mailingScenario">Input parameters</param>
        /// <param name="apiKey">The API key</param>
        /// <param name="errors">Errors</param>
        /// <returns>Shipping services</returns>
        public pricequotes GetRates(mailingscenario mailingScenario, out string errors);

        /// <summary>
        /// Get list of available services
        /// </summary>
        /// <param name="countryCode">Two-letter ISO code of destination country</param>
        /// <param name="apiKey">The API key</param>
        /// <param name="errors">Errors</param>
        /// <returns>List of services</returns>
        public services GetServices(string countryCode, out string errors);

        /// <summary>
        /// Get service details
        /// </summary>
        /// <param name="apiKey">The API key</param>
        /// <param name="url">URL endpoint</param>
        /// <param name="acceptType">Request accept type</param>
        /// <param name="errors">Errors</param>
        /// <returns>Service object</returns>
        public service GetServiceDetails(string url, string acceptType, out string errors);

        /// <summary>
        /// Get tracking details
        /// </summary>
        /// <param name="trackingNumber">Tracking number</param>
        /// <param name="apiKey">The API key</param>
        /// <param name="isSandbox">Is sandbox (testing environment) used</param>
        /// <param name="errors">Errors</param>
        /// <returns>Tracking details</returns>
        public trackingdetail GetTrackingDetails(string trackingNumber, bool isSandbox, out string errors);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RatesApi : IRatesApi
    {

        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RatesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CanadaPostApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RatesApi(Configuration configuration = null)
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
        /// Get shipping services for a shipment
        /// </summary>
        /// <param name="mailingScenario">Input parameters</param>
        /// <param name="errors">Errors</param>
        /// <returns>Shipping services</returns>
        public pricequotes GetRates(mailingscenario mailingScenario, out string errors)
        {
            var parameters = new StringBuilder();
            var xmlWriter = XmlWriter.Create(parameters);
            xmlWriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\"");
            var serializerRequest = new XmlSerializer(typeof(mailingscenario));
            serializerRequest.Serialize(xmlWriter, mailingScenario);

            var method = WebRequestMethods.Http.Post;
            var acceptType = "application/vnd.cpc.ship.rate-v4+xml";
            var url = $"{Configuration.ApiClient.Configuration.BasePath}/rs/ship/price";
            var response = Configuration.ApiClient.Request(parameters.ToString(), method, acceptType, null, url, out errors);
            if (response == null)
                return null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var serializerResponse = new XmlSerializer(typeof(pricequotes));
                    return (pricequotes)serializerResponse.Deserialize(streamReader);
                }
            }
            catch (ApiException e)
            {
                errors = e.Message;
                return null;
            }
        }

        /// <summary>
        /// Get list of available services
        /// </summary>
        /// <param name="countryCode">Two-letter ISO code of destination country</param>
        /// <param name="errors">Errors</param>
        /// <returns>List of services</returns>
        public services GetServices(string countryCode, out string errors)
        {
            var method = WebRequestMethods.Http.Get;
            var acceptType = "application/vnd.cpc.ship.rate-v4+xml";
            var url = $"{Configuration.ApiClient.Configuration.BasePath}/rs/ship/service";

            if (!string.IsNullOrEmpty(countryCode))
                url += $"?country={countryCode}";

            var response = Configuration.ApiClient.Request(null, method, acceptType, null, url, out errors);
            if (response == null)
                return null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var serializerResponse = new XmlSerializer(typeof(services));
                    return (services)serializerResponse.Deserialize(streamReader);
                }
            }
            catch (ApiException e)
            {
                errors = e.Message;
                return null;
            }
        }

        /// <summary>
        /// Get service details
        /// </summary>
        /// <param name="url">URL endpoint</param>
        /// <param name="acceptType">Request accept type</param>
        /// <param name="errors">Errors</param>
        /// <returns>Service object</returns>
        public service GetServiceDetails(string url, string acceptType, out string errors)
        {
            var method = WebRequestMethods.Http.Get;
            var response = Configuration.ApiClient.Request(null, method, acceptType, null, url, out errors);
            if (response == null)
                return null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var serializerResponse = new XmlSerializer(typeof(service));
                    return (service)serializerResponse.Deserialize(streamReader);
                }
            }
            catch (ApiException e)
            {
                errors = e.Message;
                return null;
            }
        }

        /// <summary>
        /// Get tracking details
        /// </summary>
        /// <param name="trackingNumber">Tracking number</param>
        /// <param name="isSandbox">Is sandbox (testing environment) used</param>
        /// <param name="errors">Errors</param>
        /// <returns>Tracking details</returns>
        public trackingdetail GetTrackingDetails(string trackingNumber, bool isSandbox, out string errors)
        {
            var method = WebRequestMethods.Http.Get;
            var acceptType = "application/vnd.cpc.track+xml";
            var url = $"{Configuration.ApiClient.Configuration.BasePath}/vis/track/pin/{trackingNumber}/detail";

            var response = Configuration.ApiClient.Request(null, method, acceptType, null, url, out errors);

            if (response == null)
                return null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var serializerResponse = new XmlSerializer(typeof(trackingdetail));
                    return (trackingdetail)serializerResponse.Deserialize(streamReader);
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