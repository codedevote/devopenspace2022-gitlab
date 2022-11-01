FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL maintainer="someone"

# Set environment variables
ENV ASPNETCORE_URLS="http://*:5000"

# Set the Working Directory
WORKDIR /app/

# Copy the app
COPY TODO_ARTIFACTS_DIRECTORY_HERE/ .

EXPOSE 5000

# Start the app
ENTRYPOINT ["dotnet", "demoapp.dll"]
