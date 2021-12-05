# change your directory to /src/
heroku container:login

#docker build -t welearn-bg .
docker build -f Web/WeLearn.Web/Dockerfile -t welearn-bg .

docker tag welearn-bg registry.heroku.com/welearn-bg/web

docker push registry.heroku.com/welearn-bg/web

heroku container:release web --app welearn-bg
