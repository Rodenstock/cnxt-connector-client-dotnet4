
# CNXT.Connector.Client.Model.SessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the session | 
**ExternalId** | **string** | External ID of the session, which is assigned to the session in a 3rd party application | [optional] 
**Name** | **string** | Name of the session | [optional] 
**Notes** | **string** | Notes of the session | [optional] 
**State** | **string** | State of the session. (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED) | [optional] 
**PatientId** | **string** | Patient ID associated with the session | [optional] 
**Patient** | [**Patient**](Patient.md) |  | [optional] 
**B2bOptic** | [**B2BOptic**](B2BOptic.md) |  | [optional] 
**CreatedAt** | **DateTime** | Date of creation of the session | [optional] 
**UpdatedAt** | **DateTime** | Date of modification of the session | [optional] 
**Links** | [**SessionLink**](SessionLink.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

