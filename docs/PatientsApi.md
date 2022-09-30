# CNXT.Connector.Client.Api.PatientsApi

All URIs are relative to *http://localhost:8280/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePatient**](PatientsApi.md#createpatient) | **POST** /patients | Creates a patient.
[**DeletePatient**](PatientsApi.md#deletepatient) | **DELETE** /patients/{id} | Deletes a patient.
[**GetPatient**](PatientsApi.md#getpatient) | **GET** /patients/{id} | Retrieves a patient by ID.
[**GetPatients**](PatientsApi.md#getpatients) | **GET** /patients | Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending.
[**PatchPatient**](PatientsApi.md#patchpatient) | **PATCH** /patients/{id} | Patches a patient.
[**UpdatePatient**](PatientsApi.md#updatepatient) | **PUT** /patients/{id} | Updates a patient.


## CreatePatient

> PatientResponse CreatePatient (PatientInput patientInput)

Creates a patient.

### Example

```csharp
namespace Example
{
    public class CreatePatientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8280/api";
            var apiInstance = new PatientsApi(Configuration.Default);
            var patientInput = new PatientInput();
            patientInput.FirstName = "Max";
            patientInput.LastName = "Mustermann";
            patientInput.DateOfBirth(1970, 01, 01);

            try
            {
                PatientResponse result = apiInstance.CreatePatient(patientInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PatientsApi.CreatePatient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **patientInput** | **PatientInput** | PatientInput | 

### Return type

[**PatientResponse**](PatientResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created patient |  -  |
| **500** | Internal server error |  -  |


## DeletePatient

> String DeletePatient (string id)

Deletes a patient.

### Example

```csharp
namespace Example
{
    public class DeletePatientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8280/api";
            var apiInstance = new PatientsApi(Configuration.Default);
            var id = id_example;

            try
            {
                string result = apiInstance.DeletePatient(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PatientsApi.DeletePatient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String** | Id of the patient | 

### Return type

[**String**]

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the ID of the deleted patient |  -  |
| **404** | Patient not found |  -  |
| **500** | Internal server error |  -  |


## GetPatient

> PatientResponse GetPatient (string id, List include = null)

Retrieves a patient by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class GetPatientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8280/api";
            var apiInstance = new PatientsApi(Configuration.Default);
            var id = id_example;  // string | ID of the patient
            var include = new List<string>(); // List<string> | List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional) 

            try
            {
                // Retrieves a patient by ID.
                PatientResponse result = apiInstance.GetPatient(id, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PatientsApi.GetPatient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the patient | 
 **include** | [**List&lt;string&gt;**](string.md)| List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) | [optional] 

### Return type

[**PatientResponse**](PatientResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the patient according to the defined ID |  -  |
| **404** | Patient not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPatients

> PatientsResponse GetPatients (int first, string after = null, PatientFilter filter = null, List<string> sort = null, List<string> include = null)

Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class GetPatientsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8280/api";
            var apiInstance = new PatientsApi(Configuration.Default);
            var first = 25;  // int | Fetch only the first certain number of patients of the set. The default and maximum value is set to 25 patients per request.
            var after = after_example;  // string | Fetch only patients in the set after (below) this cursor (exclusive). (optional) 
            var filter = new PatientFilter(); // PatientFilter | Filter patients by parameters e.g. lastName for filtering patients by their last name.  (Supported values: firstName, lastName, search, dateOfBirth, createdAfter, updatedAfter) (optional) 
            var sort = new List<string>(); // List<string> | List of parameters to sort patients by parameters.  (Supported values: lastName, firstName, latestSessionUpdate, createdAt, updatedAt).    To sort descending add a '-' as prefix e.g (-lastName, -firstName, -latestSessionUpdate, -createdAt, -updatedAt). (optional) 
            var include = new List<string>(); // List<string> | List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) (optional) 

            try
            {
                // Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending.
                PatientsResponse result = apiInstance.GetPatients(first, after, filter, sort, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PatientsApi.GetPatients: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **first** | **int**| Fetch only the first certain number of patients of the set. The default and maximum value is set to 25 patients per request. | 
 **after** | **string**| Fetch only patients in the set after (below) this cursor (exclusive). | [optional] 
 **filter** | [**PatientFilter**](PatientFilter.md)| Filter patients by parameters e.g. lastName for filtering patients by their last name.  (Supported values: externalId, firstName, lastName, search, dateOfBirth, createdAfter, updatedAfter) | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| List of parameters to sort patients by parameters.  (Supported values: lastName, firstName, latestSessionUpdate, createdAt, updatedAt).    To sort descending add a &#39;-&#39; as prefix e.g (-lastName, -firstName, -latestSessionUpdate, -createdAt, -updatedAt). | [optional] 
 **include** | [**List&lt;string&gt;**](string.md)| List of related resources for including relationships or properties directly into patient such as Session, latestSessionId, or latestSessionUpdate   (Supported values: session, latestSessionId, latestSessionUpdate) | [optional] 

### Return type

[**PatientsResponse**](PatientsResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of patients according to the defined pagination, filter, and sort parameters. |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchPatient

> PatientResponse PatchPatient (string id, PatientInput patientInput)

Patches a patient.

### Example

```csharp
namespace Example
{
    public class PatchPatientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8280/api";
            var apiInstance = new PatientsApi(Configuration.Default);
            
            var patientInput = new PatientInput();
            patientInput.FirstName = "Maximilian";
            patientInput.DateOfBirth(1980, 01, 01);

            try
            {
                PatientResponse result = apiInstance.PatchPatient(id, patientInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PatientsApi.PatchPatient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String** | Id of the patient | 
 **patientInput** | **PatientInput** | PatientInput | 

### Return type

[**PatientResponse**](PatientResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the patient according to the defined ID |  -  |
| **404** | Patient not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePatient

> PatientResponse UpdatePatient (string id, PatientInput patientInput)

Updates a patient.

### Example

```csharp
namespace Example
{
    public class UpdatePatientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8280/api";
            var apiInstance = new PatientsApi(Configuration.Default);
            
            var patientInput = new PatientInput();
            patientInput.FirstName = "Maximilian";
            patientInput-LastName = "Mustermann";
            patientInput.DateOfBirth(1970, 01, 01);

            try
            {
                PatientResponse result = apiInstance.UpdatePatient(id, patientInput);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PatientsApi.UpdatePatient: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String** | Id of the patient | 
 **patientInput** | **PatientInput** | PatientInput | 

### Return type

[**PatientResponse**](PatientResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the patient according to the defined ID |  -  |
| **404** | Patient not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)
