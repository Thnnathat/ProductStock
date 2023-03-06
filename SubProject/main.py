import ikea_api

# Constants like country, language, base url
constants = ikea_api.Constants(country="us", language="en")
# Search API
search = ikea_api.Search(constants)
# Search endpoint with prepared data
endpoint = search.search("Billy")

ikea_api.run(endpoint)