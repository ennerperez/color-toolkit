﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Pictograms;

namespace Toolkit
{
    internal static partial class Program
    {
        internal static MaterialDesign.IconType Icon => MaterialDesign.IconType.color_lens;

        internal static List<string> Formats => new List<string>(new[] { ".bmp", ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".gif" });
        internal static List<string> Palettes => new List<string>(new[] { ".ase", ".aco" });

        internal static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            Error = new EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>((object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args) =>
            {
                args.ErrorContext.Handled = true;
            })
        };

        internal static void Initialize()
        {
#if DEBUG
            ImageHelper.GetEditorIcon(MaterialDesign.GetImage(Program.Icon, 256, Color.White));
#endif
        }
    }
}