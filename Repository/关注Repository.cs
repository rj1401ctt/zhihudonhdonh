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
    public class 关注Repository : BaseRepository<关注>, IRepository<关注, PageData<关注>>
    {
        public 关注Repository(IUnitOfWork _context) : base(_context) { }
    }
}
