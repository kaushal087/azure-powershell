// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Extensions;

    /// <summary>Emission policy destination properties.</summary>
    public partial class EmissionPolicyDestination :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPolicyDestination,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPolicyDestinationInternal
    {

        /// <summary>Backing field for <see cref="DestinationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.DestinationType? _destinationType;

        /// <summary>Emission destination type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.DestinationType? DestinationType { get => this._destinationType; set => this._destinationType = value; }

        /// <summary>Creates an new <see cref="EmissionPolicyDestination" /> instance.</summary>
        public EmissionPolicyDestination()
        {

        }
    }
    /// Emission policy destination properties.
    public partial interface IEmissionPolicyDestination :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.IJsonSerializable
    {
        /// <summary>Emission destination type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Emission destination type.",
        SerializedName = @"destinationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.DestinationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.DestinationType? DestinationType { get; set; }

    }
    /// Emission policy destination properties.
    internal partial interface IEmissionPolicyDestinationInternal

    {
        /// <summary>Emission destination type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.DestinationType? DestinationType { get; set; }

    }
}