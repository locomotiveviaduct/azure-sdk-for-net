// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Migration.Assessment.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Migration.Assessment.Samples
{
    public partial class Sample_MigrationSqlAssessmentV2Collection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_SqlAssessmentV2OperationsCreateMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/SqlAssessmentV2Operations_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "SqlAssessmentV2Operations_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "rgmigrate";
            string projectName = "fci-test6904project";
            string groupName = "test_fci_hadr";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationSqlAssessmentV2Resource
            MigrationSqlAssessmentV2Collection collection = migrationAssessmentGroup.GetMigrationSqlAssessmentV2s();

            // invoke the operation
            string assessmentName = "test_swagger_1";
            MigrationSqlAssessmentV2Data data = new MigrationSqlAssessmentV2Data
            {
                OSLicense = MigrationAssessmentOSLicense.Unknown,
                EnvironmentType = AssessmentEnvironmentType.Production,
                EntityUptime = new AssessmentEntityUptime
                {
                    DaysPerMonth = 30,
                    HoursPerDay = 24,
                },
                OptimizationLogic = SqlOptimizationLogic.MinimizeCost,
                ReservedInstanceForVm = AssessmentReservedInstance.None,
                AzureOfferCodeForVm = AssessmentOfferCode.MSAZR0003P,
                AzureSqlManagedInstanceSettings = new AssessmentSqlMISettings
                {
                    AzureSqlServiceTier = AssessmentSqlServiceTier.Automatic,
                    AzureSqlInstanceType = AssessmentSqlInstanceType.SingleInstance,
                },
                AzureSqlDatabaseSettings = new AssessmentSqlDBSettings
                {
                    AzureSqlServiceTier = AssessmentSqlServiceTier.Automatic,
                    AzureSqlDataBaseType = AssessmentSqlDataBaseType.SingleDatabase,
                    AzureSqlComputeTier = MigrationAssessmentComputeTier.Automatic,
                    AzureSqlPurchaseModel = AssessmentSqlPurchaseModel.VCore,
                },
                AzureSqlVmInstanceSeries = { AssessmentVmFamily.Eadsv5Series },
                MultiSubnetIntent = MultiSubnetIntent.DisasterRecovery,
                AsyncCommitModeIntent = AsyncCommitModeIntent.DisasterRecovery,
                DisasterRecoveryLocation = new AzureLocation("EastAsia"),
                IsHadrAssessmentEnabled = true,
                ReservedInstance = AssessmentReservedInstance.None,
                SqlServerLicense = AssessmentSqlServerLicense.Unknown,
                AzureLocation = new AzureLocation("SoutheastAsia"),
                AzureOfferCode = AssessmentOfferCode.MSAZR0003P,
                Currency = AssessmentCurrency.USD,
                ScalingFactor = 1,
                Percentile = PercentileOfUtilization.Percentile95,
                TimeRange = AssessmentTimeRange.Day,
                DiscountPercentage = 0,
                SizingCriterion = AssessmentSizingCriterion.PerformanceBased,
            };
            ArmOperation<MigrationSqlAssessmentV2Resource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assessmentName, data);
            MigrationSqlAssessmentV2Resource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrationSqlAssessmentV2Data resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SqlAssessmentV2OperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/SqlAssessmentV2Operations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "SqlAssessmentV2Operations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "rgmigrate";
            string projectName = "fci-test6904project";
            string groupName = "test_fci_hadr";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationSqlAssessmentV2Resource
            MigrationSqlAssessmentV2Collection collection = migrationAssessmentGroup.GetMigrationSqlAssessmentV2s();

            // invoke the operation
            string assessmentName = "test_swagger_1";
            MigrationSqlAssessmentV2Resource result = await collection.GetAsync(assessmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrationSqlAssessmentV2Data resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_SqlAssessmentV2OperationsListByGroupMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/SqlAssessmentV2Operations_ListByGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "SqlAssessmentV2Operations_ListByGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "rgmigrate";
            string projectName = "fci-test6904project";
            string groupName = "test_fci_hadr";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationSqlAssessmentV2Resource
            MigrationSqlAssessmentV2Collection collection = migrationAssessmentGroup.GetMigrationSqlAssessmentV2s();

            // invoke the operation and iterate over the result
            await foreach (MigrationSqlAssessmentV2Resource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MigrationSqlAssessmentV2Data resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_SqlAssessmentV2OperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/SqlAssessmentV2Operations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "SqlAssessmentV2Operations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "rgmigrate";
            string projectName = "fci-test6904project";
            string groupName = "test_fci_hadr";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationSqlAssessmentV2Resource
            MigrationSqlAssessmentV2Collection collection = migrationAssessmentGroup.GetMigrationSqlAssessmentV2s();

            // invoke the operation
            string assessmentName = "test_swagger_1";
            bool result = await collection.ExistsAsync(assessmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_SqlAssessmentV2OperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/SqlAssessmentV2Operations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "SqlAssessmentV2Operations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "rgmigrate";
            string projectName = "fci-test6904project";
            string groupName = "test_fci_hadr";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationSqlAssessmentV2Resource
            MigrationSqlAssessmentV2Collection collection = migrationAssessmentGroup.GetMigrationSqlAssessmentV2s();

            // invoke the operation
            string assessmentName = "test_swagger_1";
            NullableResponse<MigrationSqlAssessmentV2Resource> response = await collection.GetIfExistsAsync(assessmentName);
            MigrationSqlAssessmentV2Resource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MigrationSqlAssessmentV2Data resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
