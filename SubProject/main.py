import ikea_api
import json;
# Constants like country, language, base url
constants = ikea_api.Constants(country="us", language="en")
# Search API
search = ikea_api.Search(constants)
# Search endpoint with prepared data
endpoint = search.search("chair", limit=1)

data = ikea_api.run(endpoint)
print()

f = open("data.json", "a")
f.write(json.dumps(data))
f.close()