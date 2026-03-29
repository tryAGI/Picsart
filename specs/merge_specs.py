#!/usr/bin/env python3
"""Merge 4 Picsart OpenAPI specs into a single unified spec.

Strategy: Each spec gets a unique path prefix. No path-level servers.
A PrepareRequest hook in the SDK will route requests to the correct host
based on the path prefix.

Usage:
    cd specs/
    curl -sL https://apidocs.picsart.io/picsart-image-tools-api.yaml -o image-tools.yaml
    curl -sL https://apidocs.picsart.io/picsart-video-tools-api.yaml -o video-tools.yaml
    curl -sL https://apidocs.picsart.io/picsart-genai-tools-api.yaml -o genai-tools.yaml
    curl -sL https://apidocs.picsart.io/picsart-variable-data-tools-api.yaml -o vd-tools.yaml
    python3 merge_specs.py
    cp merged-openapi.yaml ../src/libs/Picsart/openapi.yaml
"""

import yaml
import copy
import sys

def load_yaml(path):
    with open(path, 'r') as f:
        return yaml.safe_load(f)

def save_yaml(data, path):
    with open(path, 'w') as f:
        yaml.dump(data, f, default_flow_style=False, sort_keys=False, allow_unicode=True, width=200)


SPECS = [
    {
        'file': 'image-tools.yaml',
        'prefix': '/image',
        'schema_prefix': 'Image',
        'tag_prefix': 'Image',
    },
    {
        'file': 'video-tools.yaml',
        'prefix': '/video',
        'schema_prefix': 'Video',
        'tag_prefix': 'Video',
    },
    {
        'file': 'genai-tools.yaml',
        'prefix': '/genai',
        'schema_prefix': 'GenAI',
        'tag_prefix': 'GenAI',
    },
    {
        'file': 'vd-tools.yaml',
        'prefix': '/vd',
        'schema_prefix': 'VD',
        'tag_prefix': 'VD',
    },
]


def fix_refs(obj, schema_map, response_map):
    """Recursively fix $ref pointers."""
    if isinstance(obj, dict):
        for key, val in list(obj.items()):
            if key == '$ref' and isinstance(val, str):
                if val.startswith('#/components/schemas/'):
                    old_name = val.replace('#/components/schemas/', '')
                    new_name = schema_map.get(old_name, old_name)
                    obj[key] = f'#/components/schemas/{new_name}'
                elif val.startswith('#/components/responses/'):
                    old_name = val.replace('#/components/responses/', '')
                    new_name = response_map.get(old_name, old_name)
                    obj[key] = f'#/components/responses/{new_name}'
            else:
                fix_refs(val, schema_map, response_map)
    elif isinstance(obj, list):
        for item in obj:
            fix_refs(item, schema_map, response_map)


def main():
    merged = {
        'openapi': '3.0.0',
        'info': {
            'title': 'Picsart API',
            'version': '2.0',
            'description': (
                'Unified Picsart API combining Image Tools, Video Tools, GenAI, '
                'and Variable Data Content APIs.\n'
                '[Official documentation](https://docs.picsart.io/)\n'
                '[Developer Guidelines](https://picsart.io/terms)\n'
            ),
        },
        'servers': [
            {'url': 'https://api.picsart.io', 'description': 'Production'},
        ],
        'paths': {},
        'components': {
            'schemas': {},
            'responses': {},
            'securitySchemes': {
                'apiKey': {
                    'type': 'http',
                    'scheme': 'bearer',
                }
            },
        },
        'security': [{'apiKey': []}],
    }

    for spec_info in SPECS:
        spec = load_yaml(spec_info['file'])
        prefix = spec_info['prefix']
        schema_prefix = spec_info['schema_prefix']
        tag_prefix = spec_info['tag_prefix']

        # All schemas get prefixed
        schema_map = {}
        if 'components' in spec and 'schemas' in spec['components']:
            for name, schema_def in spec['components']['schemas'].items():
                new_name = f'{schema_prefix}{name}'
                schema_map[name] = new_name
                merged['components']['schemas'][new_name] = copy.deepcopy(schema_def)

        # All responses get prefixed
        response_map = {}
        if 'components' in spec and 'responses' in spec['components']:
            for name, resp_def in spec['components']['responses'].items():
                new_name = f'{schema_prefix}{name}'
                response_map[name] = new_name
                merged['components']['responses'][new_name] = copy.deepcopy(resp_def)

        # Fix $refs in schemas and responses
        for name in schema_map.values():
            if name in merged['components']['schemas']:
                fix_refs(merged['components']['schemas'][name], schema_map, response_map)
        for name in response_map.values():
            if name in merged['components']['responses']:
                fix_refs(merged['components']['responses'][name], schema_map, response_map)

        # Merge paths with prefix
        if 'paths' in spec:
            for path, path_def in spec['paths'].items():
                merged_path = f'{prefix}{path}'

                path_entry = copy.deepcopy(path_def)

                # Prefix tags
                for method in ('get', 'post', 'put', 'delete', 'patch'):
                    if method in path_entry:
                        op = path_entry[method]
                        if 'tags' in op:
                            op['tags'] = [f'{tag_prefix}: {t}' for t in op['tags']]

                fix_refs(path_entry, schema_map, response_map)

                if merged_path in merged['paths']:
                    print(f'ERROR: Path collision: {merged_path}', file=sys.stderr)
                    sys.exit(1)

                merged['paths'][merged_path] = path_entry

    save_yaml(merged, 'merged-openapi.yaml')

    path_count = len(merged['paths'])
    schema_count = len(merged['components']['schemas'])
    response_count = len(merged['components']['responses'])
    print(f'Merged spec: {path_count} paths, {schema_count} schemas, {response_count} responses')


if __name__ == '__main__':
    main()
