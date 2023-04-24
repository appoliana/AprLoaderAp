using AprLoaderNew.APR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AprLoader.Core.DbServices
{
    public class DetectorTypeDbService : IBasicDbService<DetectorType>
    {
        public event Action<object, Exception> ExceptionRaised;

        public bool Add(DetectorType obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.DetectorTypes.Add(obj);
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

        public async Task<bool> AddAsync(DetectorType obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.DetectorTypes.Add(obj);
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

        public DetectorType[] GetAsArray()
        {
            using (APRContext context = new APRContext())
                return context.DetectorTypes.ToArray();  
        }

        public async Task<DetectorType[]> GetAsArrayAsync()
        {
            using (APRContext context = new APRContext())
                return await context.DetectorTypes.ToArrayAsync();
        }

        public bool Remove(DetectorType obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var entity = context.DetectorTypes.FirstOrDefault(x => x.Id == obj.Id);
                    context.DetectorTypes.Remove(entity);
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

        public async Task<bool> RemoveAsync(DetectorType obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var entity = await context.DetectorTypes.FirstOrDefaultAsync(x => x.Id == obj.Id);
                    context.DetectorTypes.Remove(entity);
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

        public bool Update(DetectorType obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.DetectorTypes.Add(obj);
                    context.Entry(obj).State = EntityState.Modified;
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

        public async Task<bool> UpdateAsync(DetectorType obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.DetectorTypes.Add(obj);
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
