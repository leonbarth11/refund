# Receipts Service

Implementation of the Receipts API endpoint /receipts.

## OpenAPI Generator
The basic service skeleton is generated using the openapi generator.

- Templates can be retrieved with
```bash
docker run --rm -v "${PWD}:/local" \
 openapitools/openapi-generator-cli author template \
  -g aspnetcore \
  -o /local/out
```

- The models can be generated with

````bash
docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
  -i /local/openapi.yaml \
  -g aspnetcore \
  -o /local/out \
  --additional-properties=aspnetCoreVersion=6.0,modelClassModifier=\
  --additional-properties=packageName=Com.Refund.Services.Receipts\
  --global-property models

 mv out/src/Com.Refund.Services.Receipts/Models src/Com.Refund.Services.Receipts/
 rm -r out
````
