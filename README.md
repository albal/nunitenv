Create to test running a nunit test in a docker container

`docker run -it -v /root/sel/nunitenv:/data -w /data -e URL="http://bing.com" -e GRID="http://10.0.10.10:4444/wd/hub" devpassis/seleniumdotnetcore dotnet test -v d`

-v mount volume to the /data path
-w change the working dir to /data
-e URL: pass in the test URL
-e GRID: pass in the Seleniun GRID URL
dotnet test -v d : run dotnet test in verbose (detailed) mode
