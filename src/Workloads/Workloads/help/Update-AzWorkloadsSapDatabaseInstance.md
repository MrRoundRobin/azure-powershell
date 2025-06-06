---
external help file: Az.Workloads-help.xml
Module Name: Az.Workloads
online version: https://learn.microsoft.com/powershell/module/az.workloads/update-azworkloadssapdatabaseinstance
schema: 2.0.0
---

# Update-AzWorkloadsSapDatabaseInstance

## SYNOPSIS
Updates the Database resource.

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzWorkloadsSapDatabaseInstance -Name <String> -ResourceGroupName <String>
 -SapVirtualInstanceName <String> [-SubscriptionId <String>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzWorkloadsSapDatabaseInstance -InputObject <ISapVirtualInstanceIdentity> [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Updates the Database resource.

## EXAMPLES

### Example 1: Add tags for an existing Database instance resource
```powershell
Update-AzWorkloadsSapDatabaseInstance  -Name db0 -ResourceGroupName db0-vis-rg -SapVirtualInstanceName DB0 -Tag @{ Test = "PS"; k2 = "v2"}
```

```output
Name ResourceGroupName ProvisioningState Location      Status  IPAddress  DatabaseSid
---- ----------------- ----------------- --------      ------  ---------  -----------
db0  db0-vis-rg        Succeeded         centraluseuap Running 172.31.5.4 MB0
```

This cmdlet adds new tag name, value pairs to the existing Database instance resource db0.
VIS name and Resource group name are the other input parameters.

### Example 2: Add tags for an existing Database instance resource
```powershell
Update-AzWorkloadsSapDatabaseInstance  -InputObject /subscriptions/49d64d54-e966-4c46-a868-1999802b762c/resourceGroups/db0-vis-rg/providers/Microsoft.Workloads/sapVirtualInstances/DB0/databaseInstances/db0 -Tag @{ Test = "PS"; k2 = "v2"}
```

```output
Name ResourceGroupName ProvisioningState Location      Status  IPAddress  DatabaseSid
---- ----------------- ----------------- --------      ------  ---------  -----------
db0  db0-vis-rg        Succeeded         centraluseuap Running 172.31.5.4 MB0
```

This cmdlet adds new tag name, value pairs to the existing Database instance resource db0.
Here Database instance Azure resource ID is used as the input parameter.

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.ISapVirtualInstanceIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
Database resource name string modeled as parameter for auto generation to work correctly.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SapVirtualInstanceName
The name of the Virtual Instances for SAP solutions resource

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.
The value must be an UUID.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Gets or sets the Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.ISapVirtualInstanceIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.ISapDatabaseInstance

## NOTES

ALIASES

Update-AzVISDatabaseInstance

## RELATED LINKS
