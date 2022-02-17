"# ReverseProxy" 
Home assignement - reverse proxy.


**create**: etner a url and you will get its hash value
example: https://localhost:7119/Create?url=www.google.com
param: www.google.com
result: 191347bfe55d0ca9a574db77bc8648275ce258461450e793528e0cc6d2dcf8f5

**get**: etner a key and you will be redirected to the website stored in the mapping
example: https://localhost:7119/Go?key=191347bfe55d0ca9a574db77bc8648275ce258461450e793528e0cc6d2dcf8f5
param: 191347bfe55d0ca9a574db77bc8648275ce258461450e793528e0cc6d2dcf8f5
result: redirect to http://www.google.com
