---
external help file: Microsoft.Azure.PowerShell.Cmdlets.NetAppFiles.dll-Help.xml
Module Name: Az.NetAppFiles
online version: https://learn.microsoft.com/powershell/module/az.netappfiles/update-aznetappfilesactivedirectory
schema: 2.0.0
---

# Update-AzNetAppFilesActiveDirectory

## SYNOPSIS
Updates an Azure NetApp Files (ANF) active directory configuration to the optional modifiers provided.

## SYNTAX

### ByFieldsParameterSet (Default)
```
Update-AzNetAppFilesActiveDirectory -ResourceGroupName <String> -AccountName <String>
 -ActiveDirectoryId <String> [-Dns <String[]>] [-Domain <String>] [-Site <String>] [-SmbServerName <String>]
 [-Username <String>] [-Password <SecureString>] [-OrganizationalUnit <String>] [-KdcIP <String>]
 [-BackupOperator <String[]>] [-ServerRootCACertificate <String>] [-AdName <String>]
 [-SecurityOperator <String[]>] [-AesEncryption] [-LdapSigning] [-LdapOverTLS] [-AllowLocalNfsUsersWithLdap]
 [-Administrator <String[]>] [-EncryptDCConnection] [-LdapSearchScope <PSNetAppFilesLdapSearchScopeOpt>]
 [-PreferredServersForLdapClient <String[]>] [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByParentObjectParameterSet
```
Update-AzNetAppFilesActiveDirectory -ActiveDirectoryId <String> [-Dns <String[]>] [-Domain <String>]
 [-Site <String>] [-SmbServerName <String>] [-Username <String>] [-Password <SecureString>]
 [-OrganizationalUnit <String>] [-KdcIP <String>] [-BackupOperator <String[]>]
 [-ServerRootCACertificate <String>] [-AdName <String>] [-SecurityOperator <String[]>] [-AesEncryption]
 [-LdapSigning] [-LdapOverTLS] [-AllowLocalNfsUsersWithLdap] [-Administrator <String[]>] [-EncryptDCConnection]
 [-LdapSearchScope <PSNetAppFilesLdapSearchScopeOpt>] [-PreferredServersForLdapClient <String[]>]
 -AccountObject <PSNetAppFilesAccount> [-DefaultProfile <IAzureContextContainer>]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByObjectParameterSet
```
Update-AzNetAppFilesActiveDirectory [-Dns <String[]>] [-Domain <String>] [-Site <String>]
 [-SmbServerName <String>] [-Username <String>] [-Password <SecureString>] [-OrganizationalUnit <String>]
 [-KdcIP <String>] [-BackupOperator <String[]>] [-ServerRootCACertificate <String>] [-AdName <String>]
 [-SecurityOperator <String[]>] [-AesEncryption] [-LdapSigning] [-LdapOverTLS] [-AllowLocalNfsUsersWithLdap]
 [-Administrator <String[]>] [-EncryptDCConnection] [-LdapSearchScope <PSNetAppFilesLdapSearchScopeOpt>]
 [-PreferredServersForLdapClient <String[]>] -InputObject <PSNetAppFilesActiveDirectory>
 [-DefaultProfile <IAzureContextContainer>] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The **Update-AzNetAppFilesActiveDirectory** cmdlet modifies an ANF active directory configuration.

## EXAMPLES

### Example 1
```powershell
Update-AzNetAppFilesActiveDirectory  -ResourceGroupName "MyRG" -AccountName "MyAccount" -AdName "MyADName" -Username "AdUserName"
```

This command performs an update on the given active directory configuration modifying the username to that provided.

## PARAMETERS

### -AccountName
The name of the ANF account

```yaml
Type: System.String
Parameter Sets: ByFieldsParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountObject
The account for the active directory object

```yaml
Type: Microsoft.Azure.Commands.NetAppFiles.Models.PSNetAppFilesAccount
Parameter Sets: ByParentObjectParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ActiveDirectoryId
The ID of the ANF active directory

```yaml
Type: System.String
Parameter Sets: ByFieldsParameterSet, ByParentObjectParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Administrator
Domain Users to be added to the Built-in Administrators Active Directory group. A list of unique usernames without domain specifier.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdName
Name of the active directory machine.
This optional parameter is used only while creating kerberos volume

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AesEncryption
When AES is enabled, set if AES encryption will be enabled for SMB communication.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowLocalNfsUsersWithLdap
If enabled, NFS client local users can also (in addition to LDAP users) access the NFS volumes.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupOperator
Users to be added to the Built-in Backup Operator active directory group.
A list of unique usernames without domain specifier

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Dns
Comma separated list of DNS server IP addresses (IPv4 only) for the Active Directory domain

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Domain
Name of the Active Directory domain

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EncryptDCConnection
If enabled, Traffic between the SMB server to Domain Controller (DC) will be encrypted.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
The active directory object to remove

```yaml
Type: Microsoft.Azure.Commands.NetAppFiles.Models.PSNetAppFilesActiveDirectory
Parameter Sets: ByObjectParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KdcIP
kdc server IP addresses for the active directory machine.
This optional parameter is used only while creating kerberos volume.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LdapOverTLS
When LDAP over SSL/TLS is enabled, specifies whether or not the LDAP traffic needs to be secured via TLS.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LdapSearchScope
LDAP Search scope options.

```yaml
Type: Microsoft.Azure.Commands.NetAppFiles.Models.PSNetAppFilesLdapSearchScopeOpt
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LdapSigning
When LDAP over SSL/TLS is enabled, Specifies whether or not the LDAP traffic needs to be signed.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizationalUnit
The Organizational Unit (OU) within the Windows Active Directory

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Password
Plain text password of Active Directory domain administrator, value is masked in the response

```yaml
Type: System.Security.SecureString
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreferredServersForLdapClient
Comma separated list of IPv4 addresses of preferred servers for LDAP client. At most two comma separated IPv4 addresses can be passed.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: System.Management.Automation.ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The resource group of the ANF account

```yaml
Type: System.String
Parameter Sets: ByFieldsParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityOperator
Domain Users in the Active directory to be given Security Privilege (Needed for SMB Continuously available shares for SQL). A list of unique usernames without domain specifier

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerRootCACertificate
When LDAP over SSL/TLS is enabled, the LDAP client is required to have base64 encoded Active Directory Certificate Service's self-signed root CA certificate, this optional parameter is used only for dual protocol with LDAP user-mapping volumes.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Site
The Active Directory site the service will limit Domain Controller discovery to

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SmbServerName
NetBIOS name of the SMB server.
This name will be registered as a computer account in the AD and used to mount volumes

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Username
A domain user account with permission to create machine accounts

```yaml
Type: System.String
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

### Microsoft.Azure.Commands.NetAppFiles.Models.PSNetAppFilesAccount

### Microsoft.Azure.Commands.NetAppFiles.Models.PSNetAppFilesActiveDirectory

## OUTPUTS

### Microsoft.Azure.Commands.NetAppFiles.Models.PSNetAppFilesActiveDirectory

## NOTES

## RELATED LINKS

[Get-AzNetAppFilesActiveDirectory](./Get-AzNetAppFilesActiveDirectory.md)
[New-AzNetAppFilesActiveDirectory](./New-AzNetAppFilesActiveDirectory.md)
[Remove-AzNetAppFilesActiveDirectory](./Remove-AzNetAppFilesActiveDirectory.md)
[Get-AzNetAppFilesAccount](./Get-AzNetAppFilesAccount.md)
[New-AzNetAppFilesAccount](./New-AzNetAppFilesAccount.md)
[Remove-AzNetAppFilesAccount](./Remove-AzNetAppFilesAccount.md)
[Set-AzNetAppFilesAccount](./Set-AzNetAppFilesAccount.md)
[Update-AzNetAppFilesAccount](./Update-AzNetAppFilesAccount.md)
