using System;

namespace ObjectOrientedPractics.Services
{
    public class IdGenerator
    {
        private static int _id = 0;
        public static int GetNextId()
        {
            _id++;
            return _id;
        }
    }
}
