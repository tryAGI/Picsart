#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: merged from 4 Picsart sub-API specs using specs/merge_specs.py
# Then fixed with Python inline:
#   - Remove integer enum on upscale_factor fields (causes int.x2 errors)
#   - Remove required constraint on VideoUploadParameters (binary file uploads)
#
# Source specs:
#   - Image Tools: https://apidocs.picsart.io/picsart-image-tools-api.yaml
#   - Video Tools: https://apidocs.picsart.io/picsart-video-tools-api.yaml
#   - GenAI Tools: https://apidocs.picsart.io/picsart-genai-tools-api.yaml
#   - Variable Data: https://apidocs.picsart.io/picsart-variable-data-tools-api.yaml

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Apply spec fixes (integer enum removal, required file param removal)
python3 -c "
import yaml
with open('openapi.yaml', 'r') as f:
    spec = yaml.safe_load(f)
schemas = spec.get('components', {}).get('schemas', {})
for name, schema in schemas.items():
    props = schema.get('properties', {})
    for pname, pdef in props.items():
        if pname == 'upscale_factor' and pdef.get('type') == 'integer' and 'enum' in pdef:
            del pdef['enum']
if 'VideoUploadParameters' in schemas and 'required' in schemas['VideoUploadParameters']:
    del schemas['VideoUploadParameters']['required']
with open('openapi.yaml', 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, sort_keys=False, allow_unicode=True, width=200)
"

# Auth: X-Picsart-API-Key header
autosdk generate openapi.yaml \
  --namespace Picsart \
  --clientClassName PicsartClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-Picsart-API-Key
