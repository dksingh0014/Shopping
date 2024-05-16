#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
#The purpose of creating the Docker file is when we ask Docker to extract the image of our project,
#it will search for a file which name is Docker file in the project.
#So this will make our application work accordingly to the settings in our file into the docker.

#Basically Docker file consists of two main parts.

#The first part is the building, the application, and the second part is the running the application.

#If we look at the commands area in here, the from part = > where the base image is specified in whichever
#library the from project is used.
#
#In this project, we are retrieving ASP.Net eight(8.0) image.
#Starting from that image, we are taking this the base image.
#
#If you look at what command are using for us, we are using the.
#Net eight SDK.
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
#And the WORKDIR command.
#It is a part where we specify the folder, under this folder location.
#Docker container will copy the files for our project means Docker will copy files for us in the app folder location.
WORKDIR /app
EXPOSE 8080
#dfffg
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
#And of course we have a copy Command.
#copy is the command used by copy project files from local file system to Docker image.
#In our project we will first copy and restore the C-sharp project file.
#After that, copy all these files again and create our application by running the Dotnet publish command.
COPY ["Shopping.Client.csproj", "."]
#And also we have one of the main command which is RUN.
#It is used for the commands that we need to run while the containers are being prepared.
#First, it is ensured that the build is taken and then it is published The operation.
RUN dotnet restore "./Shopping.Client.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./Shopping.Client.csproj" -c $BUILD_CONFIGURATION -o /app/build

# the second part is the publish and running the application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Shopping.Client.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shopping.Client.dll"]
#And another point is the entry point.
#Entry point is the command that we specify for the first command and parameters that will run when the
#container is up.
#
#While the container is running.
#For example, in our case shopping dot Client dot DLL.
#This will be executed with the dot net command.
#We see the docker file and the command explanations.