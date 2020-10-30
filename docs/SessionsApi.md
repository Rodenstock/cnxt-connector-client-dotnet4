# CNXT.Connector.Client.Api.SessionsApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAssets**](SessionsApi.md#getassets) | **GET** /remote/sessions/{id}/assets | Retrieves available assets (images taken by ImpressionIST® , DNEye®  Scanner, Rodenstock Fundus Scanner etc.) according to the defined session ID.
[**GetB2bOptic**](SessionsApi.md#getb2boptic) | **GET** /sessions/{id}/b2boptic | Retrieves a session by ID represented as B2BOptic XML document.
[**GetSession**](SessionsApi.md#getsession) | **GET** /sessions/{id} | Retrieves a session by ID.
[**GetSessions**](SessionsApi.md#getsessions) | **GET** /sessions | Retrieves a list of sessions. This endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as patientId, externalId, createdAfter, updatedAfter or to sort ascending or descending.
[**ImportB2BOptic**](SessionsApi.md#importb2boptic) | **PUT** /sessions/{id} | Imports a B2BOptic XML document defined by the session ID. This B2BOptic XML document is assigned to an existing session via the defined session ID or assigned to this patient as a new session via the specified id of the session and specified first name, last name, or date of birth of the patient.
[**ImportB2BOpticAsNewSession**](SessionsApi.md#importb2bopticasnewsession) | **POST** /sessions | Imports a B2BOptic XML document as a new session, which is assigned to an existing patient via Patient id. If the patient does not exist with the given patient id, a new patient is created and the new session is associated accordingly.



## GetAssets

> AssetsResponse GetAssets (string id)

Retrieves available assets (images taken by ImpressionIST® , DNEye®  Scanner, Rodenstock Fundus Scanner etc.) according to the defined session ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class GetAssetsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            var apiInstance = new SessionsApi(Configuration.Default);
            var id = id_example;  // string | ID of the session

            try
            {
                // Retrieves available assets (images taken by ImpressionIST® , DNEye®  Scanner, Rodenstock Fundus Scanner etc.) according to the defined session ID.
                AssetsResponse result = apiInstance.GetAssets(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionsApi.GetAssets: " + e.Message );
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
 **id** | **string**| ID of the session | 

### Return type

[**AssetsResponse**](AssetsResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assigned assets according to the defined session ID. |  -  |
| **404** | Session not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetB2bOptic

> string GetB2bOptic (string id)

Retrieves a session by ID represented as B2BOptic XML document.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class GetB2bOpticExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            var apiInstance = new SessionsApi(Configuration.Default);
            var id = id_example;  // string | ID of the session

            try
            {
                // Retrieves a session by ID represented as B2BOptic XML document.
                string result = apiInstance.GetB2bOptic(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionsApi.GetB2bOptic: " + e.Message );
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
 **id** | **string**| ID of the session | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assigned B2BOptic XML document according to the defined session ID. |  -  |
| **404** | Session not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSession

> SessionResponse GetSession (string id, List<string> include = null)

Retrieves a session by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class GetSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            var apiInstance = new SessionsApi(Configuration.Default);
            var id = id_example;  // string | ID of the session
            var include = new List<string>(); // List<string> | List of related resources for including relationships directly into session such as B2BOptic or Patient.  (Supported values: b2boptic, patient) (optional) 

            try
            {
                // Retrieves a session by ID.
                SessionResponse result = apiInstance.GetSession(id, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionsApi.GetSession: " + e.Message );
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
 **id** | **string**| ID of the session | 
 **include** | [**List&lt;string&gt;**](string.md)| List of related resources for including relationships directly into session such as B2BOptic or Patient.  (Supported values: b2boptic, patient) | [optional] 

### Return type

[**SessionResponse**](SessionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the session according to the defined ID. |  -  |
| **302** | Redirect to current location of the session |  -  |
| **404** | Session not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSessions

> SessionsResponse GetSessions (int first, string after = null, SessionFilter filter = null, List<string> sort = null, List<string> include = null)

Retrieves a list of sessions. This endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as patientId, externalId, createdAfter, updatedAfter or to sort ascending or descending.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class GetSessionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            var apiInstance = new SessionsApi(Configuration.Default);
            var first = 25;  // int | Read the first n sessions of the set. The default and maximum value is set to 25 sessions per request.
            var after = after_example;  // string | Read all sessions in the set after (below) this cursor. (optional) 
            var filter = new SessionFilter(); // SessionFilter | Filter session by parameters e.g. patientId, externalId, state, createdAfter, or updatedAfter. CreatedAfter is used for filtering sessions which are created after a specified date. UpdatedAfter is used for filtering sessions which are updated after a specified date.  (Supported values: patientId, externalId, createdAfter, updatedAfter, state).    A state has the following supported values: (OPEN, CLOSED, ORDERED, EXPORTED, SAVED) (optional) 
            var sort = new List<string>(); // List<string> | List of parameters to sort sessions by parameter.  (Supported values: createdAt, updatedAt).    To sort descending add a '-' as prefix e.g. (-createdAt, -updatedAt). (optional) 
            var include = new List<string>(); // List<string> | List of related resources for including relationships directly into session such as Patient.  (Supported values: patient) (optional) 

            try
            {
                // Retrieves a list of sessions. This endpoint implements pagination by using links. Additionally, it is possible to filter by parameters such as patientId, externalId, createdAfter, updatedAfter or to sort ascending or descending.
                SessionsResponse result = apiInstance.GetSessions(first, after, filter, sort, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionsApi.GetSessions: " + e.Message );
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
 **first** | **int**| Read the first n sessions of the set. The default and maximum value is set to 25 sessions per request. | 
 **after** | **string**| Read all sessions in the set after (below) this cursor. | [optional] 
 **filter** | [**SessionFilter**](SessionFilter.md)| Filter session by parameters e.g. patientId, externalId, state, createdAfter, or updatedAfter. CreatedAfter is used for filtering sessions which are created after a specified date. UpdatedAfter is used for filtering sessions which are updated after a specified date.  (Supported values: patientId, externalId, createdAfter, updatedAfter, state).    A state has the following supported values: (OPEN, CLOSED, ORDERED, EXPORTED, SAVED) | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| List of parameters to sort sessions by parameter.  (Supported values: createdAt, updatedAt).    To sort descending add a &#39;-&#39; as prefix e.g. (-createdAt, -updatedAt). | [optional] 
 **include** | [**List&lt;string&gt;**](string.md)| List of related resources for including relationships directly into session such as Patient.  (Supported values: patient) | [optional] 

### Return type

[**SessionsResponse**](SessionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of sessions according to the defined pagination, filter, and sort parameters. |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportB2BOptic

> List&lt;string&gt; ImportB2BOptic (string id, string body, string state = null)

Imports a B2BOptic XML document defined by the session ID. This B2BOptic XML document is assigned to an existing session via the defined session ID or assigned to this patient as a new session via the specified id of the session and specified first name, last name, or date of birth of the patient.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class ImportB2BOpticExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            var apiInstance = new SessionsApi(Configuration.Default);
            var id = id_example;  // string | ID of the session that needs to import data from B2BOptic XML document.
            var body = body_example;  // string | 
            var state = state_example;  // string | State of the session that needs to import data from B2BOptic XML document.  (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED) (optional) 

            try
            {
                // Imports a B2BOptic XML document defined by the session ID. This B2BOptic XML document is assigned to an existing session via the defined session ID or assigned to this patient as a new session via the specified id of the session and specified first name, last name, or date of birth of the patient.
                List<string> result = apiInstance.ImportB2BOptic(id, body, state);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionsApi.ImportB2BOptic: " + e.Message );
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
 **id** | **string**| ID of the session that needs to import data from B2BOptic XML document. | 
 **body** | **string**|  | 
 **state** | **string**| State of the session that needs to import data from B2BOptic XML document.  (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED) | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/xml
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The session has been successfully created or updated. Additionally, the assigned session IDs are returned as array of UUIDs. |  -  |
| **403** | Forbidden |  -  |
| **404** | Session not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportB2BOpticAsNewSession

> List&lt;string&gt; ImportB2BOpticAsNewSession (string body, string state = null)

Imports a B2BOptic XML document as a new session, which is assigned to an existing patient via Patient id. If the patient does not exist with the given patient id, a new patient is created and the new session is associated accordingly.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class ImportB2BOpticAsNewSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            var apiInstance = new SessionsApi(Configuration.Default);
            var body = body_example;  // string | 
            var state = state_example;  // string | State of the session that needs to import data from B2BOptic XML document.  (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED) (optional) 

            try
            {
                // Imports a B2BOptic XML document as a new session, which is assigned to an existing patient via Patient id. If the patient does not exist with the given patient id, a new patient is created and the new session is associated accordingly.
                List<string> result = apiInstance.ImportB2BOpticAsNewSession(body, state);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionsApi.ImportB2BOpticAsNewSession: " + e.Message );
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
 **body** | **string**|  | 
 **state** | **string**| State of the session that needs to import data from B2BOptic XML document.  (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED) | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/xml
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The session has been successfully created/imported. Additionally, the assigned session IDs are returned as array of UUIDs. |  -  |
| **403** | Forbidden. |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

