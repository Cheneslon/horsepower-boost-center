# Horsepower Boost Center
A website where you can find auto parts to increase your car's horsepower.

Created by CJ Olsen, Jake Marquez, Darren Geib, and Dallin Nelson.

## About
This website was made by Troop 9 of Coder Camps' [https://www.codercamps.com/net/](JavaScript + Full Stack .NET course)  in Seattle. It utilizes technologies including Angular 1, TypeScript, LINQ, NUnit, Moq, and more. It also makes use of the Edmund's Developer Network's [http://developer.edmunds.com/](Edmunds API) to search through all cars manufactured after 1990. We combine this data with our own locally-grown database to help users find auto parts that will increase their car's horsepower.   

## Setup
Clone project into any folder and open HorsePowerStore.sln in Visual Studio, then build the solution and run with or without debugging.

For full functionality, you'll need a user secrets JSON file that looks like this:
```
{
  "FacebookAppId": "SECRET",
  "FacebookSecret": "SECRET",
  "TwitterAppId": "SECRET",
  "TwitterSecret": "SECRET",
  "GoogleAppId": "SECRET",
  "GoogleSecret": "SECRET",
  "MicrosoftAppId": "SECRET",
  "MicrosoftSecret": "SECRET",
  "EdmundsApiKey": "SECRET"
}
```
(Replace all the "SECRET"s with actual IDs.) 

To modify user secrets in Visual Studio, right click on the HorsePowerStore project in the Solution Explorer and select "Manage User Secrets." 

## Testing
Horsepower Boost Center uses the NUnit testing framework. To run tests in Visual Studio, go to Test->Run->All Tests in the top menu bar.
