// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.PrivateDns;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PrivateDns.Samples
{
    public partial class Sample_PrivateDnsZoneResource
    {
        // PATCH Private DNS Zone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PATCHPrivateDNSZone()
        {
            // Generated from example definition: specification/privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/examples/PrivateZonePatch.json
            // this example is just showing the usage of "PrivateZones_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateDnsZoneResource created on azure
            // for more information of creating PrivateDnsZoneResource, please refer to the document of PrivateDnsZoneResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroup1";
            string privateZoneName = "privatezone1.com";
            ResourceIdentifier privateDnsZoneResourceId = PrivateDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateZoneName);
            PrivateDnsZoneResource privateDnsZone = client.GetPrivateDnsZoneResource(privateDnsZoneResourceId);

            // invoke the operation
            PrivateDnsZoneData data = new PrivateDnsZoneData(new AzureLocation("placeholder"))
            {
                Tags =
{
["key2"] = "value2",
},
            };
            ArmOperation<PrivateDnsZoneResource> lro = await privateDnsZone.UpdateAsync(WaitUntil.Completed, data);
            PrivateDnsZoneResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateDnsZoneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DELETE Private DNS Zone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DELETEPrivateDNSZone()
        {
            // Generated from example definition: specification/privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/examples/PrivateZoneDelete.json
            // this example is just showing the usage of "PrivateZones_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateDnsZoneResource created on azure
            // for more information of creating PrivateDnsZoneResource, please refer to the document of PrivateDnsZoneResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroup1";
            string privateZoneName = "privatezone1.com";
            ResourceIdentifier privateDnsZoneResourceId = PrivateDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateZoneName);
            PrivateDnsZoneResource privateDnsZone = client.GetPrivateDnsZoneResource(privateDnsZoneResourceId);

            // invoke the operation
            await privateDnsZone.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // GET Private DNS Zone
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GETPrivateDNSZone()
        {
            // Generated from example definition: specification/privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/examples/PrivateZoneGet.json
            // this example is just showing the usage of "PrivateZones_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateDnsZoneResource created on azure
            // for more information of creating PrivateDnsZoneResource, please refer to the document of PrivateDnsZoneResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroup1";
            string privateZoneName = "privatezone1.com";
            ResourceIdentifier privateDnsZoneResourceId = PrivateDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateZoneName);
            PrivateDnsZoneResource privateDnsZone = client.GetPrivateDnsZoneResource(privateDnsZoneResourceId);

            // invoke the operation
            PrivateDnsZoneResource result = await privateDnsZone.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateDnsZoneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GET Private DNS Zone by Subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPrivateDnsZones_GETPrivateDNSZoneBySubscription()
        {
            // Generated from example definition: specification/privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/examples/PrivateZoneListInSubscription.json
            // this example is just showing the usage of "PrivateZones_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subscriptionId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (PrivateDnsZoneResource item in subscriptionResource.GetPrivateDnsZonesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PrivateDnsZoneData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GET Private DNS Zone ALL Record Sets
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRecords_GETPrivateDNSZoneALLRecordSets()
        {
            // Generated from example definition: specification/privatedns/resource-manager/Microsoft.Network/stable/2020-06-01/examples/RecordSetALLList.json
            // this example is just showing the usage of "RecordSets_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateDnsZoneResource created on azure
            // for more information of creating PrivateDnsZoneResource, please refer to the document of PrivateDnsZoneResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroup1";
            string privateZoneName = "privatezone1.com";
            ResourceIdentifier privateDnsZoneResourceId = PrivateDnsZoneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateZoneName);
            PrivateDnsZoneResource privateDnsZone = client.GetPrivateDnsZoneResource(privateDnsZoneResourceId);

            // invoke the operation and iterate over the result
            await foreach (PrivateDnsRecordData item in privateDnsZone.GetRecordsAsync())
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
