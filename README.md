# Maussoft.Mvc C# example

An example application in C# for Maussoft.Mvc (Simple C# web framework for .NET 5).

### Build single executable

You can run the following in the project directory:

    dotnet publish \
        /p:Configuration=Release \
        /p:PublishSingleFile=true \
        /p:RuntimeIdentifier=linux-x64 \
        /p:DebugType=None \
        /p:DebugSymbols=false
    
You end up with two files in `bin/Release/net5.0/linux-x64/publish`:

- appsettings.json
- Acme.Example

One is the config file, the other one the executable.
 
### TODO

- add 404 for nonmatching route 
- add debug toolbar with
  - routing debugger (remove router debug output)
  - API client debugger (API call pane)
  - MySQL connection debugging (query pane)
