using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignaStack
{
    partial class Program
    {
        public class Stack 
        {

            private readonly List<object> _stackList;
                  
            
            public Stack()
            {
                _stackList = new List<object>();      
                
            }            

            //Boxing
            public void Push(object obj)
            {
                if (obj == null)
                    throw new InvalidOperationException("You can not add a null object to the stack.");

                _stackList.Add(obj);
            }

            
            public object Pop()
            {

                if (_stackList.Count == 0)
                    throw new InvalidOperationException("You can not add a null object to the stack.");

                var index = _stackList.Count - 1;
                var toReturn = _stackList[index];

                _stackList.RemoveAt(index);

                return toReturn;
            }

            public void Clear()
            {
                if (_stackList != null)
                {
                    _stackList.Clear();
                }
                
            }
        }
    }
}
