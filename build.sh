#!/bin/bash

#fastlane setup, easier in bash
if gem list -i fastlane | grep -q false; then gem install --user-install fastlane; fi
export PATH=$PATH:~/.gem/ruby/2.0.0/bin/

mono --runtime=v4.0 .nuget/nuget.exe install FAKE -Version 4.8.0
mono --runtime=v4.0 packages/FAKE.4.8.0/tools/FAKE.exe build.fsx $@
