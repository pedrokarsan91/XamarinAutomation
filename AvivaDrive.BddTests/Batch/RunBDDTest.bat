@echo off

call Config.bat

echo ::: Reading parameters..
SET TAGS=%1

pause

echo ::: House Keeping...
if Exist %MsTestResultFile% del %MsTestResultFile% 

pause

echo ::: Running BDD tests using MSTest runnner...

pause

if "%TAGS%" == "" (
    echo ::: No tags detected. Running all tests
	
	pause

	echo  ::: %MSTestExe% 

	pause

    %MSTestExe% /testcontainer:%ProjectHome%%SpecsDLL% /resultsfile:%MsTestResultFile% 

	pause

) ELSE (
    echo ::: Running tests with tags %TAGS%
    %MSTestExe% /testcontainer:%ProjectHome%%SpecsDLL% /category:"%TAGS%" /resultsfile:%MsTestResultFile% 
)

echo ::: Generating Test Result Output %HTMLTestOutput% ...
%SpecflowExecutable% mstestexecutionreport %BDDTestProject% /testResult:%MsTestResultFile% /out:%HTMLTestOutput%

echo ::: Opening HTML output
%HTMLTestOutput%