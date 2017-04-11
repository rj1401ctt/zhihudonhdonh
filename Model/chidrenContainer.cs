using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZVTC.SoftDev.DDDFW.Domain.Core;

namespace Model
{
    public partial class chidrenContainer : IUnitOfWork
    {
        int IUnitOfWork.Commit()
        {
            return this.SaveChanges();
        }
        void IUnitOfWork.CommitAndRefreshChanges()
        {
            throw new NotImplementedException();
        }
        void IUnitOfWork.RollbackChanges()
        {
            throw new NotImplementedException();
        }
        void IDisposable.Dispose()
        {
            // throw new NotImplementedException();
        }
    }
}
