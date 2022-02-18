"# ReverseProxy" 
Home assignement - reverse proxy.

**get**: etner a key and you will be redirected to the website stored in the mapping

example: http://webapplication10-dev.us-west-1.elasticbeanstalk.com/go?key=191347bfe55d0ca9a574db77bc8648275ce258461450e793528e0cc6d2dcf8f5

param: 191347bfe55d0ca9a574db77bc8648275ce258461450e793528e0cc6d2dcf8f5

result: redirect to http://www.google.com

**create**: etner a url and you will get its hash value
post request to: http://webapplication10-dev.us-west-1.elasticbeanstalk.com/create

json: {"ur" : "www.google.col"}

result: 191347bfe55d0ca9a574db77bc8648275ce258461450e793528e0cc6d2dcf8f5


