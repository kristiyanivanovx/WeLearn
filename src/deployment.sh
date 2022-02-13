# remove this line if you don't have PowerShell
# powershell.exe

heroku container:login

# change your directory to /src/
#docker build -t welearn-bg .
docker build -f Web/WeLearn.Web/Dockerfile -t welearn-bg .

docker tag welearn-bg registry.heroku.com/welearn-bg/web

docker push registry.heroku.com/welearn-bg/web

heroku container:release web --app welearn-bg
