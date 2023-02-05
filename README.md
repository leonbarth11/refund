# Refund

This repository the source code for the `Refund Application`.
The application consists of various helm charts in the [charts](charts) folder.

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



## Test Setup

Install the necessary tooling:
```bash
brew install kubectl k9s helm docker
```

Install minikube:
```bash
brew install minikube
```
