﻿using SharpDX;
using System.ComponentModel;

namespace HeroesPowerPlant.LayoutEditor
{
    public enum RainbowType : short
    {
        Speed = 0,
        FlyA = 1,
        FlyB = 2,
        PowerS = 3,
        PowerL = 4
    }

    public class Object000D_BigRings : SetObjectHeroes
    {
        public override void CreateTransformMatrix()
        {
            transformMatrix = DefaultTransformMatrix(MathUtil.Pi);
            CreateBoundingBox();
        }

        public RainbowType RainbowType
        {
            get => (RainbowType)ReadShort(4);
            set => Write(4, (short)value);
        }

        [Description("In frames")]
        public short AdditionalControlTime
        {
            get => ReadShort(6);
            set => Write(6, value);
        }

        [Description("Defaults to 5.0")]
        public float Speed
        {
            get => ReadFloat(8);
            set => Write(8, value);
        }

        public float Offset
        {
            get => ReadFloat(12);
            set => Write(12, value);
        }
    }
}