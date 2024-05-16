using static System.Collections.Specialized.BitVector32;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System;

namespace Shopping.Client.Models
{
    public class Product
    {
        //In this video we are going to develop shopping client,
        //microservices, data model and context objects.

        //Before we start, I would like to mention about 'every microservice should have its own database', so
        //we should create data store for shopping client microservices.
        //I will use static list objects values in order to store product data.
        //This is the first step of Our development.
        //We will create a standalone MVC client application with data folder and deploy this application onto Azure.


        //After that, we will continue to develop with consuming products from the shopping API project and compose
        //all microservices on Docker compose and moving to Kubernetes environments.
        //So let me focus one standalone microservice for now.
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Discription { get; set; }
        public string ImageFile { get; set; }
        public double Price { get; set; }
//In this video, we are going to create Docker container for our shopping client microservices.
//For creation Docker container.
//We need to create Docker file for our application.
//This is very easy to using Visual Studio tooling features.
//Let's take an action now.

//First, we are going to add Docker support on our Visual Studio solution.
//So I'm going to right click the shopping client application and you will see the Add button and you
//will see the Add Docker support.
//Let me hit this Docker support.
//Or selecting the target operating system will be the Linux just hitting the.
//    Okay.
//    So this operation creates a new Docker file for us.
//As you can see, that Docker file is created and also it will perform this Docker file operation into
//the Visual Studio.
//Let's see the Docker file.
//Let me open Docker file.

//We can examine the Docker file.
//The Docker file, which we will make the necessary settings for the Docker.
//And automatically, as you can see, that generated.
//The purpose of creating the Docker file is when we ask Docker to extract the image of our project,
//it will search for a file which name is Docker file in the project.
//So this will make our application work accordingly to the settings in our file into the docker.

//So see the files.
//As you can see that it is start with the from and it is has some additional keywords.
//Worker expose copy and run commands.
//Basically Docker file consists of two main parts.

//The first part.
//The first part is the building, the application, and the second part is the running the application.
//This part is building and this part is the publishing and running the application.

//If we look at the commands area in here, the from part where the base image is specified in whichever
//library the from project is used.
//In this project, we are retrieving ASP.Net five image.
//Starting from that image, we are taking this the base image.

//If you look at what command are using for us, we are using the.
//Net five SDK.
//    And the work command.
//It is a part where we specify the folder under which folder location.
//Docker container will copy the files for our project and this will copy files for us the app folder

//location.
//    And of course we have a copy.
//Command copy is the command used by copy project files from local file system to Docker image.

//In our project we will first copy and restore the C-sharp project file.
//After that, copy all these files again and create our application by running the Dotnet publish command.
//And also one of the main command is run.

//It is used for the commands that we need to run while the containers are being prepared.
//First, it is ensured that the build is taken and then it is published.
//The operation.

//And another point is the entry point.
//Entry point is the command that we specify for the first command and parameters that will run when the
//container is up.

//While the container is running the example.
//For example, in our case shopping cart dot HTML.
//This will be executed with the net command.

//Okay.
//    We see the docker file and the command explanations.
//    Now let me check output for logs.
//    Let me open the output.
//    As you can see that we have a container tools and in the container tools Docker desktop is installed.
//    It is trying to verify the desktop, but our docker is not running for now.
//    If my docker was running, you will see that this Docker file will be building on the on the docker

//of your local computer and we will see the outputs of that places.

//So we need firstly start with Docker now and after that we will see how to use this Docker file.
//But let me start the Docker also.
//You should start from the docker on your local computer.


    }
}
