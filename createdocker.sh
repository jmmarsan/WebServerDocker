sudo docker rm jmmarsan.webserver-container -f
sudo docker rmi jmmarsan.webserver -f
sudo docker build -t jmmarsan.webserver  .
sudo docker run --name jmmarsan.webserver-container -p 8080:8080 -d jmmarsan.webserver 