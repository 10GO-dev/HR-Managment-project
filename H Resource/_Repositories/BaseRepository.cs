using H_Resource.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource._Repositories
{
    public abstract class BaseRepository
    {
        protected static HrmsDbContext DbContext = new HrmsDbContext();
        protected string ConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
    }
}
