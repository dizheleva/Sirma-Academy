namespace _01.JarOfT
{
    using System;
    using System.Collections.Generic;

    public class Jar<T>
    {
        private readonly Stack<T> content = new();

        public void Add(T entity)
        {
            content.Push(entity);
        }

        public T Remove()
        {
            if (content.Count == 0)
            {
                throw new InvalidOperationException("The jar is empty.");
            }

            return content.Pop();
        }
    }
}
