using System;

namespace Singleton
{
    public class Singleton
    {
        // statichna promenliva obrashtame se s imeto na klasa
        private static Singleton instance;
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
