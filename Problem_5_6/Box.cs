using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5_6
{
    public class Box<T> where T : IComparable<T>
    {

        public T value { get; set; }
        public Box(T value)
        {
            this.value = value;
        }
        
        public bool CompareTo(T other)
        {
            if(this.value.CompareTo(other) > 0) return true;
            else if(this.value.CompareTo(other) < 0) return false;
            else return false;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"{(typeof(T)).FullName}: {this.value}"));
            return stringBuilder.ToString();
        }
    }
}
