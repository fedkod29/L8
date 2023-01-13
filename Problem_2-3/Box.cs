using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3_4
{
    public class Box<T>
    {

        public T value { get; }
        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"{(typeof(T)).FullName}: {this.value}"));
            return stringBuilder.ToString();
        }
    }
}
