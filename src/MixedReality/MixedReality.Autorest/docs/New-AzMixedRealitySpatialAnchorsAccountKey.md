---
external help file:
Module Name: Az.MixedReality
online version: https://learn.microsoft.com/powershell/module/az.mixedreality/new-azmixedrealityspatialanchorsaccountkey
schema: 2.0.0
---

# New-AzMixedRealitySpatialAnchorsAccountKey

## SYNOPSIS
Regenerate specified Key of a Spatial Anchors Account

## SYNTAX

### RegenerateExpanded (Default)
```
New-AzMixedRealitySpatialAnchorsAccountKey -AccountName <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] [-Serial <Int32>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### RegenerateViaIdentityExpanded
```
New-AzMixedRealitySpatialAnchorsAccountKey -InputObject <IMixedRealityIdentity> [-Serial <Int32>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RegenerateViaJsonFilePath
```
New-AzMixedRealitySpatialAnchorsAccountKey -AccountName <String> -ResourceGroupName <String>
 -JsonFilePath <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### RegenerateViaJsonString
```
New-AzMixedRealitySpatialAnchorsAccountKey -AccountName <String> -ResourceGroupName <String>
 -JsonString <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Regenerate specified Key of a Spatial Anchors Account

## EXAMPLES

### Example 1: Regenerate specified Key of a Spatial Anchors Account.
```powershell
New-AzMixedRealitySpatialAnchorsAccountKey -AccountName azpstestanchorsaccount -ResourceGroupName azps_test_group -Serial 1
```

```output
PrimaryKey             SecondaryKey
----------             ------------
OAocrh+K******8VRRO/I= froxBip******KVs6tqyPA=
```

Regenerate specified Key of a Spatial Anchors Account.

## PARAMETERS

### -AccountName
Name of an Mixed Reality Account.

```yaml
Type: System.String
Parameter Sets: RegenerateExpanded, RegenerateViaJsonFilePath, RegenerateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IMixedRealityIdentity
Parameter Sets: RegenerateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Regenerate operation

```yaml
Type: System.String
Parameter Sets: RegenerateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Regenerate operation

```yaml
Type: System.String
Parameter Sets: RegenerateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Name of an Azure resource group.

```yaml
Type: System.String
Parameter Sets: RegenerateExpanded, RegenerateViaJsonFilePath, RegenerateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Serial
.

```yaml
Type: System.Int32
Parameter Sets: RegenerateExpanded, RegenerateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The Azure subscription ID.
This is a GUID-formatted string (e.g.
00000000-0000-0000-0000-000000000000)

```yaml
Type: System.String
Parameter Sets: RegenerateExpanded, RegenerateViaJsonFilePath, RegenerateViaJsonString
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
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

### Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IMixedRealityIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IAccountKeys

## NOTES

## RELATED LINKS

