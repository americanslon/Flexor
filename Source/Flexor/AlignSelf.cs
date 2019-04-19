﻿// <copyright file="AlignSelf.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how an individual flex-item is laid out along the flex-container's cross axis.
    /// </summary>
    public static class AlignSelf
    {
        /// <summary>
        /// The individual item inherits the container's item alignment value.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Auto => new FluentAlignSelf(SelfAlignmentOption.Auto);

        /// <summary>
        /// The individual item is aligned along the start of the flex-container's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Start => new FluentAlignSelf(SelfAlignmentOption.Start);

        /// <summary>
        /// The individual item is aligned along the center of the flex-container's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Center => new FluentAlignSelf(SelfAlignmentOption.Center);

        /// <summary>
        /// The individual item is aligned along the end of the flex-container's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf End => new FluentAlignSelf(SelfAlignmentOption.End);

        /// <summary>
        /// The individual item is stretched along the entirety of the flex-container's cross axis.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Stretch => new FluentAlignSelf(SelfAlignmentOption.Stretch);

        /// <summary>
        /// The individual item is aligned as their baseline is aligned.
        /// The individual item is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignSelf Baseline => new FluentAlignSelf(SelfAlignmentOption.Baseline);

        /// <summary>
        /// The individual item will be rendered and configured with the supplied item alignment.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The default item alignment.</param>
        /// <returns>The item alignment configuration.</returns>
        public static IFluentAlignSelfWithValueOnBreakpoint Is(SelfAlignmentOption value) => new FluentAlignSelf().Is(value);
    }
}