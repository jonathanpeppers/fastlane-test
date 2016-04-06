@echo off

".nuget/nuget.exe" install FAKE -Version 4.8.0
"packages/FAKE.4.8.0/tools/FAKE.exe" build.fsx %1%