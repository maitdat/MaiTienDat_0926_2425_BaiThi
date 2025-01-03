using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaiTienDat_0926_2425_BaiThi.Models;

namespace MaiTienDat_0926_2425_BaiThi.Data
{
    public class MaiTienDat_0926_2425_BaiThiContext : DbContext
    {
        public MaiTienDat_0926_2425_BaiThiContext (DbContextOptions<MaiTienDat_0926_2425_BaiThiContext> options)
            : base(options)
        {
        }

        public DbSet<MaiTienDat_0926_2425_BaiThi.Models.Student> Student { get; set; } = default!;
    }
}
