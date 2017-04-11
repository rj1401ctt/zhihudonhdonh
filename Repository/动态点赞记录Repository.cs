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
    public class 动态点赞记录Repository : BaseRepository<动态点赞记录>, IRepository<动态点赞记录, PageData<动态点赞记录>>
    {
        public 动态点赞记录Repository(IUnitOfWork _context) : base(_context) { }
    }
}
