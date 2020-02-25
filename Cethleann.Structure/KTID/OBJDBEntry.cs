﻿using Cethleann.Structure.Resource;

namespace Cethleann.Structure.KTID
{
    public struct OBJDBEntry
    {
        public ResourceSectionHeader SectionHeader { get; set; }
        public KTIDReference KTID { get; set; }
        public KTIDReference TypeInfoKTID { get; set; }
        public int Count { get; set; }
        public int Version { get; set; }
    }
}
