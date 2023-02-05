# Receipts Service

Implementation of the Receipts API endpoint /receipts.

## OpenAPI Generator

The basic service skeleton is generated using the openapi generator.
The models can be generated with

````bash
sh ../../openapi-generator/generate.sh Com.Refund.Services.Receipts
````

## Docker

#### Docker

To run and build the container:

```bash
DOCKER_ID=$(docker build -q .)
docker run --rm -it $DOCKER_ID
```

#### Helm

To deploy a helm chart locally, first start minikube:

```bash
minikube start
```

Release the helm chart

```bash
helm install clunky-serval .
```

