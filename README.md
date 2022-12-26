# Refund

This repository the source code for the `Refund Application`.

## Setup

Code base can be cloned from the GitHub Repository.

### SSH

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
