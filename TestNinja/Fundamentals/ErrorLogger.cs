
using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        private Guid _guid;

        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged; 
        
        public void Log(string error)
        {
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();
                
            LastError = error; 
            
            // Write the log to a storage
            // ...

            _guid = Guid.NewGuid();
            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}