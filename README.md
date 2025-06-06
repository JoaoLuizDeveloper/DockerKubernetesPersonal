DockerKubernetesPersonal
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
Docker
bash
Copiar
Editar
docker build -t docker-kubernetes-personal .
docker run -d -p 5000:80 docker-kubernetes-personal
Open: http://localhost:5000

Kubernetes
bash
Copiar
Editar
kubectl apply -f dockerkubernetes-deploy.yml
kubectl apply -f dockerkubernetes-service.yml
kubectl get services
Access the app via the service's external IP.

🤝 Contributing
Feel free to fork, open issues, or submit pull requests.

📄 License
This project is licensed under the MIT License.
