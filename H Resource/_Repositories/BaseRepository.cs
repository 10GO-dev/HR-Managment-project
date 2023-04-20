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
        //protected string ConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        protected string ConnectionString = "Server = tcp:hresource.database.windows.net, 1433; Initial Catalog = HRMS_db; Persist Security Info = False; User ID = hradmin; Password = Hr3s0urc3s; MultipleActiveResultSets = True; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
    }
}
