using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListExtensions
{
    public static class ListExtensions
    {
        public static int LastIndex<T>(this List<T> list) => list.Count - 1;

        public static T Last<T>(this List<T> list) => list.Count > 0 ? list[list.LastIndex()] : default(T);

        public static T Pop<T>(this List<T> list)
        {
            var popped = list.Last();
            if (list.Count > 0)
            {
                list.RemoveAt(list.LastIndex());
            }
            return popped;
        }
    }
}
