
This is just a test project to figure out how to use Aspire to deploy an app to AKS.
This started with `dotnet new aspire-starter -n Aspir8`.
I removed the web project and attempted to add a container for the api project in [Aspir8.AppHost/Program.cs](Aspir8.AppHost/Program.cs).


I'm currently stuck on `No Dockerfile components selected. Skipping build and publish action.`. 

Steps to reproduce:
```
cd Aspir8.AppHost
aspire init
az acr login -n cataggar26acr
aspirate build --disable-secrets=true
```


Example output:
```
~/ms/aspire-starter/Aspir8.AppHost> az acr login -n cataggar26acr
Login Succeeded
~/ms/aspire-starter/Aspir8.AppHost> aspirate build --disable-secrets=true

     _                    _           ___  
    / \     ___   _ __   (_)  _ __   ( _ )
   / _ \   / __| | '_ \  | | | '__|  / _ \
  / ___ \  \__ \ | |_) | | | | |    | (_) |
 /_/   \_\ |___/ | .__/  |_| |_|     \___/
                 |_|
Handle deployments of a .NET Aspire AppHost


── Handling Aspirate State ────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
Loading state from C:\Users\cataggar\ms\aspire-starter\Aspir8.AppHost\aspirate-state.json.
Would you like to use all previous state values, and skip re-prompting where possible ? [y/n] (y): n
(?) Done:  State has been disabled for this run. Only secrets will be populated.

── Handling Aspirate Secrets ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────Secrets are disabled.

── Handling Configuration ─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────Successfully loaded existing aspirate bootstrap settings from '.'.

── Handling Aspire Manifest ───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────Generating Aspire Manifest for supplied App Host
(?) Done:  Created Aspire Manifest At Path: C:\Users\cataggar\ms\aspire-starter\Aspir8.AppHost\manifest.json

── Selecting Required Components ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────

── Gathering Information about deployables ────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
Gathering container details for each project in selected components
(?) Done:  Populated container details cache for project api
Gathering Tasks Completed - Cache Populated.

── Handling Projects ──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
Building all project resources, and pushing containers

Executing: dotnet publish "C:\Users\cataggar\ms\aspire-starter\Aspir8.AppHost\../Aspir8.ApiService/Aspir8.ApiService.csproj" -t:PublishContainer --verbosity "quiet" --nologo -r "linux-x64"
-p:ContainerRegistry="cataggar26acr.azurecr.io" -p:ContainerRepository="api" -p:ContainerImageTag="latest"
(?) Done:  Building and Pushing container for project api
Building and push completed for all selected project components.

── Handling Dockerfiles ───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
No Dockerfile components selected. Skipping build and publish action.

 ?? Execution Completed ??
 ```