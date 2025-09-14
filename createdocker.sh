sudo docker rm webserver-container -f
sudo docker rmi webserver -f
sudo docker build -t webserver  .
sudo docker run --name webserver-container -p 8080:8080 -d webserver 