#r @"packages/FAKE.4.8.0/tools/FakeLib.dll"
#load "build-helpers.fsx"
open Fake
open System
open BuildHelpers

Target "fastlane" (fun() ->
    Exec "sigh" "-a com.hitcents.drawastickmanepic2"
)

RunTarget()
