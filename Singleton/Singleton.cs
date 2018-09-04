using System;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private Singleton()
        {
            this.Value = DateTime.Now.Millisecond.ToString();            
        }

        public string Value {get; set;}

        private static Singleton instance;
        public static Singleton Instance
        {
            get 
            {                
                if(instance == null)
                    instance = new Singleton();

                return instance;
            }
        }
    }
}