#!/bin/bash
dotnet restore
dotnet build -c Release
dotnet run
