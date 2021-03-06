﻿using SharpDX;
using System.ComponentModel;

namespace HeroesPowerPlant.LayoutEditor
{
    public enum WeightType
    {
        Repeat = 0,
        Shadow = 1,
        Laser = 2,
        RepeatSwitch = 3,
        ShadowSwitch = 4,
        LaserSwitch = 5
    }

    public class Object00_Weight : SetObjectHeroes
    {
        public override void CreateTransformMatrix()
        {
            transformMatrix = Matrix.Scaling(ScaleX, ScaleY, ScaleZ) * DefaultTransformMatrix();

            CreateBoundingBox();
        }

        public WeightType WeightType
        {
            get => (WeightType)ReadByte(4);
            set => Write(4, (byte)value);
        }

        public byte LinkID
        {
            get => ReadByte(5);
            set => Write(5, value);
        }

        public short Height
        {
            get => ReadShort(6);
            set => Write(6, value);
        }

        public float ScaleX
        {
            get => ReadFloat(8);
            set => Write(8, value);
        }

        public float ScaleY
        {
            get => ReadFloat(20);
            set => Write(20, value);
        }

        public float ScaleZ
        {
            get => ReadFloat(12);
            set => Write(12, value);
        }

        [Description("In frames")]
        public short UpWaitTime
        {
            get => ReadShort(16);
            set => Write(16, value);
        }

        [Description("In frames")]
        public short DownWaitTime
        {
            get => ReadShort(18);
            set => Write(18, value);
        }
    }
}