# Refund

This repository the source code for the `Refund Application`.
The application is a helm chart with various sub-charts.

## Development Setup

Code base can be cloned from the GitHub Repository.

#### SSH

Create a SSH public key

```bash
ssh-keygen -t ed25519 -C
```

and save it to `~/.ssh/`, this will create two new files (for instance `github` and `github.pub`)
Then upload the public key to Github (Settings > Access > SSH and GPG keys).
To use this SSH key for Github, add the following snipped to `~/.ssh/config`:

```
Host github.com
    AddKeysToAgent yes
    UseKeychain yes
    IdentityFile ~/.ssh/<name-key>
```

#### .NET

Choose an IDE (I recommend Rider). Plugins:
- OpenAPI Specifications
- OpenApi Editor
- Kubernetes Plugin

Install the current [.NET SDK](https://dotnet.microsoft.com/en-us/download).

#### Docker
Install Docker for Desktop. To run and build the container:
```bash
DOCKER_ID=$(docker build -q -f charts/receipts/src/Com.Refund.Services.Receipts/Dockerfile .)
docker run --rm -it $DOCKER_ID
```


## Test Setup

Install the necessary tooling:
```bash
brew install kubectl k9s helm
```

Install minikube:
```bash
brew install minikube
```
Start it:
```bash
minikube start
```

Release the helm chart
```bash
helm install clunky-serval .
```
