using System;

namespace DesignPatterns
{
    class Disposable : IDisposable
    {
        private object _someManagedObject;
        private bool _disposed;

        public Disposable()
        {
            _someManagedObject = new object();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // release managed resources.
                    if (_someManagedObject != null)
                    {
                        // release logic
                    }
                }

                // Free unmanaged resources (would normally be taken care of by OS)
                // Nothing unmanaged to free in this example.

                _disposed = true;
            }
        }

        public void Dispose() // called via "using (var disp = new Disposable())" pattern
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Disposable() // called by finalizer
        {
            Dispose(false);
        }
    }
}
