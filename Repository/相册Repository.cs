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
    public class 相册Repository : BaseRepository<相册>, IRepository<相册, PageData<相册>>
    {
        public 相册Repository(IUnitOfWork _context) : base(_context) { }
    }
}
