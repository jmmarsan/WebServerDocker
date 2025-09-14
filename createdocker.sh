sudo docker rm kubia-csharp-container -f
sudo docker rmi kubia-csharp -f
sudo docker build -t kubia-csharp .
sudo docker run --name kubia-csharp-container -p 8080:8080 -d kubia-csharp