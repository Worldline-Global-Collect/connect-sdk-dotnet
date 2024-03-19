# Migrating from version 3.x.x to 4.0.0

## Dependency

The project name has changed to `Worldline.Connect.Sdk`, or `Worldline.Connect.Sdk.StrongName` if you're using a [Strong-Named assembly](https://learn.microsoft.com/en-us/dotnet/standard/assembly/strong-named). You need to update your dependencies:

```xml
<PackageReference Include="Worldline.Connect.Sdk" Version="4.0.0" />
```

or

```xml
<PackageReference Include="Worldline.Connect.Sdk.StrongName" Version="4.0.0" />
```

## Using statements

All namespaces have been renamed, and some classes and interfaces have moved to different namespaces. Each API version now has its own namespace structure that contains all classes specific for that version, including classes like `APIError`, exceptions and webhooks classes.

You need to change your using statements as follows:

| Previous namespace                   | Class / interface            | New namespace                        | Notes |
|--------------------------------------|------------------------------|--------------------------------------|-------|
| Ingenico.Connect.Sdk                 | AbstractParamRequest         | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | ApiException                 | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | AuthorizationException       | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | CommunicationException       | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | DeclinedPaymentException     | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | DeclinedPayoutException      | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | DeclinedRefundException      | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | DeclinedTransactionException | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | GlobalCollectException       | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | IAuthenticator               | Worldline.Connect.Sdk.Authentication |
| Ingenico.Connect.Sdk                 | IConnection                  | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | IMarshaller                  | Worldline.Connect.Sdk.Json           |
| Ingenico.Connect.Sdk                 | IMultipartFormDataRequest    | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | IPooledConnection            | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | IRequestHeader               | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | IResponseHeader              | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | IdempotenceException         | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | MarshallerSyntaxException    | Worldline.Connect.Sdk.Json           |
| Ingenico.Connect.Sdk                 | MetaDataProvider             | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | MetaDataProviderBuilder      | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | MultipartFormDataObject      | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | NotFoundException            | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | ReferenceException           | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | RequestHeader                | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | RequestHeaderUtils           | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | RequestParam                 | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | ResponseException            | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | ResponseHeader               | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | ResponseHeaderUtils          | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk                 | UploadableFile               | Worldline.Connect.Sdk.Domain         |
| Ingenico.Connect.Sdk                 | ValidationException          | Worldline.Connect.Sdk.V1             |
| Ingenico.Connect.Sdk                 | All other classes            | Worldline.Connect.Sdk                |
| Ingenico.Connect.Sdk.DefaultImpl     | AuthorizationType            | Worldline.Connect.Sdk.Authentication |
| Ingenico.Connect.Sdk.DefaultImpl     | DefaultAuthenticator         | Worldline.Connect.Sdk.Authentication |
| Ingenico.Connect.Sdk.DefaultImpl     | DefaultConnection            | Worldline.Connect.Sdk.Communication  |
| Ingenico.Connect.Sdk.DefaultImpl     | DefaultMarshaller            | Worldline.Connect.Sdk.Json           |
| Ingenico.Connect.Sdk.Domain.Metadata | ShoppingCartExtension        | Worldline.Connect.Sdk.Domain         |
| Ingenico.Connect.Sdk.Domain.*        | All other domain classes     | Worldline.Connect.Sdk.V1.Domain      | All domain classes for version 1 of the API are now in the same namespace |
| Ingenico.Connect.Sdk.Logging         | All classes                  | Worldline.Connect.Sdk.Logging        |
| Ingenico.Connect.Sdk.Merchant.*      | All classes                  | Worldline.Connect.Sdk.V1.Merchant.*  | The same namespace structure is used |
| Ingenico.Connect.Sdk.Webhooks        | WebhooksHelper               | Worldline.Connect.Sdk.V1.Webhooks    |
| Ingenico.Connect.Sdk.Webhooks        | WebhooksHelperBuilder        | Worldline.Connect.Sdk.V1.Webhooks    |
| Ingenico.Connect.Sdk.Webhooks        | All other classes            | Worldline.Connect.Sdk.Webhooks       |

## Configuration

If you're using an `app.config` or `web.config` file you need to change the type of the configuration section:

```xml
<configSections>
    <section name="ConnectSDK" type="Worldline.Connect.Sdk.CommunicatorConfigurationSection, Worldline.Connect.Sdk"></section>
</configSections>
```

## API calls

Method `Merchant` of class `Client` is replaced with method `WithNewMerchant` of new class `V1Client`. Instances of this class are available through read-only property `V1` of class `Client`. In addition, methods of class `MerchantClient` have been replaced with read-only properties. You need to replace all occurrences of `.Merchant` with `.V1.WithNewMerchant` in your code, and remove `()` from all accesses to intermediate clients. For instance:

```c#
var response = await client.V1.WithNewMerchant(merchantId).Services.Testconnection();
```

## API version

Constant `ApiVersion` of class `Client` has been removed. You need to replace all occurrences in your code with string literal `"v1"`.

## ApiResource

Method `CreateException` of class `ApiResource` has been removed. You need to replace all occurrences in your code with `ExceptionFactory.CreateException`. Note that this class is specific for version 1 of the API.

## GlobalCollectException

Class `GlobalCollectException` has been renamed to `PlatformException`. You need to replace all occurrences in your code with the new name.

## Session

Class `Session` has been integrated into class `Communicator`. Because class `Session` no longer exists, class `SessionBuilder` has been replaced with class `CommunicatorBuilder`, and the `CreateSessionBuilder` methods of class `Factory` have been replaced with `CreateCommunicatorBuilder` methods.

If you used class `Factory` to instantiate class `SessionBuilder` you need to use the new `CreateCommunicatorBuilder` methods instead. For instance:

```c#
var communicator = Factory.CreateCommunicatorBuilder("apiKeyId", "secretApiKey")
        .WithConnection(connection)
        .Build();
var client = Factory.CreateClient(communicator);
```

If you instantiated class `Session` directly you can use the newly added `CreateCommunicator` and `CreateClient` methods of class `Factory`. These have the same parameters that the `Session` constructor did. For instance:

```c#
var communicator = Factory.CreateCommunicator(apiEndpoint, connection, authenticator, metadataProvider);
```

Alternatively, you can call the `Communicator` constructor directly:

```c#
var communicator = new Communicator(apiEndpoint, connection, authenticator, metadataProvider, marshaller);
```

## Authentication

### IAuthenticator

The `CreateSimpleAuthenticationSignature` method of interface `IAuthenticator` has been renamed to `GetAuthorization`. You need to replace all occurrences in your code with the new name.  
In addition, its return type has changed from `string` to `Task<string>`. You need to use `await` to get the result of all occurrences of the method call in your code, and wrap the return value using `Task.FromResult` in all custom implementations.

### DefaultAuthenticator

Class `DefaultAuthenticator` has been renamed to `V1HMACAuthenticator`. You need to replace all occurrences in your code with the new name.

The `authorizationType` parameter has been dropped from the constructor, as it should always be `V1HMAC`. You need to remove the first argument for all calls to the constructor in your code.

### AuthorizationType

Property `SignatureString` of class `AuthorizationType` has been removed. You need to replace all occurrences in your code with calls to `ToString()`.

## Communication

### Connection

Interface `IConnection` now extends interface `IObfuscationCapable`. You need to implement the `SetBodyObfuscator` and `SetHeaderObfuscator` methods in all custom implementations.

## Metadata

### MetaDataProvider and MetaDataProviderBuilder

Class `MetaDataProvider`, its `ServerMetaDataHeaders` property and class `MetaDataProviderBuilder` used incorrect capitalization. These have been renamed to `MetadataProvider`, `ServerMetadataHeaders` and `MetadataProviderBuilder` respectively. You need to replace all occurrences in your code with the new names.

### Integrator

The integrator is now required. When using an `app.config` or `web.config` file to initialize the SDK, you need to make sure that attribute `integrator` inside the SDK's configuration section is present with a non-empty value. Otherwise, you need to make sure a non-empty integrator is set on any `CommunicatorConfiguration`, `MetadataProviderBuilder` or `MetadataProvider` instance you create.

## Webhooks

### Creating webhooks helpers

Methods `CreateHelper` and `CreateHelperBuilder` of class `Webhooks` have moved to new class `V1WebhooksFactory`. Instances of this class are available through read-only property `V1` of class `Webhooks`. You need to include `.V1` for all occurrences of `Webhooks.CreateHelper` and `Webhooks.CreateHelperBuilder` in your code. For instance:

```c#
var helper = Webhooks.V1.CreateHelper(InMemorySecretKeyStore.INSTANCE);
```

### WebhooksHelper

The protected `Validate` methods of class `WebhooksHelper` have been removed. You need to replace all occurrences in your code with a `SignatureValidator`.
