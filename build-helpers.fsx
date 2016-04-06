module BuildHelpers
#r @"packages/FAKE.4.8.0/tools/FakeLib.dll"

open Fake
open Fake.MSBuildHelper

let Exec command args =
    let result = Shell.Exec(command, args)
    if result <> 0 then failwithf "%s exited with error %d" command result