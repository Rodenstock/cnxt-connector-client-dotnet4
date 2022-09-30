
# CNXT.Connector.Client.Model.SessionFilter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalId** | **string** | Used for finding sessions by external ID which is assigned to the session in a 3rd party application | [optional] 
**PatientId** | **string** | Used for finding sessions by patient ID | [optional] 
**CreatedAfter** | **DateTime?** | Used for finding sessions whose date of creation is after the specified date time | [optional] 
**UpdatedAfter** | **DateTime?** | Used for finding sessions whose date of modification is after the specified date time | [optional] 
**State** | **SessionState** | Used for finding sessions by state. (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED) | [optional] 
**HasDNEyeData** | **boolean** | Check whether the session contains DNEye data or not. | [optional] 
**HasImpressionISTData** | **boolean** | Check whether the session contains ImpressionIST data or not. | [optional] 
**HasRxData** | **boolean** | Check whether the session contains Rx data or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

