// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>OneLake artifact (data source) configuration.</summary>
    public partial class OneLakeArtifact :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IOneLakeArtifact,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IOneLakeArtifactInternal
    {

        /// <summary>Backing field for <see cref="ArtifactName" /> property.</summary>
        private string _artifactName;

        /// <summary>[Required] OneLake artifact name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ArtifactName { get => this._artifactName; set => this._artifactName = value; }

        /// <summary>Backing field for <see cref="ArtifactType" /> property.</summary>
        private string _artifactType= @"LakeHouse";

        /// <summary>[Required] OneLake artifact type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ArtifactType { get => this._artifactType; }

        /// <summary>Internal Acessors for ArtifactType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IOneLakeArtifactInternal.ArtifactType { get => this._artifactType; set { {_artifactType = value;} } }

        /// <summary>Creates an new <see cref="OneLakeArtifact" /> instance.</summary>
        public OneLakeArtifact()
        {

        }
    }
    /// OneLake artifact (data source) configuration.
    public partial interface IOneLakeArtifact :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>[Required] OneLake artifact name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] OneLake artifact name",
        SerializedName = @"artifactName",
        PossibleTypes = new [] { typeof(string) })]
        string ArtifactName { get; set; }
        /// <summary>[Required] OneLake artifact type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"[Required] OneLake artifact type",
        SerializedName = @"artifactType",
        PossibleTypes = new [] { typeof(string) })]
        string ArtifactType { get;  }

    }
    /// OneLake artifact (data source) configuration.
    internal partial interface IOneLakeArtifactInternal

    {
        /// <summary>[Required] OneLake artifact name</summary>
        string ArtifactName { get; set; }
        /// <summary>[Required] OneLake artifact type</summary>
        string ArtifactType { get; set; }

    }
}