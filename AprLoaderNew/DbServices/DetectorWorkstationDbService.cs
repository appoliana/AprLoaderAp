using AprLoaderNew.APR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AprLoader.Core.DbServices
{
    class DetectorWorkstationDbService : IBasicDbService<DetectorWorkstation>
    {
        public event Action<object, Exception> ExceptionRaised;

        public bool Add(DetectorWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    // Рассчитываем макс id самостоятельно, т.к. в БД id не выставлен как PK, там вообще не PK
                    int id = context.DetectorWorkstations.Max(x => x.Id) + 1;

                    var sb = new StringBuilder();
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation ON;");
                    sb.Append($"Insert into DetectorWorkstation(Id, LogicalWorkstationId, DetectorId) values ({id}, {obj.LogicalWorkstationId}, {obj.DetectorId});");
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation OFF;");

                    context.Database.ExecuteSqlRaw(sb.ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }

        public async Task<bool> AddAsync(DetectorWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    // Рассчитываем макс id самостоятельно, т.к. в БД id не выставлен как PK, там вообще не PK
                    int id = context.DetectorWorkstations.Max(x => x.Id) + 1;

                    var sb = new StringBuilder();
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation ON;");
                    sb.Append($"Insert into DetectorWorkstation(Id, LogicalWorkstationId, DetectorId) values ({id}, {obj.LogicalWorkstationId}, {obj.DetectorId});");
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation OFF;");

                    await context.Database.ExecuteSqlRawAsync(sb.ToString());

                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }

        public DetectorWorkstation[] GetAsArray()
        {
            using (APRContext context = new APRContext())
            {
                return context.DetectorWorkstations.ToArray();
            }
        }

        public async Task<DetectorWorkstation[]> GetAsArrayAsync()
        {
            using (APRContext context = new APRContext())
            {
                return await context.DetectorWorkstations.ToArrayAsync();
            }
        }

        public bool Remove(DetectorWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var sb = new StringBuilder();
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation ON;");
                    sb.Append($"DELETE FROM DetectorWorkstation WHERE Id = {obj.Id};");
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation OFF;");

                    context.Database.ExecuteSqlRaw(sb.ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }

        public async Task<bool> RemoveAsync(DetectorWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var sb = new StringBuilder();
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation ON;");
                    sb.Append($"DELETE FROM DetectorWorkstation WHERE Id = {obj.Id};");
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation OFF;");

                    await context.Database.ExecuteSqlRawAsync(sb.ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }

        public bool Update(DetectorWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var sb = new StringBuilder();
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation ON;");
                    sb.Append($"UPDATE DetectorWorkstation SET LogicalWorkstationId = {obj.LogicalWorkstationId}, DetectorId = {obj.DetectorId}");
                    sb.Append($"WHERE Id = {obj.Id};");
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation OFF;");

                    context.Database.ExecuteSqlRaw(sb.ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }

        public async Task<bool> UpdateAsync(DetectorWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var sb = new StringBuilder();
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation ON;");
                    sb.Append($"UPDATE DetectorWorkstation SET LogicalWorkstationId = {obj.LogicalWorkstationId}, DetectorId = {obj.DetectorId}");
                    sb.Append($"WHERE Id = {obj.Id};");
                    sb.Append("SET IDENTITY_INSERT DetectorWorkstation OFF;");

                    await context.Database.ExecuteSqlRawAsync(sb.ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }
    }
}
