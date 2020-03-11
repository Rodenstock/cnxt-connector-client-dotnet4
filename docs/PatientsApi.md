# CNXT.Connector.Client.Api.PatientsApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPatient**](PatientsApi.md#getpatient) | **GET** /patients/{id} | Retrieves a patient by ID.
[**GetPatients**](PatientsApi.md#getpatients) | **GET** /patients | Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by field names such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending.



## GetPatient

> PatientResponse GetPatient (string id, List<string> include = null)

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
            Configuration.Default.BasePath = "http://localhost/api";
            var apiInstance = new PatientsApi(Configuration.Default);
            var id = id_example;  // string | ID of the patient
            var include = new List<string>(); // List<string> | List of related resources for including relationships directly into patient such as Session   (Supported values: session) (optional) 

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
 **include** | [**List&lt;string&gt;**](string.md)| List of related resources for including relationships directly into patient such as Session   (Supported values: session) | [optional] 

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

Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by field names such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending.

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
            Configuration.Default.BasePath = "http://localhost/api";
            var apiInstance = new PatientsApi(Configuration.Default);
            var first = 25;  // int | Fetch only the first certain number of patients of the set. The default and maximum value is set to 25 patients per request.
            var after = after_example;  // string | Fetch only patients in the set after (below) this cursor (exclusive). (optional) 
            var filter = new PatientFilter(); // PatientFilter | Filter patients by field name e.g. lastName for filtering patients by their last name.  (Supported values: firstName, lastName, search, dateOfBirth, createdAfter, updatedAfter) (optional) 
            var sort = new List<string>(); // List<string> | List of parameters to sort patients by field name.  (Supported values: lastName, firstName, latestSessionUpdate, createdAt, updatedAt).    To sort descending add a '-' as prefix e.g (-lastName, -firstName, -latestSessionUpdate, -createdAt, -updatedAt). (optional) 
            var include = new List<string>(); // List<string> | List of related resources for including relationships directly into patient such as Session   (Supported values: session) (optional) 

            try
            {
                // Retrieves a list of patients. The endpoint implements pagination by using links. Additionally, it is possible to filter by field names such as lastName, firstName, createdAfter, updatedAfter or to sort ascending or descending.
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
 **filter** | [**PatientFilter**](PatientFilter.md)| Filter patients by field name e.g. lastName for filtering patients by their last name.  (Supported values: firstName, lastName, search, dateOfBirth, createdAfter, updatedAfter) | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| List of parameters to sort patients by field name.  (Supported values: lastName, firstName, latestSessionUpdate, createdAt, updatedAt).    To sort descending add a &#39;-&#39; as prefix e.g (-lastName, -firstName, -latestSessionUpdate, -createdAt, -updatedAt). | [optional] 
 **include** | [**List&lt;string&gt;**](string.md)| List of related resources for including relationships directly into patient such as Session   (Supported values: session) | [optional] 

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

