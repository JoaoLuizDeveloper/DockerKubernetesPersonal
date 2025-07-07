DockerKubernetesPersonal
<br />
Personal project using ASP.NET Core MVC, Docker, and Kubernetes to containerize and orchestrate a simple web application.

📁 Project Structure
Controllers/, Models/, Views/: MVC architecture.

Data/, Migrations/: Entity Framework Core setup.

Dockerfile: Defines the Docker image.

dockerkubernetes-deploy.yml: Kubernetes deployment.

dockerkubernetes-service.yml: Kubernetes service.

appsettings*.json: Application settings.

🚀 Technologies
ASP.NET Core 6 MVC

Entity Framework Core

Docker

Kubernetes

⚙️ How to Run
<br />
Docker
<br />
docker build -t docker-kubernetes-personal .
<br />
docker run -d -p 5000:80 docker-kubernetes-personal
<br />
Open: http://localhost:5000

<br />
Kubernetes
<br />
kubectl apply -f dockerkubernetes-deploy.yml
<br />
kubectl apply -f dockerkubernetes-service.yml
<br />
kubectl get services
<br />
Access the app via the service's external IP.
<br />
🤝 Contributing
Feel free to fork, open issues, or submit pull requests.

📄 License
This project is licensed under the MIT License.
