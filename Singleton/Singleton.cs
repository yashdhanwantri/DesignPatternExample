namespace DesignPatternExample.Singleton
{
    // Sealed to make it non-inheritable.
    public sealed class Singleton
    {
        // Private static property holding the instance of class.
        private static Singleton _instance;

        // Private constructor to avoid making instance of the class outside of it.
        private Singleton()
        {

        }

        // Static accessor to get the instance.
        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
