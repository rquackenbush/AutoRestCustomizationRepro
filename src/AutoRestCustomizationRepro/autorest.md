# Azure.DigitalTwins.Core

Run `generate.ps1` in this directory to generate code.

## AutoRest Configuration

> see <https://aka.ms/autorest>

> see <https://github.com/Azure/autorest/blob/main/docs/generate/flags.md>

``` yaml
input-file: swagger.json
csharp: true 
output-folder: Generated/ 
namespace: AutoRestCustomizationRepro
skip-csproj: true
clear-output-folder: true
override-client-name: AutoRestCustomizationRepro
generation1-convenience-client: true
project-folder: ./
```

