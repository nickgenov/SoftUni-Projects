﻿using System;

namespace DocumentSystem.Structure
{
    [Flags]
    public enum FontStyle
    {
        Normal = 0,
        Bold = 1,
        Italic = 2,
        BoldItalic = Bold | Italic
    }
}
