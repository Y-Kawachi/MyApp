rem MSTest���s�p�X
set MSTEST_BIN=C:\Program Files (x86)\Common7\IDE\MSTest.exe

rem OpenCover
set OPENCOVER_HOME=C:\Users\y\Documents\visual studio 2013\Projects\MyApp\packages\OpenCover.4.5.3723
set OPENCOVER_BIN=%OPENCOVER_HOME%\OpenCover.Console.exe

rem �e�X�g�̃A�Z���u��
set SOLUTION_DIR=C:\Users\y\Documents\Visual Studio 2013\Projects\MyApp
set ESCAPED_SOLUTION_DIR=C:\Users\y\Documents\Visual~1\Projects\MyApp
set PROJECT_DIR=%SOLUTION_DIR%\MyApp.Tests
set OUTPUT_TEST_DIR=%PROJECT_DIR%\bin\TestResults
set OUTPUT_REPORT_DIR=%PROJECT_DIR%\bin\Report
set TARGET_DIR=%PROJECT_DIR%\bin\Debug
set TARGET_TEST=MyApp.Tests.dll
set TEST_SETTINGS=%ESCAPED_SOLUTION_DIR%\MyApp.testsettings


rem ���|�[�g�����c�[��
set REPORTGEN_HOME=C:\Users\y\Documents\visual studio 2013\Projects\MyApp\packages\ReportGenerator.2.1.4.0
set REPORTGEN_BIN=%REPORTGEN_HOME%\ReportGenerator.exe

rem �J�o���b�W�v���Ώۂ̎w��
set FILTERS=+[MyApp]*

rem OpenCover�̎��s
"%OPENCOVER_BIN%" -register:user -target:"%MSTEST_BIN%" -targetargs:"/testsettings:%TEST_SETTINGS% /testcontainer:%TARGET_TEST%"  -targetdir:"%TARGET_DIR%" -filter:"%FILTERS%" -output:"%OUTPUT_TEST_DIR%\result.xml" -mergebyhash

rem ���|�[�g�̐���
"%REPORTGEN_BIN%" "%OUTPUT_TEST_DIR%\result.xml" "%OUTPUT_REPORT_DIR%\html"