// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Target lags selection modes.
    /// Serialized Name: TargetLagsMode
    /// </summary>
    internal readonly partial struct TargetLagsMode : IEquatable<TargetLagsMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TargetLagsMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetLagsMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "Auto";
        private const string CustomValue = "Custom";

        /// <summary>
        /// Target lags to be determined automatically.
        /// Serialized Name: TargetLagsMode.Auto
        /// </summary>
        public static TargetLagsMode Auto { get; } = new TargetLagsMode(AutoValue);
        /// <summary>
        /// Use the custom target lags.
        /// Serialized Name: TargetLagsMode.Custom
        /// </summary>
        public static TargetLagsMode Custom { get; } = new TargetLagsMode(CustomValue);
        /// <summary> Determines if two <see cref="TargetLagsMode"/> values are the same. </summary>
        public static bool operator ==(TargetLagsMode left, TargetLagsMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetLagsMode"/> values are not the same. </summary>
        public static bool operator !=(TargetLagsMode left, TargetLagsMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TargetLagsMode"/>. </summary>
        public static implicit operator TargetLagsMode(string value) => new TargetLagsMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetLagsMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetLagsMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
