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
    public interface INonContractShippingApi : IApiAccessor
    {

        /// <summary>
        /// Create a non contract shipment
        /// </summary>
        /// <param name="shipment">shipment</param>
        /// <param name="errors">Errors</param>
        /// <returns>ShipmentInfoType</returns>
        public NonContractShipmentInfoType CreateNonContractShipment(NonContractShipmentType shipment, out string errors);

        /// <summary>
        /// Get all shipments
        /// </summary>
        /// <param name="from">from date string</param>
        /// <param name="to">to date string</param> 
        /// <param name="errors">Errors</param>
        /// <returns>ShipmentDetailsType</returns>
        public NonContractShipmentsType GetNonContractShipments(string from, string to, out string errors);

        /// <summary>
        /// Get non contract shipment details
        /// </summary>
        /// <param name="shipmentId">shipment identifier</param>
        /// <param name="errors">Errors</param>
        /// <returns>ShipmentDetailsType</returns>
        public NonContractShipmentDetailsType GetNonContractShipmentDetails(string shipmentId, out string errors);

        /// <summary>
        /// Get shipment details information
        /// </summary>
        /// <param name="errors">Errors</param>
        /// <returns>Customer</returns>
        public T GetShipmentDetailsInformation<T>(string shipmentId, string type, out string errors);

        /// <summary>
        /// Request shipment refund
        /// </summary>
        /// <param name="shipmentId">shipment identifier</param>
        /// <param name="request">NonContractShipmentRefundRequestType</param>
        /// <param name="errors">Errors</param>
        /// <returns>ShipmentDetailsType</returns>
        public NonContractShipmentRefundRequestInfoType RequestNonContractShipmentRefund(string shipmentId, NonContractShipmentRefundRequestType request, out string errors);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NonContractShippingApi : INonContractShippingApi
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
        public NonContractShippingApi(String basePath)
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
        public NonContractShippingApi(Configuration configuration = null)
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
        /// Create a non contract shipment
        /// </summary>
        /// <param name="shipment">shipment</param>
        /// <param name="errors">Errors</param>
        /// <returns>ShipmentInfoType</returns>
        public NonContractShipmentInfoType CreateNonContractShipment(NonContractShipmentType shipment, out string errors)
        {
            var parameters = new StringBuilder();
            var xmlWriter = XmlWriter.Create(parameters);
            xmlWriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\"");
            var serializerRequest = new XmlSerializer(typeof(NonContractShipmentType));
            serializerRequest.Serialize(xmlWriter, shipment);

            var method = WebRequestMethods.Http.Post;
            var acceptType = "application/vnd.cpc.ncshipment-v4+xml";
            var contentType = "application/vnd.cpc.ncshipment-v4+xml";
            var url = $"{Configuration.ApiClient.Configuration.BasePath}/rs/" + Configuration.ApiClient.Configuration.CustomerNumber + "/ncshipment";
            var response = Configuration.ApiClient.Request(parameters.ToString(), method, acceptType, contentType, url, out errors);
            if (response == null)
                return null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var serializerResponse = new XmlSerializer(typeof(NonContractShipmentInfoType));
                    return (NonContractShipmentInfoType)serializerResponse.Deserialize(streamReader);
                }
            }
            catch (ApiException e)
            {
                errors = e.Message;
                return null;
            }
        }

        /// <summary>
        /// Get all shipments
        /// </summary>
        /// <param name="from">from date string</param>
        /// <param name="from">to date string</param> 
        /// <param name="errors">Errors</param>
        /// <returns>ShipmentDetailsType</returns>
        public NonContractShipmentsType GetNonContractShipments(string from, string to, out string errors)
        {

            if (!string.IsNullOrEmpty(from) && !string.IsNullOrEmpty(to))
            {
                var parameters = new StringBuilder();
                var xmlWriter = XmlWriter.Create(parameters);
                xmlWriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\"");
                var serializerRequest = new XmlSerializer(typeof(customer));

                var method = WebRequestMethods.Http.Get;
                var acceptType = "application/vnd.cpc.ncshipment-v4+xml";
                var url = $"{Configuration.ApiClient.Configuration.BasePath}/rs/" + Configuration.ApiClient.Configuration.CustomerNumber +
                    "/ncshipment/?from=" + from + "to=" + to;
                var response = Configuration.ApiClient.Request(parameters.ToString(), method, acceptType, null, url, out errors);
                if (response == null)
                    return null;

                try
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var serializerResponse = new XmlSerializer(typeof(NonContractShipmentsType));
                        return (NonContractShipmentsType)serializerResponse.Deserialize(streamReader);
                    }
                }
                catch (ApiException e)
                {
                    errors = e.Message;
                    return null;
                }
            }
            else
            {
                errors = "From and To parameters are required";
                return null;
            }

        }

        /// <summary>
        /// Get shipping details
        /// </summary>
        /// <param name="shipmentId">shipment identifier</param>
        /// <param name="errors">Errors</param>
        /// <returns>ShipmentDetailsType</returns>
        public NonContractShipmentDetailsType GetNonContractShipmentDetails(string shipmentId, out string errors)
        {
            var parameters = new StringBuilder();
            var xmlWriter = XmlWriter.Create(parameters);
            xmlWriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\"");
            var serializerRequest = new XmlSerializer(typeof(customer));

            var method = WebRequestMethods.Http.Get;
            var acceptType = "application/vnd.cpc.ncshipment-v4+xml";
            var url = $"{Configuration.ApiClient.Configuration.BasePath}/rs/" + Configuration.ApiClient.Configuration.CustomerNumber +
                "/ncshipment/" + shipmentId + "/details";
            var response = Configuration.ApiClient.Request(parameters.ToString(), method, acceptType, null, url, out errors);
            if (response == null)
                return null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var serializerResponse = new XmlSerializer(typeof(NonContractShipmentDetailsType));
                    return (NonContractShipmentDetailsType)serializerResponse.Deserialize(streamReader);
                }
            }
            catch (ApiException e)
            {
                errors = e.Message;
                return null;
            }
        }

        /// <summary>
        /// Get customer information
        /// </summary>
        /// <param name="errors">Errors</param>
        /// <returns>Customer</returns>
        public T GetShipmentDetailsInformation<T>(string shipmentId, string type, out string errors)
        {
            var parameters = new StringBuilder();
            var xmlWriter = XmlWriter.Create(parameters);
            xmlWriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\"");
            var serializerRequest = new XmlSerializer(typeof(customer));

            var method = WebRequestMethods.Http.Get;
            var acceptType = "application/vnd.cpc.shipment-v8+xml";
            var url = $"{Configuration.ApiClient.Configuration.BasePath}/rs/" + Configuration.ApiClient.Configuration.CustomerNumber +
                "/" + Configuration.ApiClient.Configuration.Account + "/shipment/" + shipmentId + "/" + type;
            var response = Configuration.ApiClient.Request(parameters.ToString(), method, acceptType, null, url, out errors);
            if (response == null)
                return default(T);

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    switch (type)
                    {
                        case "price": 
                            var serializerResponse = new XmlSerializer(typeof(ShipmentPriceType));
                            return (T)serializerResponse.Deserialize(streamReader);

                        case "receipt":
                            serializerResponse = new XmlSerializer(typeof(ShipmentReceiptType));
                            return (T)serializerResponse.Deserialize(streamReader);

                        default:
                            return default(T);
                
                    }
                }
            }
            catch (ApiException e)
            {
                errors = e.Message;
                return default(T);
            }
        }

        /// <summary>
        /// Get customer information
        /// </summary>
        /// <param name="errors">Errors</param>
        /// <returns>Customer</returns>
        public HttpWebResponse GetShipmentAftifact(string url, out string errors)
        {
            var method = WebRequestMethods.Http.Get;
            var acceptType = "application/pdf,application/zpl";
            var response = Configuration.ApiClient.Request(null, method, acceptType, null, url, out errors);
            if (response != null)
                return response;

            return null;
        }

        /// <summary>
        /// Request shipment refund
        /// </summary>
        /// <param name="shipmentId">shipment identifier</param>
        /// <param name="request">NonContractShipmentRefundRequestType</param>
        /// <param name="errors">Errors</param>
        /// <returns>NonContractShipmentRefundRequestInfoType</returns>
        public NonContractShipmentRefundRequestInfoType RequestNonContractShipmentRefund(string shipmentId, NonContractShipmentRefundRequestType request, out string errors)
        {
            var parameters = new StringBuilder();
            var xmlWriter = XmlWriter.Create(parameters);
            xmlWriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\"");
            var serializerRequest = new XmlSerializer(typeof(NonContractShipmentRefundRequestType));
            serializerRequest.Serialize(xmlWriter, request);

            var method = WebRequestMethods.Http.Post;
            var acceptType = "application/vnd.cpc.ncshipment-v4+xml";
            var contentType = "application/vnd.cpc.ncshipment-v4+xml";
            var url = $"{Configuration.ApiClient.Configuration.BasePath}/rs/" + Configuration.ApiClient.Configuration.CustomerNumber +
                "/ncshipment/" + shipmentId + "/refund";
            var response = Configuration.ApiClient.Request(parameters.ToString(), method, acceptType, contentType, url, out errors);
            if (response == null)
                return null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var serializerResponse = new XmlSerializer(typeof(NonContractShipmentRefundRequestInfoType));
                    return (NonContractShipmentRefundRequestInfoType)serializerResponse.Deserialize(streamReader);
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