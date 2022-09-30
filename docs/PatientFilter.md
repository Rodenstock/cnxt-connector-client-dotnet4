
# CNXT.Connector.Client.Model.PatientFilter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalId** | **string** | Used for finding patients by external ID which is assigned to the patient in a 3rd party application
**Search** | **string** | Full text search parameter which is used for finding patients by first name or last name | [optional] 
**FirstName** | **string** | First name which is used for finding patients by first name | [optional] 
**LastName** | **string** | Last name which is used for finding patients by last name | [optional] 
**DateOfBirth** | **DateTime?** | Date of birth which is used for finding patients by date of birth | [optional] 
**SessionUpdatedAfter** | **DateTime?** | Used for finding patients whose sessions have been updated after the specified date time | [optional] 
**CreatedAfter** | **DateTime?** | Used for finding patients whose date of creation is after the specified date time | [optional] 
**UpdatedAfter** | **DateTime?** | Used for finding patients whose date of modification is after the specified date time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

