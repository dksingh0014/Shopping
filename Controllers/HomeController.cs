using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Data;
using Shopping.Client.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Shopping.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(ProductContext.Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
//As you can see that we have created Docker file in the last video.
//So now once you edit the Docker file, you will see the run profile change as a docker.
//As you can see that there is a new running profile which name is the came in here.
//So that's automatically arranged by the Visual Studio.
//If there is a Docker file which is adding the Docker run profile, if you click the run Docker, this
//will create a container from your Docker file image and run this container in your local computer.
//Also, it is giving ability to debug your container with the Visual Studio.
//It is very good feature from the Visual Studio.
//So let's see where Visual Studio store these running profiles.
//You can click the properties folder and see the launch settings.
//All running profiles turning in here.
//And as you can see, that Docker running profile came in here which generating from the Visual Studio.
//Once we adding the Docker support and the Docker file generated.
//Okay, now we can run directly this Docker profile.
//Just click to the profile and it will start with some of the Docker commands.
//Basically, we just do abstract these Docker commands from us for now.
//We will examine later, but you can think about that.
//Basically it is creating a Docker image from this Docker file, pulling this base image from the Docker
//up and running the application in our local.
//As you can see that I was putting the breakpoint in the index so we can see the breakpoint in here and
//we can debug and inspect some of the Visual Studio objects.
//And after that, as you can see that this application is running from the Docker container.
//And also we can debug the Docker container from the Visual Studio.
//It is very great, powerful feature.
//You can debug inside of the Docker container and also you can develop and you can start with the develop
//and directly inside of the Docker computer.
//We are ready about the shipment at any of the code because we can also debugging and also building our
//documents.
//So let me show you the Visual Studio part.
//As you can see that we have a container window in here.
//In the container window, we see that the running containers listing in here, you can stop or close
//the container image with these two link operations.
//Also, you can see the environment variables, ports, logs, tricks directly comes from the ASP.Net
//Logs.
//As you can see that these are the ASP.Net Startup logs and you can see the inspector files inside of
//the Docker container.
//So it is very powerful feature when we are using the objects with Visual Studio.
//We seen that the Docker image created from the running profile and we have also debug these application
//with putting these debugger debugging Docker container inside of the Docker images and also Visual Studio
//attaching the container process and able to debug inside of the container.
//And we are developing directly inside of Docker container and it is really about the shipment at any
//code level changes.
//And we saw that there is a very good window which is a container tabs.
//You will see the images and the containers in here.
//First of all, it is downloading these images from looking the Docker file.
//Let me open the Docker file.
//As you can see that the first base image is ASP.Net five image.
//And you can see the in here we have downloaded image ASP.Net five.
//And over that we have creating a new image which is the shopping client with dev, target image and
//now shopping client is running on our local computer and you can see the logs and you can debug the
//applications.
//All is very integrated with the Visual Studio and very good tooling experience with Visual Studio.
//But behind all chickens there is lots of Docker commands performing from the Visual Studio.
//In the next video we will examine these Docker commands where and how the commands running from the
//Visual Studio.
//----------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------
//----------next--------------------------------------------------------------------------------------