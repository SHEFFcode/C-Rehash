using System;

namespace CollectionsVsArrays
{
    public class UnderstadingIDisposable
    {
        public void Run()
        {
            //managed objects: they are in the CLR, automatically cleaned up by the gargbage collection functionality.
            //unmanaged objects: non CRL objects, we have to manually clean this up
            //IDisposable requires void Dispose(); only when using unmanaged resources. Introduces inefficiencies



        }
    }

    public class DisposableClass : IDisposable
    {
        private bool _disposed = false; // this is set to false by default.
        public void Dispose() // we will call this.
        {
            Dispose(true);
            GC.SuppressFinalize(this); // if it gets here, means disposed was true, the SupressFinalize would not be called, and the object would 
        }

        ~DisposableClass()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                //Free managed objects that implement IDisposable
            }

            //Release unamanged objects

            _disposed = true;
        }
    }
}