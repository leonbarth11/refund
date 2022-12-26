#!/bin/sh
# This script should be called from the service directory, e.g. refund/services/receipts and
# takes as an argument the project name of the service, e.g. Com.Refund.Services.Receipts
# It generates the models for the service.

# The templates can be pulled with the following command:
# docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli author template -g aspnetcore -o /local/out

set -euo pipefail

INPUT="$PWD"
SCRIPT=$(realpath "$0" | xargs dirname)
OUTPUT="$PWD/output"

docker run --rm \
    -v "${INPUT}:/input" \
    -v "${SCRIPT}:/templates" \
    -v "${OUTPUT}:/output" \
    openapitools/openapi-generator-cli generate \
    -g aspnetcore \
    -c /templates/config.yaml \
    -t /templates \
    -i /input/openapi.yaml \
    --additional-properties=packageName="$1" \
    --global-property models \
    -o /output

cp -r -i "$OUTPUT"/* "$INPUT"
rm -r "$OUTPUT"
