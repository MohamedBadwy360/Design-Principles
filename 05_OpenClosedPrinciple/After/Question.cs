﻿namespace _05_OpenClosedPrinciple.After
{
    public abstract class Question
    {
        public string Title { get; set; }

        public int Mark { get; set; }
        public abstract void Print();
    }
}
