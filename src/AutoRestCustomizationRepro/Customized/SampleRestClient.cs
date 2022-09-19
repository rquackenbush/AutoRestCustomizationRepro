using AutoRestCustomizationRepro.Models;
using Azure.Core;

namespace AutoRestCustomizationRepro
{
    [CodeGenSuppress("AddPersonAsync", typeof(CreateOrReplacePersonRequest), typeof(CancellationToken))]
    internal partial class SampleRestClient
    {
    }
}
