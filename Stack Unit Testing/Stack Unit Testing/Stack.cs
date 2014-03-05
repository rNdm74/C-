using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack_Unit_Testing
{
    class Stack<T>
    {
        private readonly int m_Size;
        private int m_StackPointer = 0;
        private T[] m_Items;

        public Stack(int size) 
        {
            m_Size = size;
            m_Items = new T[m_Size];
        }

        public void Push(T item)
        {
            // Check is stack is full
            if (m_StackPointer >= m_Size)
                throw new StackOverflowException();
            
            // Add item to stack
            m_Items[m_StackPointer] = item;
            // Move pointer to next available position in stack
            m_StackPointer++;
        }

        public T Pop()
        {
            // Point to last added item in stack
            m_StackPointer--;
                        
            if (m_StackPointer >= 0) // Stack has items
            {
                // Copy item to temp
                T m_MostRecentItem = m_Items[m_StackPointer]; 
                // Remove item from stack
                m_Items[m_StackPointer] = default(T);
                // Return last added item in stack
                return m_MostRecentItem;
            }
            else // Stack empty : m_StackPointer = -1
            {
                m_StackPointer = 0;
                // Returns the default value of a type
                return default(T);
            }
        }

        public T Peek()
        {
            // Point to last added item in stack
            m_StackPointer--;

            if (m_StackPointer >= 0) // Stack has items
            {
                // Return last added item in stack
                return m_Items[m_StackPointer];
            }
            else // Stack empty : m_StackPointer = -1
            {
                m_StackPointer = 0;
                // Returns the default value of a type
                return default(T);
            }
        }

        public int Count()
        {
            int m_Count = 0;

            // Count all items in stack
            while (m_Count < m_Items.Length && m_Items[m_Count] != null)
                m_Count++;

            return m_Count;
        }
        
        public bool IsEmpty()
        {
            // This doesnt feel right
            return m_StackPointer == 0;
        }
    }
}
