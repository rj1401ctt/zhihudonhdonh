
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
    public class 主题Repository : BaseRepository<主题>, IRepository<主题, PageData<主题>>
    {
        public 主题Repository(IUnitOfWork _context) : base(_context) { }
    }
}
