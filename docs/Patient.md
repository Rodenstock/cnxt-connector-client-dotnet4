
# CNXT.Connector.Client.Model.Patient

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the patient | 
**Title** | **string** | Title of the patient | [optional] 
**FirstName** | **string** | First name of the patient | 
**LastName** | **string** | Last name of the patient | 
**Gender** | **string** | Gender of the patient (Supported values: Female, Male, Other, Unknown) | [optional] 
**DateOfBirth** | **DateTime?** | Date of birth of the patient | 
**LatestSessionId** | **string** | The id of the latest session | [optional] 
**LatestSessionUpdate** | **DateTime?** | Date of the latest session update | [optional] 
**Sessions** | [**List&lt;Session&gt;**](Session.md) | Assigned sessions of the patient | [optional] 
**CreatedAt** | **DateTime** | Date of creation of the patient | [optional] 
**UpdatedAt** | **DateTime** | Date of modification of the patient | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

