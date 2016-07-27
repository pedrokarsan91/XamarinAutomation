@echo off

COLOR 0a

:: PROJECT FILES
SET ProjectHome=..\..\..\..\
SET LivingDocFolder=%ProjectHome%\AvivaDrive.BddTests\bin\Debug\LivingDoc
SET FeatureFolder=%ProjectHome%\AvivaDrive.BddTests\Features
SET SpecsDLL=AvivaDrive.BddTests\bin\Debug\AvivaDrive.BddTests.dll
SET BDDTestProject="%ProjectHome%\AvivaDrive.BddTests\AvivaDrive.BddTests.csproj"

:: UTILITIES
SET PicklesExe=%ProjectHome%\packages\Pickles.CommandLine.2.6.3\tools\pickles.exe
SET MSTestExe="%ProgramFiles(x86)%\Microsoft Visual Studio 14.0\Common7\IDE\MSTest.exe"
SET SpecflowExecutable=%ProjectHome%\packages\SpecFlow.2.1.0\tools\specflow.exe

:: FILE NAMES
SET StepDefHTMLOutput=StepDefinitionReport.html
SET MsTestResultFile="TestResults.trx"
SET HTMLTestOutput="TestResults.html"

