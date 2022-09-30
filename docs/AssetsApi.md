# CNXT.Connector.Client.Api.AssetsApi

All URIs are relative to *http://localhost:8280/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDNEyeScannerAssets**](AssetsApi.md#getdneyescannerassets) | **GET** /remote/dneye/{id}/assets | Retrieves available DNEye Scanner assets according to the defined asset ID.
[**GetImpressionISTAssets**](AssetsApi.md#getimpressionistassets) | **GET** /remote/impressionist/{id}/assets | Retrieves available ImpressionIST assets according to the defined asset ID.



## GetDNEyeScannerAssets

> DNEyeScannerAssetsResponse GetDNEyeScannerAssets (string id)

Retrieves available DNEye Scanner assets according to the defined asset ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class GetDNEyeScannerAssetsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8280/api";
            var apiInstance = new AssetsApi(Configuration.Default);
            var id = id_example;  // string | ID of the asset

            try
            {
                // Retrieves available DNEye Scanner assets according to the defined asset ID.
                DNEyeScannerAssetsResponse result = apiInstance.GetDNEyeScannerAssets(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AssetsApi.GetDNEyeScannerAssets: " + e.Message );
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
 **id** | **string**| ID of the asset | 

### Return type

[**DNEyeScannerAssetsResponse**](DNEyeScannerAssetsResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assigned assets according to the defined asset ID. |  -  |
| **404** | Asset not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetImpressionISTAssets

> ImpressionISTAssetsResponse GetImpressionISTAssets (string id)

Retrieves available ImpressionIST assets according to the defined asset ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;

namespace Example
{
    public class GetImpressionISTAssetsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8280/api";
            var apiInstance = new AssetsApi(Configuration.Default);
            var id = id_example;  // string | ID of the asset

            try
            {
                // Retrieves available ImpressionIST assets according to the defined asset ID.
                ImpressionISTAssetsResponse result = apiInstance.GetImpressionISTAssets(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AssetsApi.GetImpressionISTAssets: " + e.Message );
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
 **id** | **string**| ID of the asset | 

### Return type

[**ImpressionISTAssetsResponse**](ImpressionISTAssetsResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assigned assets according to the defined asset ID. |  -  |
| **404** | Asset not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

