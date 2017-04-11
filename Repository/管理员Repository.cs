using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using WZVTC.SoftDev.DDDFW.Domain.Core;
using WZVTC.SoftDev.DDDFW.Global;
using WZVTC.SoftDev.DDDFW.Repository;

namespace Repository
{
    public class 管理员Repository : BaseRepository<管理员>, IRepository<管理员, PageData<管理员>>
    {
        public 管理员Repository(IUnitOfWork _context) : base(_context) { }
    }
}
