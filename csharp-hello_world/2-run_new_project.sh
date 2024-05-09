#!/usr/bin/env bash
dotnet new console -n 2-new_project
cd 2-new_project
echo 'Console.WriteLine("Hello World!");'>program.cs
dotnet build
dotnet run