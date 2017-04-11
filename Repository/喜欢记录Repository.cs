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
    public class 喜欢记录Repository : BaseRepository<喜欢记录>, IRepository<喜欢记录, PageData<喜欢记录>>
    {
        public 喜欢记录Repository(IUnitOfWork _context) : base(_context) { }
    }
}
