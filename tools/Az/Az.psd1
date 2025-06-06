#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 5/14/2025
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '14.0.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with PowerShell and Windows PowerShell.
For more information about the Az module, please visit the following: https://learn.microsoft.com/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '5.0.1'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '7.0.0'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '4.1.0'; }, 
               @{ModuleName = 'Az.App'; RequiredVersion = '2.0.1'; }, 
               @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '2.3.0'; }, 
               @{ModuleName = 'Az.ArcResourceBridge'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Attestation'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.Automanage'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.11.1'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.7.0'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.2.0'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'Az.CloudService'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.16.0'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '10.0.0'; }, 
               @{ModuleName = 'Az.ConfidentialLedger'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.ConnectedMachine'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '4.1.1'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '4.3.0'; }, 
               @{ModuleName = 'Az.CosmosDB'; RequiredVersion = '1.18.0'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.2.1'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.10.0'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.19.2'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.DataProtection'; RequiredVersion = '2.7.0'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '5.4.1'; }, 
               @{ModuleName = 'Az.DevCenter'; RequiredVersion = '2.0.1'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.DnsResolver'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.ElasticSan'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '2.2.0'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '5.3.0'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.13.0'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '4.2.1'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '6.3.1'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.HealthDataAIServices'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.8.0'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '6.3.1'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '2.4.0'; }, 
               @{ModuleName = 'Az.LoadTesting'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.6.0'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.MachineLearningServices'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.5.1'; }, 
               @{ModuleName = 'Az.ManagedServiceIdentity'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '2.2.0'; }, 
               @{ModuleName = 'Az.Migrate'; RequiredVersion = '2.7.1'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '6.0.2'; }, 
               @{ModuleName = 'Az.MySql'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '7.17.0'; }, 
               @{ModuleName = 'Az.NetworkCloud'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Nginx'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '3.3.0'; }, 
               @{ModuleName = 'Az.Oracle'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.7.1'; }, 
               @{ModuleName = 'Az.PostgreSql'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '7.7.1'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.11.0'; }, 
               @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.ResourceGraph'; RequiredVersion = '1.2.1'; }, 
               @{ModuleName = 'Az.ResourceMover'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '8.0.0'; }, 
               @{ModuleName = 'Az.Security'; RequiredVersion = '1.8.0'; }, 
               @{ModuleName = 'Az.SecurityInsights'; RequiredVersion = '3.2.0'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '4.1.1'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '3.5.0'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '6.0.4'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '2.4.0'; }, 
               @{ModuleName = 'Az.StackHCI'; RequiredVersion = '2.6.0'; }, 
               @{ModuleName = 'Az.StackHCIVM'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '9.0.0'; }, 
               @{ModuleName = 'Az.StorageMover'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '2.5.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.Synapse'; RequiredVersion = '3.2.1'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '3.4.1'; }, 
               @{ModuleName = 'Az.Workloads'; RequiredVersion = '1.0.0'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '14.0.0 - May 2025
Az.Accounts
* Changed the default output access token of ''Get-AzAccessToken'' from plain text to ''SecureString''.
* Removed the warning message about failing to initialize PSStyle in automation runbooks. [#26155]
* Increased the timeout for tab-completion of location, resource group, etc. to 10 seconds.

Az.Aks
* Introduced various new features by upgrading code generator. Please see detail [here](https://github.com/Azure/azure-powershell/blob/main/documentation/Autorest-powershell-v4-new-features.md).
* Updated the default value of ''-NodeVmSize'' parameter in ''New-AzAksCluster'' and ''-VmSize'' parameter in ''New-AzAksNodePool'' from ''Standard_D2_V2'' to being dynamically selected by the AKS resource provider based on quota and capacity in the next major release.

Az.AppConfiguration
* Introduced various new features by upgrading code generator. Please see detail [here](https://github.com/Azure/azure-powershell/blob/main/documentation/Autorest-powershell-v4-new-features.md).

Az.Cdn
* Upgraded Api version to 2025-04-15
* Added support for cipher
* Added support for migration from classic cdn to afdx

Az.Compute
* Added new properties ''Architecture'', ''HyperVGeneration'', and ''ImageDeprecationStatus'' to be returned in ''Get-AzVMImage'' ListVMImage parameter set.
* Deprecated ''Get-AzVMSize'' ''List Virtual Machine Size'' parameter set. 
* Added new parameters ''EnableAutomaticZoneRebalance'', ''AutomaticZoneRebalanceStrategy'' and ''AutomaticZoneRebalanceBehavior'' to ''New-AzVmssConfig'' and ''Update-AzVmss'' cmdlets for VMSS Automatic Zone Rebalancing. 

Az.EventHub
* Added parameters ''MaxReplicationLagDurationInSeconds'' and ''Replicalocation'' in cmdlets ''New-AzEventHubNamespace'' & ''Set-AzEventHubNamespace''
* Added new cmdlets for doing namespace failover - ''Start-AzEventHubNamespaceFailOver''
* Added new cmdlets for generating replication object for Replication parameter - ''New-AzEventHubLocationsNameObject''

Az.Functions
* Updated API client to latest commit for version 2023-12-01
* Refreshed stack definitions
* Enforced runtime EOL policy for function app creation: block expired, warn if within 6 months

Az.ManagedServiceIdentity
* Introduced various new features by upgrading code generator. Please see details [here](https://github.com/Azure/azure-powershell/blob/main/documentation/Autorest-powershell-v4-new-features.md).

Az.Migrate
* Added validation for Data.Replication
  - Added validation to protect virtual machines in ''New-AzMigrateLocalServerReplication''

Az.Network
* Onboarded ''Microsoft.FluidRelay/fluidRelayServers'' to private link cmdlets

Az.RecoveryServices
* Updated ''GetAzureRmRecoveryServicesBackupSchedulePolicyObject'' to default the ''PolicySubType'' to ''Enhanced'' for AzureVM.
* Updated Azure Backup SDK version to support protecting TVM with standard policy.

Az.RedisEnterpriseCache
* Added support for listing all SKUs a cluster can scale to.
* Added a new enum: NoCluster for Clustering policy.

Az.Resources
* [Breaking Change] Updated API version of resource types from latest to DefaultApiVersion for cmdlets ''*-AzResource'' and ''Invoke-AzResourceAction''.

Az.Sql
* Added server level action groups in enum of action groups to be able to be configured via auditing.

Az.StackHCI
* Added EOL Message for 22H2

Az.Storage
* Removed MD5 from blob and file upload in some scenarios
    - ''Set-AzStorageFileContent''
    - ''Set-AzStorageBlobContent''
* Added prompt for customer confirmation for long running account migration operation .
    - ''Start-AzStorageAccountMigration''
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

