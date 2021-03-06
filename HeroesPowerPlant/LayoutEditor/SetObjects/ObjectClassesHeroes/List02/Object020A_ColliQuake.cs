﻿namespace HeroesPowerPlant.LayoutEditor
{
    public class Object020A_ColliQuake : SetObjectHeroes
    {
        public float ScaleX
        {
            get => ReadFloat(4);
            set => Write(4, value);
        }

        public float ScaleY
        {
            get => ReadFloat(8);
            set => Write(8, value);
        }

        public float ScaleZ
        {
            get => ReadFloat(12);
            set => Write(12, value);
        }

        public float Strength
        {
            get => ReadFloat(16);
            set => Write(16, value);
        }

        public int Time
        {
            get => ReadInt(20);
            set => Write(20, value);
        }
    }
}
