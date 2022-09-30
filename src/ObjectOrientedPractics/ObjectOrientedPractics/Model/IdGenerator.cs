using System;

namespace ObjectOrientedPractics.Model
{
    public class IdGenerator
    {
        public static int GetNextId()
        {
            Random rnd = new();
            int value = rnd.Next(1, 10000);
            return value;
        }
    }
}
