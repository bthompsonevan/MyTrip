# **Valdiation Performed on Project**

## **User Model Validation**				

Property | Validation
---------|-----------
UserName | Required / String Length 
PassWord | Required
FirstName | Required / String Length
LastName | Required / String Length
Email | Required / EmailAddress
Bio | Required / StringLength

- Valdiation in Views
	- UserLoginInScreen
	- CreateUser

## **Trip model Validation**

Property | Validation
---------|-----------
TripName | Required / StringLength
TripStartDate | Required / DateType / DisplayFormat
TripEndDate | Required / DateType / DisplayFormat
TripDesitination | Required / StringLength

- Validation in Views
	- AddTrip


## **Controller Validation**

Action Method | Validation
--------------|-----------
CreateUser | Validation on Model state
AddTrip | Validation on Model State
AddTrip | Validation on TripStartdate compared to TripEndDate

	

   
        