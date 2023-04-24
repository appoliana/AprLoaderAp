using AprLoaderNew.APR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AprLoader.Core.DbServices
{
    public class LogicalWorkstationDbService : IBasicDbService<LogicalWorkstation>
    {
        public event Action<object, Exception> ExceptionRaised;

        public bool Add(LogicalWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.LogicalWorkstations.Add(obj);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }

        public async Task<bool> AddAsync(LogicalWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.LogicalWorkstations.Add(obj);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }

        public LogicalWorkstation[] GetAsArray()
        {
            using (APRContext context = new APRContext())
            {
                return context.LogicalWorkstations.ToArray();
            }
        }

        public async Task<LogicalWorkstation[]> GetAsArrayAsync()
        {
            using (APRContext context = new APRContext())
            {
                return await context.LogicalWorkstations.ToArrayAsync();
            }
        }

        public bool Remove(LogicalWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var entity = context.LogicalWorkstations.FirstOrDefault(x => x.Id == obj.Id);
                    context.LogicalWorkstations.Remove(entity);
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }  
        }

        public async Task<bool> RemoveAsync(LogicalWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var entity = context.LogicalWorkstations.FirstOrDefault(x => x.Id == obj.Id);
                    context.LogicalWorkstations.Remove(entity);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }

        public bool Update(LogicalWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.LogicalWorkstations.Add(obj);
                    context.Entry(obj).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionRaised?.Invoke(this, ex);
                return false;
            }
        }

        public async Task<bool> UpdateAsync(LogicalWorkstation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.LogicalWorkstations.Add(obj);
                    context.Entry(obj).State = EntityState.Modified;
                    await context.SaveChangesAsync();
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
