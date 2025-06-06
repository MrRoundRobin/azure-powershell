// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties to validate a domain.</summary>
    public partial class DomainValidationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDomainValidationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDomainValidationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ExpirationDate" /> property.</summary>
        private string _expirationDate;

        /// <summary>The date time that the token expires</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string ExpirationDate { get => this._expirationDate; }

        /// <summary>Internal Acessors for ExpirationDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDomainValidationPropertiesInternal.ExpirationDate { get => this._expirationDate; set { {_expirationDate = value;} } }

        /// <summary>Internal Acessors for ValidationToken</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDomainValidationPropertiesInternal.ValidationToken { get => this._validationToken; set { {_validationToken = value;} } }

        /// <summary>Backing field for <see cref="ValidationToken" /> property.</summary>
        private string _validationToken;

        /// <summary>Challenge used for DNS TXT record or file based validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string ValidationToken { get => this._validationToken; }

        /// <summary>Creates an new <see cref="DomainValidationProperties" /> instance.</summary>
        public DomainValidationProperties()
        {

        }
    }
    /// The JSON object that contains the properties to validate a domain.
    public partial interface IDomainValidationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>The date time that the token expires</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The date time that the token expires",
        SerializedName = @"expirationDate",
        PossibleTypes = new [] { typeof(string) })]
        string ExpirationDate { get;  }
        /// <summary>Challenge used for DNS TXT record or file based validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Challenge used for DNS TXT record or file based validation",
        SerializedName = @"validationToken",
        PossibleTypes = new [] { typeof(string) })]
        string ValidationToken { get;  }

    }
    /// The JSON object that contains the properties to validate a domain.
    internal partial interface IDomainValidationPropertiesInternal

    {
        /// <summary>The date time that the token expires</summary>
        string ExpirationDate { get; set; }
        /// <summary>Challenge used for DNS TXT record or file based validation</summary>
        string ValidationToken { get; set; }

    }
}