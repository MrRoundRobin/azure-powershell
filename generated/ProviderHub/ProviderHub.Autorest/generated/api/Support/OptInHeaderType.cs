// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support
{

    public partial struct OptInHeaderType :
        System.IEquatable<OptInHeaderType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType ClientGroupMembership = @"ClientGroupMembership";

        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType NotSpecified = @"NotSpecified";

        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType SignedAuxiliaryTokens = @"SignedAuxiliaryTokens";

        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType SignedUserToken = @"SignedUserToken";

        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType UnboundedClientGroupMembership = @"UnboundedClientGroupMembership";

        /// <summary>the value for an instance of the <see cref="OptInHeaderType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OptInHeaderType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OptInHeaderType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OptInHeaderType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OptInHeaderType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OptInHeaderType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OptInHeaderType && Equals((OptInHeaderType)obj);
        }

        /// <summary>Returns hashCode for enum OptInHeaderType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OptInHeaderType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OptInHeaderType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OptInHeaderType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OptInHeaderType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OptInHeaderType" />.</param>

        public static implicit operator OptInHeaderType(string value)
        {
            return new OptInHeaderType(value);
        }

        /// <summary>Implicit operator to convert OptInHeaderType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OptInHeaderType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OptInHeaderType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType e1, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OptInHeaderType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType e1, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.OptInHeaderType e2)
        {
            return e2.Equals(e1);
        }
    }
}