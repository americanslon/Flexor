﻿// <copyright file="Enums.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    public enum FlexDirection
    {
        Row,

        Column,

        RowReverse,

        ColumnReverse,
    }

    public enum SpanAxisAlignment
    {
        Start,

        Center,

        End,

        SpaceAround,

        SpaceBetween,

        SpaceEvenly,
    }

    public enum ItemAxisAlignment
    {
        Start,

        Center,

        End,

        Stretch,

        Baseline,
    }

    public enum Breakpoint
    {
        None,

        Mobile,

        Tablet,

        Desktop,

        Widescreen,

        FullHD,
    }
}
