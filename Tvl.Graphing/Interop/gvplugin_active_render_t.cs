﻿namespace Tvl.Graphing.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public unsafe struct gvplugin_active_render_t
    {
        public gvrender_engine_t* engine;
        public int id;
        public gvrender_features_t* features;
        public byte* type;
    }
}
