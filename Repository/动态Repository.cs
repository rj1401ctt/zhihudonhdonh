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
    public class 动态Repository : BaseRepository<动态>, IRepository<动态, PageData<动态>>
    {
        public 动态Repository(IUnitOfWork _context) : base(_context) { }
    }
}
