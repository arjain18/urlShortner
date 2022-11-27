# urlShortner
urlShortner provides a quick way to shorten the url

This application is developed in .net 6 (MVC) using CSharp and supports docker image

Code uses following 3 files

urlShortner\Controllers\HomeController.cs  --> Rest API

urlShortner\Views\Home\Index.cshtml -> UI 

urlShortner\Helper.cs ->common finctions for Add and read


Unit test are provided as seprate project (Ref: TestProject.zip) . Although solution depends on both the projects.
![Folder structure](https://user-images.githubusercontent.com/30943988/204140111-08656e60-0ba2-4527-8a9e-a3928aca76ae.png)

Docker image can be run using below commands:

 docker build -t urlshortner -f .\Dockerfile .
 
 docker run -it --rm -p 80:80 --name urlshortner-container urlshortner
 
 
 It is also published on : 
https://hub.docker.com/repository/docker/arjain18/urlshortner

You can download using from DockerHub using:

 docker pull arjain18/urlshortner
 
 docker run -it --rm -p 80:80 --name urlshortner-container arjain18/urlshortner
 
 Once running from VS Solution or Docker, you can either browser or use POSTMAN
 ![response](https://user-images.githubusercontent.com/30943988/204140278-52866b85-08c8-4891-b999-8853722e8d29.png)

Unit test responses:
![UnitTest](https://user-images.githubusercontent.com/30943988/204140289-90fb560c-e557-41f2-88af-4af9eceb3838.png)

Response of URL shortner is saved at location c:\source\myfile.txt and in linux \source\myfile.txt
Logic:
When a short url is requested, it checks in myfile.txt and if its not present it creates a new entry. when a same url is requested, earlier generated response is shared. it generate, if not already available.

Sample response:

<img width="319" alt="image" src="https://user-images.githubusercontent.com/30943988/204140769-cf187915-ca9e-416e-9a5d-b770df2e5c2a.png">

