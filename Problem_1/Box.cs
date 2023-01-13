using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_2
{
    public class Box<T>
    {
        public T value { get; set; }
        public Box(T value)
        {
            this.value = value;
        }

        public void InrOut(T elemnt)
        {
            this.value = elemnt;
            this.ToString();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"{(typeof(T)).FullName}: {this.value}"));
            return stringBuilder.ToString();
        }
    }
}
