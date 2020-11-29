// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

// <auto-generated />

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SixLabors.ImageSharp.PixelFormats.Utils;

namespace SixLabors.ImageSharp.PixelFormats
{
    /// <content>
    /// Provides optimized overrides for bulk operations.
    /// </content>
    public partial struct Bgra32
    {
        /// <summary>
        /// Provides optimized overrides for bulk operations.
        /// </summary>
        internal partial class PixelOperations : PixelOperations<Bgra32>
        {
                        /// <inheritdoc />
            public override void FromBgra32(Configuration configuration, ReadOnlySpan<Bgra32> source, Span<Bgra32> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(source, destinationPixels, nameof(destinationPixels));

                source.CopyTo(destinationPixels.Slice(0, source.Length));
            }

            /// <inheritdoc />
            public override void ToBgra32(Configuration configuration, ReadOnlySpan<Bgra32> sourcePixels, Span<Bgra32> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                sourcePixels.CopyTo(destinationPixels.Slice(0, sourcePixels.Length));
            }
            /// <inheritdoc />
            public override void FromVector4Destructive(
                Configuration configuration,
                Span<Vector4> sourceVectors,
                Span<Bgra32> destinationPixels,
                PixelConversionModifiers modifiers)
            {
                Vector4Converters.RgbaCompatible.FromVector4(configuration, this, sourceVectors, destinationPixels, modifiers.Remove(PixelConversionModifiers.Scale));
            }

            /// <inheritdoc />
            public override void ToVector4(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<Vector4> destVectors,
                PixelConversionModifiers modifiers)
            {
                Vector4Converters.RgbaCompatible.ToVector4(configuration, this, sourcePixels, destVectors, modifiers.Remove(PixelConversionModifiers.Scale));
            }
            /// <inheritdoc />
            public override void ToRgba32(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<Rgba32> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ReadOnlySpan<byte> source = MemoryMarshal.Cast<Bgra32, byte>(sourcePixels);
                Span<byte> dest = MemoryMarshal.Cast<Rgba32, byte>(destinationPixels);
                PixelConverter.FromBgra32.ToRgba32(source, dest);
            }

            /// <inheritdoc />
            public override void FromRgba32(
                Configuration configuration,
                ReadOnlySpan<Rgba32> sourcePixels,
                Span<Bgra32> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ReadOnlySpan<byte> source = MemoryMarshal.Cast<Rgba32, byte>(sourcePixels);
                Span<byte> dest = MemoryMarshal.Cast<Bgra32, byte>(destinationPixels);
                PixelConverter.FromRgba32.ToBgra32(source, dest);
            }
            /// <inheritdoc />
            public override void ToArgb32(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<Argb32> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ReadOnlySpan<byte> source = MemoryMarshal.Cast<Bgra32, byte>(sourcePixels);
                Span<byte> dest = MemoryMarshal.Cast<Argb32, byte>(destinationPixels);
                PixelConverter.FromBgra32.ToArgb32(source, dest);
            }

            /// <inheritdoc />
            public override void FromArgb32(
                Configuration configuration,
                ReadOnlySpan<Argb32> sourcePixels,
                Span<Bgra32> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ReadOnlySpan<byte> source = MemoryMarshal.Cast<Argb32, byte>(sourcePixels);
                Span<byte> dest = MemoryMarshal.Cast<Bgra32, byte>(destinationPixels);
                PixelConverter.FromArgb32.ToBgra32(source, dest);
            }
            /// <inheritdoc />
            public override void ToRgb24(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<Rgb24> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ReadOnlySpan<byte> source = MemoryMarshal.Cast<Bgra32, byte>(sourcePixels);
                Span<byte> dest = MemoryMarshal.Cast<Rgb24, byte>(destinationPixels);
                PixelConverter.FromBgra32.ToRgb24(source, dest);
            }

            /// <inheritdoc />
            public override void FromRgb24(
                Configuration configuration,
                ReadOnlySpan<Rgb24> sourcePixels,
                Span<Bgra32> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ReadOnlySpan<byte> source = MemoryMarshal.Cast<Rgb24, byte>(sourcePixels);
                Span<byte> dest = MemoryMarshal.Cast<Bgra32, byte>(destinationPixels);
                PixelConverter.FromRgb24.ToBgra32(source, dest);
            }
            /// <inheritdoc />
            public override void ToBgr24(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<Bgr24> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ReadOnlySpan<byte> source = MemoryMarshal.Cast<Bgra32, byte>(sourcePixels);
                Span<byte> dest = MemoryMarshal.Cast<Bgr24, byte>(destinationPixels);
                PixelConverter.FromBgra32.ToBgr24(source, dest);
            }

            /// <inheritdoc />
            public override void FromBgr24(
                Configuration configuration,
                ReadOnlySpan<Bgr24> sourcePixels,
                Span<Bgra32> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ReadOnlySpan<byte> source = MemoryMarshal.Cast<Bgr24, byte>(sourcePixels);
                Span<byte> dest = MemoryMarshal.Cast<Bgra32, byte>(destinationPixels);
                PixelConverter.FromBgr24.ToBgra32(source, dest);
            }
            /// <inheritdoc />
            public override void ToL8(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<L8> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref L8 destRef = ref MemoryMarshal.GetReference(destinationPixels);

                for (int i = 0; i < sourcePixels.Length; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref L8 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
            /// <inheritdoc />
            public override void ToL16(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<L16> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref L16 destRef = ref MemoryMarshal.GetReference(destinationPixels);

                for (int i = 0; i < sourcePixels.Length; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref L16 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
            /// <inheritdoc />
            public override void ToLa16(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<La16> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref La16 destRef = ref MemoryMarshal.GetReference(destinationPixels);

                for (int i = 0; i < sourcePixels.Length; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref La16 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
            /// <inheritdoc />
            public override void ToLa32(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<La32> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref La32 destRef = ref MemoryMarshal.GetReference(destinationPixels);

                for (int i = 0; i < sourcePixels.Length; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref La32 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
            /// <inheritdoc />
            public override void ToRgb48(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<Rgb48> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgb48 destRef = ref MemoryMarshal.GetReference(destinationPixels);

                for (int i = 0; i < sourcePixels.Length; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgb48 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
            /// <inheritdoc />
            public override void ToRgba64(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<Rgba64> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgba64 destRef = ref MemoryMarshal.GetReference(destinationPixels);

                for (int i = 0; i < sourcePixels.Length; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgba64 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
            /// <inheritdoc />
            public override void ToBgra5551(
                Configuration configuration,
                ReadOnlySpan<Bgra32> sourcePixels,
                Span<Bgra5551> destinationPixels)
            {
                Guard.NotNull(configuration, nameof(configuration));
                Guard.DestinationShouldNotBeTooShort(sourcePixels, destinationPixels, nameof(destinationPixels));

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Bgra5551 destRef = ref MemoryMarshal.GetReference(destinationPixels);

                for (int i = 0; i < sourcePixels.Length; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Bgra5551 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
            /// <inheritdoc />
            public override void From<TSourcePixel>(
                Configuration configuration,
                ReadOnlySpan<TSourcePixel> sourcePixels,
                Span<Bgra32> destinationPixels)
            {
                PixelOperations<TSourcePixel>.Instance.ToBgra32(configuration, sourcePixels, destinationPixels.Slice(0, sourcePixels.Length));
            }

        }
    }
}
