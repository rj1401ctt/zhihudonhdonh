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
    public class 动态附件Repository : BaseRepository<动态附件>, IRepository<动态附件, PageData<动态附件>>
    {
        public 动态附件Repository(IUnitOfWork _context) : base(_context) { }
    }
}
