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
    public class 广告轮播Repository : BaseRepository<广告轮播>, IRepository<广告轮播, PageData<广告轮播>>
    {
        public 广告轮播Repository(IUnitOfWork _context) : base(_context) { }
    }
}
