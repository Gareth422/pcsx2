﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GSDumpGUI
{
    public class GIFTag
    {
        public Int32 nloop;
        public Int32 eop;
        public Int32 _pad1;
        public Int32 _pad2;
        public Int32 pre;
        public GIFPrim prim;
        public Int32 flg;
        public Int32 nreg;
        public List<GIFReg> regs;
    }

    public class GIFPrim
    {
        public Int32 Prim;
        public Int32 IIP;
        public Int32 TME;
        public Int32 FGE;
        public Int32 ABE;
        public Int32 AA1;
        public Int32 FST;
        public Int32 CTXT;
        public Int32 FIX;
    }

    public class GIFReg
    {
        public GIFRegDescriptor Descriptor;
    }

    public enum GIFRegDescriptor
    {
        PRIM = 0,
        RGBAQ = 1,
        ST = 2,
        UV = 3,
        XYZF2 = 4,
        XYZ2 = 5,
        TEX0_1 = 6,
        TEX0_2 = 7,
        CLAMP_1 = 8,
        CLAMP_2 = 9,
        FOG = 10,
        Reserved = 11,
        XYZF3 = 12,
        XYZ3 = 13,
        AD = 14,
        NOP = 15
    }

    public enum GIFFLG
    {
        GIF_FLG_PACKED =0,
        GIF_FLG_REGLIST =1,
        GIF_FLG_IMAGE = 2,
        GIF_FLG_IMAGE2 = 3
    }

    public enum GS_PRIM
    {
        GS_POINTLIST = 0,
        GS_LINELIST = 1,
        GS_LINESTRIP = 2,
        GS_TRIANGLELIST = 3,
        GS_TRIANGLESTRIP = 4,
        GS_TRIANGLEFAN = 5,
        GS_SPRITE = 6,
        GS_INVALID = 7,
    }
}