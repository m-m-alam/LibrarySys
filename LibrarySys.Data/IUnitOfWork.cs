using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySys.Data
{
    public interface IUnitOfWork: IDisposable
    {
        void Save();
    }
}
