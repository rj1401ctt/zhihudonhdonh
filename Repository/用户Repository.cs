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
    public class 用户Repository : BaseRepository<用户>, IRepository<用户, PageData<用户>>
    {
        public 用户Repository(IUnitOfWork _context) : base(_context) { }
    }
}
