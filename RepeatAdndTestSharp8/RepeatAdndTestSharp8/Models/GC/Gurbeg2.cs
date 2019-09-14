using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models.GC
{
    public class Gurbeg2 : IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                if (disposed)
                {

                }
                disposed = true;
            }
        }

        ~Gurbeg2()
        {
            Dispose(false);
        }


    }
}
