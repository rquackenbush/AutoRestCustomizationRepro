# AutoRestCustomizationRepro
Attempt to reproduce issue I'm having with AutoRest client generation.

I am unable to customize the models / rest client being generated. The two customizations I'm attempting:

- Rename the `Person` model to `PersonCustomized` using `[CodeGenModel]` [here](Customized/Models/PersonCustomized.cs).
- Supress generation of the `AddPersonAsync` method using `[CodeGenSuppress]` [here](Customized/SampleRestClient.cs).

I expect:
- The generated model for `Person` to be called `PersonCustomized`
- The `AddPersonAsync` to not be present in the generated `SampleRestClient`.


## Running the sample

```
./generate.ps1
```

## Output

```
AutoRest code generation utility [cli version: 3.6.2; node: v18.7.0]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
info    | AutoRest core version selected from configuration: 3.6.2.
debug   | [0.66 s] Network Enabled: true
debug   | [0.73 s] The most recent installed version is 3.8.4
debug   | [0.74 s] Starting @autorest/core from C:\Users\rxq01\.autorest\@autorestcore@3.6.2\nodemodules\@autorest\core
info    |    Loading AutoRest core      'C:\Users\rxq01\.autorest\@autorestcore@3.6.2\nodemodules\@autorest\core\dist' (3.6.2)
verbose | [0.78 s]    Initial configuration file 'file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/autorest.md'
verbose | [0.78 s]    Including configuration file 'file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/autorest.md'
verbose | [0.80 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/default-configuration.md'
verbose | [0.81 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/inspect.md'
verbose | [0.81 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/directives.md'
verbose | [0.82 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/pipeline.md'
verbose | [0.83 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/loader-openapi.md'
verbose | [0.84 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/miscellaneous.md'
verbose | [0.85 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-powershell.md'
verbose | [0.86 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-azureresourceschema.md'
verbose | [0.87 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-csharp.md'
verbose | [0.88 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-go.md'
verbose | [0.89 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-java.md'
verbose | [0.90 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-nodejs.md'
verbose | [0.91 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-php.md'
verbose | [0.92 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-python.md'
verbose | [0.93 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-ruby.md'
verbose | [0.94 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-typescript.md'
verbose | [0.96 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-validators.md'
verbose | [0.97 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-az.md'
verbose | [0.98 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-terraform.md'
verbose | [0.99 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/plugin-azure-functions.md'
verbose | [1.00 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/graphs.md'
verbose | [1.01 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcore@3.6.2/nodemodules/@autorest/core/dist/resources/help-configuration.md'
info    |    Loading AutoRest extension '@autorest/csharp' (latest->3.0.0-beta.20220919.1)
verbose | [1.12 s]    Including extension configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcsharp@3.0.0-beta.20220919.1/nodemodules/@autorest/csharp/readme.md'
verbose | [1.12 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestcsharp@3.0.0-beta.20220919.1/nodemodules/@autorest/csharp/readme.md'
info    |    Loading AutoRest extension '@autorest/modelerfour' (4.23.7->4.23.7)
verbose | [1.19 s]    Including extension configuration file 'file:///C:/Users/rxq01/.autorest/@autorestmodelerfour@4.23.7/nodemodules/@autorest/modelerfour/readme.md'
verbose | [1.19 s]    Including configuration file 'file:///C:/Users/rxq01/.autorest/@autorestmodelerfour@4.23.7/nodemodules/@autorest/modelerfour/readme.md'
debug   | [1.74 s] swagger-document/loader-swagger - START inputs = 0
debug   | [1.74 s] openapi-document/loader-openapi - START inputs = 0
debug   | [1.74 s] pipeline-emitter - START inputs = 0
debug   | [1.74 s] configuration-emitter - START inputs = 0
debug   | [1.74 s] pipeline-emitter - END [0.03 s][81 MB]
debug   | [1.74 s] configuration-emitter - END [0.03 s][81 MB]
verbose | [1.75 s] Reading OpenAPI 3.0 file file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/swagger.json
debug   | [1.75 s] swagger-document/loader-swagger - END [0.03 s][81 MB]
debug   | [1.75 s] openapi-document/loader-openapi - END [0.04 s][82 MB]
debug   | [1.75 s] swagger-document/individual/transform - SKIPPING
debug   | [1.75 s] swagger-document/individual/schema-validator-swagger - SKIPPING
debug   | [1.75 s] swagger-document/identity - SKIPPING
debug   | [1.75 s] swagger-document/individual/identity - SKIPPING
debug   | [1.75 s] openapi-document/openapi-document-converter - SKIPPING
debug   | [1.75 s] openapi-document/individual/transform - START inputs = 1
debug   | [1.76 s] openapi-document/individual/transform - END [0 s][82 MB]
debug   | [1.76 s] openapi-document/individual/schema-validator-openapi - START inputs = 1
debug   | [1.82 s] openapi-document/individual/schema-validator-openapi - END [0.06 s][86 MB]
debug   | [1.82 s] openapi-document/individual/identity - START inputs = 1
debug   | [1.82 s] openapi-document/individual/identity - END [0 s][86 MB]
debug   | [1.82 s] openapi-document/transform - START inputs = 1
debug   | [1.83 s] openapi-document/transform - END [0 s][86 MB]
debug   | [1.83 s] openapi-document/semantic-validator - START inputs = 1
debug   | [1.83 s] openapi-document/semantic-validator - END [0 s][86 MB]
debug   | [1.83 s] openapi-document/allof-cleaner - START inputs = 1
debug   | [1.83 s] openapi-document/allof-cleaner - END [0 s][86 MB]
debug   | [1.83 s] openapi-document/tree-shaker - START inputs = 1
debug   | [1.83 s] openapi-document/tree-shaker - END [0 s][87 MB]
debug   | [1.83 s] openapi-document/multi-api-merger - START inputs = 1
debug   | [1.84 s] openapi-document/multi-api-merger - END [0 s][88 MB]
debug   | [1.84 s] openapi-document/components-cleaner - START inputs = 1
debug   | [1.84 s] openapi-document/components-cleaner - END [0 s][89 MB]
debug   | [1.84 s] openapi-document/component-modifiers - START inputs = 1
debug   | [1.84 s] openapi-document/component-modifiers - END [0 s][89 MB]
debug   | [1.84 s] openapi-document/api-version-parameter-handler - START inputs = 1
debug   | [1.84 s] openapi-document/api-version-parameter-handler - END [0 s][89 MB]
debug   | [1.84 s] openapi-document/profile-filter - START inputs = 1
debug   | [1.84 s] openapi-document/profile-filter - END [0 s][89 MB]
debug   | [1.84 s] openapi-document/model-deduplicator - START inputs = 1
debug   | [1.84 s] openapi-document/emitter - START inputs = 1
debug   | [1.85 s] openapi-document/model-deduplicator - END [0 s][90 MB]
debug   | [1.85 s] openapi-document/emitter - END [0 s][90 MB]
debug   | [1.85 s] openapi-document/enum-deduplicator - START inputs = 1
debug   | [1.85 s] openapi-document/enum-deduplicator - END [0 s][92 MB]
debug   | [1.85 s] openapi-document/subset-reducer - START inputs = 1
debug   | [1.85 s] openapi-document/subset-reducer - END [0 s][92 MB]
debug   | [1.85 s] openapi-document/multi-api/reset-identity - START inputs = 1
debug   | [1.85 s] openapi-document/multi-api/reset-identity - END [0 s][81 MB]
debug   | [1.85 s] openapi-document/multi-api/identity - START inputs = 1
debug   | [1.85 s] openapi-document/multi-api/identity - END [0 s][81 MB]
debug   | [1.85 s] openapi-document/multi-api/emitter - START inputs = 1
debug   | [1.85 s] prechecker - START inputs = 1
debug   | [1.85 s] openapi-document/multi-api/emitter - END [0 s][81 MB]
warning | PreCheck/CheckDuplicateSchemas | Checking for duplicate schemas, this could take a (long) while.  Run with --verbose for more detail.
verbose | [1.87 s] Found and removed 0 duplicate schema
debug   | [1.98 s] prechecker - END [0.12 s][82 MB]
debug   | [1.98 s] modelerfour - START inputs = 2
verbose | [1.99 s]   ModelerFour/api-version-mode:client
verbose | [1.99 s]   ModelerFour/api-version-parameter:constant
verbose | [1.99 s]   ModelerFour/use-model-namespace:false
warning | Modeler/MissingType | The schema 'components·rkd7gj·schemas·createorreplacepersonrequest·additionalproperties' has no type or format information whatsoever. Location:
   file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/swagger.json#/components/schemas/components·rkd7gj·schemas·createorreplacepersonrequest·additionalproperties
warning | Modeler/MissingType | The schema 'Person-additionalProperties' has no type or format information whatsoever. Location:
   file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/swagger.json#/components/schemas/Person-additionalProperties
warning | Modeler/MissingType | The schema 'CreateOrReplacePersonResponse-additionalProperties' has no type or format information whatsoever. Location:
   file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/swagger.json#/components/schemas/CreateOrReplacePersonResponse-additionalProperties
debug   | [2.01 s] modelerfour - END [0.03 s][83 MB]
debug   | [2.01 s] modelerfour/new-transform - START inputs = 2
debug   | [2.01 s] modelerfour/new-transform - END [0 s][83 MB]
debug   | [2.01 s] modelerfour/flattener - START inputs = 2
debug   | [2.02 s] modelerfour/flattener - END [0.01 s][84 MB]
debug   | [2.03 s] modelerfour/flattener/new-transform - START inputs = 2
debug   | [2.03 s] modelerfour/flattener/new-transform - END [0 s][84 MB]
debug   | [2.03 s] modelerfour/grouper - START inputs = 2
debug   | [2.04 s] modelerfour/grouper - END [0.01 s][85 MB]
debug   | [2.04 s] modelerfour/grouper/new-transform - START inputs = 2
debug   | [2.04 s] modelerfour/grouper/new-transform - END [0 s][85 MB]
debug   | [2.04 s] modelerfour/pre-namer - START inputs = 2
debug   | [2.07 s] modelerfour/pre-namer - END [0.03 s][85 MB]
debug   | [2.07 s] modelerfour/pre-namer/new-transform - START inputs = 2
debug   | [2.08 s] modelerfour/pre-namer/new-transform - END [0 s][86 MB]
debug   | [2.08 s] modelerfour/checker - START inputs = 4
debug   | [2.09 s] modelerfour/checker - END [0.01 s][86 MB]
debug   | [2.09 s] modelerfour/identity - START inputs = 2
debug   | [2.09 s] modelerfour/identity - END [0 s][86 MB]
debug   | [2.09 s] csharpgen - START inputs = 2
debug   | [2.09 s] modelerfour/emitter - START inputs = 2
debug   | [2.09 s] modelerfour/notags/emitter - START inputs = 2
debug   | [2.09 s] modelerfour/emitter - END [0 s][87 MB]
debug   | [2.09 s] modelerfour/notags/emitter - END [0 s][87 MB]
warning | output-folder path should be an absolute path
debug   | [4.00 s] csharpgen - END [1.91 s][87 MB]
debug   | [4.00 s] csharpgen/emitter - START inputs = 8
debug   | [4.00 s] Emitting 'source-file-csharp' at file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/Generated/Models/CreateOrReplacePersonRequest.cs
debug   | [4.00 s] Emitting 'source-file-csharp' at file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/Generated/Models/CreateOrReplacePersonRequest.Serialization.cs
debug   | [4.00 s] Emitting 'source-file-csharp' at file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/Generated/Models/Person.cs
debug   | [4.00 s] Emitting 'source-file-csharp' at file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/Generated/Models/Person.Serialization.cs
debug   | [4.00 s] Emitting 'source-file-csharp' at file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/Generated/Models/CreateOrReplacePersonResponse.cs
debug   | [4.00 s] Emitting 'source-file-csharp' at file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/Generated/Models/CreateOrReplacePersonResponse.Serialization.cs
debug   | [4.00 s] Emitting 'source-file-csharp' at file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/Generated/AutoRestCustomizationReproModelFactory.cs
debug   | [4.00 s] Emitting 'source-file-csharp' at file:///C:/code/rquackenbush/AutoRestCustomizationRepro/src/AutoRestCustomizationRepro/Generated/SampleRestClient.cs
debug   | [4.00 s] csharpgen/emitter - END [0 s][88 MB]
[4 s] Clearing Folders.
[4 s] Writing Outputs.
[4 s] Generation Complete
[4 s] Shutting Down.
[4.01 s] Exiting.
```