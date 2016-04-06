#r @"packages/FAKE.4.8.0/tools/FakeLib.dll"
#load "build-helpers.fsx"
open Fake
open System

Target "fastlane" (fun() ->
    Console.WriteLine("I'm in the fastlane baby!");
)

RunTarget()
