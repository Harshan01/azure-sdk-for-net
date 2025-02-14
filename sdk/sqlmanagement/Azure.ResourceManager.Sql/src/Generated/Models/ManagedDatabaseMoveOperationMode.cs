// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The move operation mode. </summary>
    public readonly partial struct ManagedDatabaseMoveOperationMode : IEquatable<ManagedDatabaseMoveOperationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedDatabaseMoveOperationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedDatabaseMoveOperationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MoveValue = "Move";
        private const string CopyValue = "Copy";

        /// <summary> Move. </summary>
        public static ManagedDatabaseMoveOperationMode Move { get; } = new ManagedDatabaseMoveOperationMode(MoveValue);
        /// <summary> Copy. </summary>
        public static ManagedDatabaseMoveOperationMode Copy { get; } = new ManagedDatabaseMoveOperationMode(CopyValue);
        /// <summary> Determines if two <see cref="ManagedDatabaseMoveOperationMode"/> values are the same. </summary>
        public static bool operator ==(ManagedDatabaseMoveOperationMode left, ManagedDatabaseMoveOperationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedDatabaseMoveOperationMode"/> values are not the same. </summary>
        public static bool operator !=(ManagedDatabaseMoveOperationMode left, ManagedDatabaseMoveOperationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedDatabaseMoveOperationMode"/>. </summary>
        public static implicit operator ManagedDatabaseMoveOperationMode(string value) => new ManagedDatabaseMoveOperationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedDatabaseMoveOperationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedDatabaseMoveOperationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
