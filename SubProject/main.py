import ikea_api
import json;
# Constants like country, language, base url
constants = ikea_api.Constants(country="us", language="en")
# Search API
search = ikea_api.Search(constants)
# Search endpoint with prepared data
endpoint = search.search("asodjfhaweuishfsdf")

data = ikea_api.run(endpoint)

f = open("./json/TEST.json", "a")
f.write(json.dumps(data))
f.close()