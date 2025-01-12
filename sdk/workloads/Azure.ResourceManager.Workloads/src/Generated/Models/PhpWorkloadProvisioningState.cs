// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Php workload resource provisioning state. </summary>
    public readonly partial struct PhpWorkloadProvisioningState : IEquatable<PhpWorkloadProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PhpWorkloadProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PhpWorkloadProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string AcceptedValue = "Accepted";
        private const string CreatedValue = "Created";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ProvisioningValue = "Provisioning";
        private const string DeletingValue = "Deleting";

        /// <summary> NotSpecified. </summary>
        public static PhpWorkloadProvisioningState NotSpecified { get; } = new PhpWorkloadProvisioningState(NotSpecifiedValue);
        /// <summary> Accepted. </summary>
        public static PhpWorkloadProvisioningState Accepted { get; } = new PhpWorkloadProvisioningState(AcceptedValue);
        /// <summary> Created. </summary>
        public static PhpWorkloadProvisioningState Created { get; } = new PhpWorkloadProvisioningState(CreatedValue);
        /// <summary> Succeeded. </summary>
        public static PhpWorkloadProvisioningState Succeeded { get; } = new PhpWorkloadProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static PhpWorkloadProvisioningState Failed { get; } = new PhpWorkloadProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static PhpWorkloadProvisioningState Canceled { get; } = new PhpWorkloadProvisioningState(CanceledValue);
        /// <summary> Provisioning. </summary>
        public static PhpWorkloadProvisioningState Provisioning { get; } = new PhpWorkloadProvisioningState(ProvisioningValue);
        /// <summary> Deleting. </summary>
        public static PhpWorkloadProvisioningState Deleting { get; } = new PhpWorkloadProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="PhpWorkloadProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PhpWorkloadProvisioningState left, PhpWorkloadProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PhpWorkloadProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PhpWorkloadProvisioningState left, PhpWorkloadProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PhpWorkloadProvisioningState"/>. </summary>
        public static implicit operator PhpWorkloadProvisioningState(string value) => new PhpWorkloadProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PhpWorkloadProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PhpWorkloadProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
