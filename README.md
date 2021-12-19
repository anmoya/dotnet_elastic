# Pull docker image
```
docker pull docker.elastic.co/elasticsearch/elasticsearch:7.11.2
```
# Run docker instance
```
docker run -p 9200:9200 -p 9300:9300 -e "discovery.type=single-node" docker.elastic.co/elasticsearch/elasticsearch:7.11.2
```

# Push elements to elastic (generate data)
Do a POST request to `https://localhost:9200/__collection__/_bulk`
Change __collection__ for the name of your collection, i.e. _users_

Body
```json
{"index":{}}
{"name":"User1","age":"30","address":"123 Street"}
{"index":{}}
{"name":"User2","age":"32","address":"456 Street"}
{"index":{}}
{"name":"User3","age":"34","address":"789 Street"}
{"index":{}}
{"name":"User4","age":"35","address":"222 Street"}
{"index":{}}
{"name":"User5","age":"36","address":"695 Street"}
{"index":{}}
{"name":"User6","age":"37","address":"001 Street"}

```
Insert a blanc line intentional at last.

# Build and Run dotnet api
In the project, run `dotnet build` and, if no errors ocurred, `dotnet run`
Alternatively, you can open the project in VS or Rider, then run the api.
