# Digi QA Engineer Assessment


## Tech Stack
* Visual Studio IDE 2019
* .Net Core 3.1
* NUnit 3.1
* Selenium
* Docker
* Zalenium
* TeamCity 2020.1
* Google Cloud Platform

## Usage

This framework is designed to run remotely on docker Zalenium containers, this allows test to run on scalable environment. Currently there are 2 nodes, this number can be decreased or increased according to the needs on the test.

### Running Tests

Test can be ran in 2 ways from Visual Studio Test Explorer or by running a build on Teamcity. I recommend running it on Teamcity, this way you won't run into trouble installing dependencies.

#### Teamcity Build Run

username: guest

password: password!@#$

1. Goto [Teamcity](http://35.184.125.21:8111/viewType.html?buildTypeId=) and login in using username and password.
2. Click on "run" button to click off a run.


#### Visual Studio Run

1. Clone the code from the repo DigiQAEngineerAssessment
```bash
git clone https://github.com/NqabaMelapi/DigiQAEngineerAssessment.git
```
2. Open the solution with VS IDE 
3. Open terminal from VS IDE and restore packages
```bash
dotnet restore
```
3. build the project on terminal or VS IDE 
```bash
dotnet build
```
4. Open Test Explorer on VS IDE

### Monitoring Test Run

This framework uses Zalenium Live Preview to monitor running tests.
* Go to [Zalenium Live Preview](http://35.184.125.21:4444/grid/admin/live) to monitor test runs. Don't forget to refresh the page between runs.
* Test logs and video recoding can be found [Zalenium Dashboard](http://35.184.125.21:4444/dashboard/), latest test are on top of the list.

### Test Results
Test results can be found on Teamcity under Tests tab.


Note:
The following links may not work if you're accessing them connected to a VPN, you must disconect from your VPN.

* [Teamcity](http://35.184.125.21:8111/viewType.html?buildTypeId=Build_CIBDigitalTech)
* [Zalenium Live Preview](http://35.184.125.21:4444/grid/admin/live)
* [Zalenium Dashboard](http://35.184.125.21:4444/dashboard/)

