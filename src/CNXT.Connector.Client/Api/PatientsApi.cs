/*
 * CNXT-Connector
 *
 * The CNXT-Connector is developed by Rodenstock GmbH to integrate data from measurement devices such as DNEye<sup>®</sup> Scanner, Rodenstock Fundus Scanner, and ImpressionIST<sup>®</sup> into 3rd party applications as well as into several applications of Rodenstock such as WinFit, Rodenstock Consulting etc. If you have any feedback then please feel free to contact us via email. Copyright © Rodenstock GmbH 2020
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: cnxt@rodenstock.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;
using System.Reflection;

namespace CNXT.Connector.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPatientsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves a patient by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CNXT.Connector.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the patient</param>
        /// <param name="include">List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional)</param>
        /// <returns>PatientResponse</returns>
        PatientResponse GetPatient (string id, List<string> include = default(List<string>));

        /// <summary>
        /// Retrieves a patient by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CNXT.Connector.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the patient</param>
        /// <param name="include">List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional)</param>
        /// <returns>ApiResponse of PatientResponse</returns>
        ApiResponse<PatientResponse> GetPatientWithHttpInfo (string id, List<string> include = default(List<string>));
        /// <summary>
        /// Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CNXT.Connector.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="first">Fetch only the first certain number of patients of the set. The default and maximum value is set to 25 patients per request.</param>
        /// <param name="after">Fetch only patients in the set after (below) this cursor (exclusive). (optional)</param>
        /// <param name="filter">Filter patients by parameters e.g. lastName for filtering patients by their last name.  (Supported values: firstName, lastName, search, dateOfBirth, createdAfter, updatedAfter) (optional)</param>
        /// <param name="sort">List of parameters to sort patients by parameters.  (Supported values: lastName, firstName, latestSessionUpdate, createdAt, updatedAt).    To sort descending add a &#39;-&#39; as prefix e.g (-lastName, -firstName, -latestSessionUpdate, -createdAt, -updatedAt). (optional)</param>
        /// <param name="include">List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional)</param>
        /// <returns>PatientsResponse</returns>
        PatientsResponse GetPatients (int first, string after = default(string), PatientFilter filter = default(PatientFilter), List<string> sort = default(List<string>), List<string> include = default(List<string>));

        /// <summary>
        /// Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CNXT.Connector.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="first">Fetch only the first certain number of patients of the set. The default and maximum value is set to 25 patients per request.</param>
        /// <param name="after">Fetch only patients in the set after (below) this cursor (exclusive). (optional)</param>
        /// <param name="filter">Filter patients by parameters e.g. lastName for filtering patients by their last name.  (Supported values: firstName, lastName, search, dateOfBirth, createdAfter, updatedAfter) (optional)</param>
        /// <param name="sort">List of parameters to sort patients by parameters.  (Supported values: lastName, firstName, latestSessionUpdate, createdAt, updatedAt).    To sort descending add a &#39;-&#39; as prefix e.g (-lastName, -firstName, -latestSessionUpdate, -createdAt, -updatedAt). (optional)</param>
        /// <param name="include">List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional)</param>
        /// <returns>ApiResponse of PatientsResponse</returns>
        ApiResponse<PatientsResponse> GetPatientsWithHttpInfo (int first, string after = default(string), PatientFilter filter = default(PatientFilter), List<string> sort = default(List<string>), List<string> include = default(List<string>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PatientsApi : IPatientsApi
    {
        private CNXT.Connector.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PatientsApi(String basePath)
        {
            this.Configuration = new CNXT.Connector.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = CNXT.Connector.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientsApi"/> class
        /// </summary>
        /// <returns></returns>
        public PatientsApi()
        {
            this.Configuration = CNXT.Connector.Client.Client.Configuration.Default;

            ExceptionFactory = CNXT.Connector.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PatientsApi(CNXT.Connector.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = CNXT.Connector.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CNXT.Connector.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CNXT.Connector.Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CNXT.Connector.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieves a patient by ID. 
        /// </summary>
        /// <exception cref="CNXT.Connector.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the patient</param>
        /// <param name="include">List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional)</param>
        /// <returns>PatientResponse</returns>
        public PatientResponse GetPatient (string id, List<string> include = default(List<string>))
        {
             ApiResponse<PatientResponse> localVarResponse = GetPatientWithHttpInfo(id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a patient by ID. 
        /// </summary>
        /// <exception cref="CNXT.Connector.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the patient</param>
        /// <param name="include">List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional)</param>
        /// <returns>ApiResponse of PatientResponse</returns>
        public ApiResponse<PatientResponse> GetPatientWithHttpInfo (string id, List<string> include = default(List<string>))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PatientsApi->GetPatient");

            var localVarPath = "/patients/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "include", include)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPatient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PatientResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PatientResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PatientResponse)));
        }

        /// <summary>
        /// Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending. 
        /// </summary>
        /// <exception cref="CNXT.Connector.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="first">Fetch only the first certain number of patients of the set. The default and maximum value is set to 25 patients per request.</param>
        /// <param name="after">Fetch only patients in the set after (below) this cursor (exclusive). (optional)</param>
        /// <param name="filter">Filter patients by parameters e.g. lastName for filtering patients by their last name.  (Supported values: firstName, lastName, search, dateOfBirth, createdAfter, updatedAfter) (optional)</param>
        /// <param name="sort">List of parameters to sort patients by parameters.  (Supported values: lastName, firstName, latestSessionUpdate, createdAt, updatedAt).    To sort descending add a &#39;-&#39; as prefix e.g (-lastName, -firstName, -latestSessionUpdate, -createdAt, -updatedAt). (optional)</param>
        /// <param name="include">List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional)</param>
        /// <returns>PatientsResponse</returns>
        public PatientsResponse GetPatients (int first, string after = default(string), PatientFilter filter = default(PatientFilter), List<string> sort = default(List<string>), List<string> include = default(List<string>))
        {
             ApiResponse<PatientsResponse> localVarResponse = GetPatientsWithHttpInfo(first, after, filter, sort, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending. 
        /// </summary>
        /// <exception cref="CNXT.Connector.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="first">Fetch only the first certain number of patients of the set. The default and maximum value is set to 25 patients per request.</param>
        /// <param name="after">Fetch only patients in the set after (below) this cursor (exclusive). (optional)</param>
        /// <param name="filter">Filter patients by parameters e.g. lastName for filtering patients by their last name.  (Supported values: firstName, lastName, search, dateOfBirth, createdAfter, updatedAfter) (optional)</param>
        /// <param name="sort">List of parameters to sort patients by parameters.  (Supported values: lastName, firstName, latestSessionUpdate, createdAt, updatedAt).    To sort descending add a &#39;-&#39; as prefix e.g (-lastName, -firstName, -latestSessionUpdate, -createdAt, -updatedAt). (optional)</param>
        /// <param name="include">List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional)</param>
        /// <returns>ApiResponse of PatientsResponse</returns>
        public ApiResponse<PatientsResponse> GetPatientsWithHttpInfo (int first, string after = default(string), PatientFilter filter = default(PatientFilter), List<string> sort = default(List<string>), List<string> include = default(List<string>))
        {
            // verify the required parameter 'first' is set
            if (first == null)
                throw new ApiException(400, "Missing required parameter 'first' when calling PatientsApi->GetPatients");

            var localVarPath = "/patients";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (first != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "first", first)); // query parameter
            if (after != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter

            // TODO: Bugfix for supporting deepObjects as query parameters
            //if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (filter != null)
            {
                foreach (PropertyInfo propertyInfo in filter.GetType().GetProperties().Where(property => property.GetValue(filter, null) != null))
                {
                    if (propertyInfo.PropertyType == typeof(DateTime) || propertyInfo.PropertyType == typeof(DateTime?))
                    {
                        DateTime? dateTimeValue = propertyInfo.GetValue(filter, null) as DateTime?;

                        if (dateTimeValue.HasValue)
                        {
                            localVarQueryParams.Add(new KeyValuePair<string, string>(string.Format("filter[{0}]", char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1)), dateTimeValue.Value.ToString("s")));
                        }
                    }
                    else
                    {
                        localVarQueryParams.Add(new KeyValuePair<string, string>(string.Format("filter[{0}]", char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1)), propertyInfo.GetValue(filter, null).ToString()));
                    }
                }
            }

            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "sort", sort)); // query parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "include", include)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPatients", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PatientsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PatientsResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PatientsResponse)));
        }
    }
}