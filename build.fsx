#r @"packages/FAKE.4.8.0/tools/FakeLib.dll"
#load "build-helpers.fsx"
open Fake
open System
open BuildHelpers

Target "fastlane" (fun() ->
    Fastlane "path/to/p12" "path/to/profile"
)

RunTarget()
