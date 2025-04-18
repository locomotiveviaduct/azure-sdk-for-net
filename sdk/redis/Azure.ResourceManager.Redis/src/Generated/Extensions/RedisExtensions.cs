// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Redis.Mocking;
using Azure.ResourceManager.Redis.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Redis
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Redis. </summary>
    public static partial class RedisExtensions
    {
        private static MockableRedisArmClient GetMockableRedisArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableRedisArmClient(client0));
        }

        private static MockableRedisResourceGroupResource GetMockableRedisResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableRedisResourceGroupResource(client, resource.Id));
        }

        private static MockableRedisSubscriptionResource GetMockableRedisSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableRedisSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisResource.CreateResourceIdentifier" /> to create a <see cref="RedisResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisArmClient.GetRedisResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RedisResource"/> object. </returns>
        public static RedisResource GetRedisResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRedisArmClient(client).GetRedisResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="RedisFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisArmClient.GetRedisFirewallRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RedisFirewallRuleResource"/> object. </returns>
        public static RedisFirewallRuleResource GetRedisFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRedisArmClient(client).GetRedisFirewallRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisPatchScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisPatchScheduleResource.CreateResourceIdentifier" /> to create a <see cref="RedisPatchScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisArmClient.GetRedisPatchScheduleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RedisPatchScheduleResource"/> object. </returns>
        public static RedisPatchScheduleResource GetRedisPatchScheduleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRedisArmClient(client).GetRedisPatchScheduleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisLinkedServerWithPropertyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisLinkedServerWithPropertyResource.CreateResourceIdentifier" /> to create a <see cref="RedisLinkedServerWithPropertyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisArmClient.GetRedisLinkedServerWithPropertyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RedisLinkedServerWithPropertyResource"/> object. </returns>
        public static RedisLinkedServerWithPropertyResource GetRedisLinkedServerWithPropertyResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRedisArmClient(client).GetRedisLinkedServerWithPropertyResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="RedisPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisArmClient.GetRedisPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RedisPrivateEndpointConnectionResource"/> object. </returns>
        public static RedisPrivateEndpointConnectionResource GetRedisPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRedisArmClient(client).GetRedisPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisCacheAccessPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisCacheAccessPolicyResource.CreateResourceIdentifier" /> to create a <see cref="RedisCacheAccessPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisArmClient.GetRedisCacheAccessPolicyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RedisCacheAccessPolicyResource"/> object. </returns>
        public static RedisCacheAccessPolicyResource GetRedisCacheAccessPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRedisArmClient(client).GetRedisCacheAccessPolicyResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RedisCacheAccessPolicyAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisCacheAccessPolicyAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="RedisCacheAccessPolicyAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisArmClient.GetRedisCacheAccessPolicyAssignmentResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="RedisCacheAccessPolicyAssignmentResource"/> object. </returns>
        public static RedisCacheAccessPolicyAssignmentResource GetRedisCacheAccessPolicyAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableRedisArmClient(client).GetRedisCacheAccessPolicyAssignmentResource(id);
        }

        /// <summary>
        /// Gets a collection of RedisResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisResourceGroupResource.GetAllRedis()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of RedisResources and their operations over a RedisResource. </returns>
        public static RedisCollection GetAllRedis(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableRedisResourceGroupResource(resourceGroupResource).GetAllRedis();
        }

        /// <summary>
        /// Gets a Redis cache (resource description).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisResourceGroupResource.GetRedisAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<RedisResource>> GetRedisAsync(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableRedisResourceGroupResource(resourceGroupResource).GetRedisAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Redis cache (resource description).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisResourceGroupResource.GetRedis(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<RedisResource> GetRedis(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableRedisResourceGroupResource(resourceGroupResource).GetRedis(name, cancellationToken);
        }

        /// <summary>
        /// Checks that the redis cache name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisSubscriptionResource.CheckRedisNameAvailability(RedisNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability Redis operation. The only supported resource type is 'Microsoft.Cache/redis'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response> CheckRedisNameAvailabilityAsync(this SubscriptionResource subscriptionResource, RedisNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableRedisSubscriptionResource(subscriptionResource).CheckRedisNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the redis cache name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisSubscriptionResource.CheckRedisNameAvailability(RedisNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability Redis operation. The only supported resource type is 'Microsoft.Cache/redis'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response CheckRedisNameAvailability(this SubscriptionResource subscriptionResource, RedisNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableRedisSubscriptionResource(subscriptionResource).CheckRedisNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Gets all Redis caches in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/redis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisSubscriptionResource.GetAllRedis(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="RedisResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<RedisResource> GetAllRedisAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableRedisSubscriptionResource(subscriptionResource).GetAllRedisAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all Redis caches in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/redis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisSubscriptionResource.GetAllRedis(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="RedisResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<RedisResource> GetAllRedis(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableRedisSubscriptionResource(subscriptionResource).GetAllRedis(cancellationToken);
        }

        /// <summary>
        /// For checking the ongoing status of an operation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/asyncOperations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AsyncOperationStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisSubscriptionResource.GetAsyncOperationStatus(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location at which operation was triggered. </param>
        /// <param name="operationId"> The ID of asynchronous operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="operationId"/> is null. </exception>
        public static async Task<Response<RedisOperationStatus>> GetAsyncOperationStatusAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableRedisSubscriptionResource(subscriptionResource).GetAsyncOperationStatusAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// For checking the ongoing status of an operation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/asyncOperations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AsyncOperationStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableRedisSubscriptionResource.GetAsyncOperationStatus(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location at which operation was triggered. </param>
        /// <param name="operationId"> The ID of asynchronous operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="operationId"/> is null. </exception>
        public static Response<RedisOperationStatus> GetAsyncOperationStatus(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableRedisSubscriptionResource(subscriptionResource).GetAsyncOperationStatus(location, operationId, cancellationToken);
        }
    }
}
