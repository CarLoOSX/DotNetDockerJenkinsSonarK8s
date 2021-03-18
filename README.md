# NetCoreDockerJenkinsSonarK8s
#### Generate a docker image and deploy to K8s

### Installing NetCore 
 
```
https://dotnet.microsoft.com/download
```

### Jenkins Pipeline Diagram

![alt text](Images/FirstApproachDiagram.png)

### Run The app 

#### Go to project path 

```
NetCoreDockerK8s/src/HelloWorldMicroService
```

#### Execute the app

```
dotnet run
```

#### You will see something like this

![alt text](Images/dotnet-run.png)

#### Run Test

#### Go to project path

```
NetCoreDockerK8s/src/HelloWorldMicroService
```

#### Execute the app

```
dotnet test
```

#### Application

### Base url

http://whiskicasa.tplinkdns.com

### Ports

8080
9000
