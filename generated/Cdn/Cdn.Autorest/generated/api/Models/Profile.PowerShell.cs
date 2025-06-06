// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>A profile is a logical grouping of endpoints that share the same settings.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProfileTypeConverter))]
    public partial class Profile
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Profile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Profile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Profile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Profile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Profile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Profile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Profile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Profile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ProfilePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogScrubbing"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbing = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileLogScrubbing) content.GetValueForProperty("LogScrubbing",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbing, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ProfileLogScrubbingTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ResourceState = (string) content.GetValueForProperty("ResourceState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ResourceState, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ExtendedProperty = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfilePropertiesExtendedProperties) content.GetValueForProperty("ExtendedProperty",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ExtendedProperty, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ProfilePropertiesExtendedPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("FrontDoorId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).FrontDoorId = (string) content.GetValueForProperty("FrontDoorId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).FrontDoorId, global::System.Convert.ToString);
            }
            if (content.Contains("OriginResponseTimeoutSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).OriginResponseTimeoutSecond = (int?) content.GetValueForProperty("OriginResponseTimeoutSecond",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).OriginResponseTimeoutSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LogScrubbingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbingState = (string) content.GetValueForProperty("LogScrubbingState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbingState, global::System.Convert.ToString);
            }
            if (content.Contains("LogScrubbingRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbingRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileScrubbingRules>) content.GetValueForProperty("LogScrubbingRule",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbingRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileScrubbingRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ProfileScrubbingRulesTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Profile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Profile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ProfilePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogScrubbing"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbing = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileLogScrubbing) content.GetValueForProperty("LogScrubbing",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbing, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ProfileLogScrubbingTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ResourceState = (string) content.GetValueForProperty("ResourceState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ResourceState, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ExtendedProperty = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfilePropertiesExtendedProperties) content.GetValueForProperty("ExtendedProperty",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).ExtendedProperty, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ProfilePropertiesExtendedPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("FrontDoorId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).FrontDoorId = (string) content.GetValueForProperty("FrontDoorId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).FrontDoorId, global::System.Convert.ToString);
            }
            if (content.Contains("OriginResponseTimeoutSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).OriginResponseTimeoutSecond = (int?) content.GetValueForProperty("OriginResponseTimeoutSecond",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).OriginResponseTimeoutSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LogScrubbingState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbingState = (string) content.GetValueForProperty("LogScrubbingState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbingState, global::System.Convert.ToString);
            }
            if (content.Contains("LogScrubbingRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbingRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileScrubbingRules>) content.GetValueForProperty("LogScrubbingRule",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileInternal)this).LogScrubbingRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileScrubbingRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ProfileScrubbingRulesTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// A profile is a logical grouping of endpoints that share the same settings.
    [System.ComponentModel.TypeConverter(typeof(ProfileTypeConverter))]
    public partial interface IProfile

    {

    }
}