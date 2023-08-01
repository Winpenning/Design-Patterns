namespace Singleton.Entities
{
    public class Counter
    {
        private int Numero { get; set; }

        private static Counter instance;
        private Counter() {}
        public void Increment()
        {
            Numero++;
        }
        public int GetCount()
        {
            return Numero;
        }

        public static Counter getInstance()
        {
            if (instance == null)
            {
                instance = new Counter();
            }
            else
            {

            }
            return instance;
        }



    }
}
