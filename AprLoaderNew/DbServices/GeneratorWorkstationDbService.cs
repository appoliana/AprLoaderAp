using AprLoaderNew.APR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AprLoader.Core.DbServices
{
    public class GeneratorWorkstationDbService : IBasicDbService<GeneratorWorkStation>
    {
        public event Action<object, Exception> ExceptionRaised;

        public bool Add(GeneratorWorkStation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.GeneratorWorkStations.Add(obj);
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

        public async Task<bool> AddAsync(GeneratorWorkStation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.GeneratorWorkStations.Add(obj);
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

        public GeneratorWorkStation[] GetAsArray()
        {
            using (APRContext context = new APRContext())
            {
                return context.GeneratorWorkStations.ToArray();
            }
        }

        public async Task<GeneratorWorkStation[]> GetAsArrayAsync()
        {
            using (APRContext context = new APRContext())
            {
                return await context.GeneratorWorkStations.ToArrayAsync();
            }
        }

        public bool Remove(GeneratorWorkStation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var entity = context.GeneratorWorkStations.FirstOrDefault(x => x.Id == obj.Id);
                    context.GeneratorWorkStations.Remove(entity);
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

        public async Task<bool> RemoveAsync(GeneratorWorkStation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    var entity = await context.GeneratorWorkStations.FirstOrDefaultAsync(x => x.Id == obj.Id);
                    context.GeneratorWorkStations.Remove(entity);
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

        public bool Update(GeneratorWorkStation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.GeneratorWorkStations.Add(obj);
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

        public async Task<bool> UpdateAsync(GeneratorWorkStation obj)
        {
            try
            {
                using (APRContext context = new APRContext())
                {
                    context.GeneratorWorkStations.Add(obj);
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
