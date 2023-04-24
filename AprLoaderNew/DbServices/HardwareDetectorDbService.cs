using AprLoaderNew.EPO_Hardware;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AprLoader.Core.DbServices
{
    class HardwareDetectorDbService : IBasicDbService<HardwareDetector>
    {
        public event Action<object, Exception> ExceptionRaised;

        public bool Add(HardwareDetector obj)
        {
            try
            {
                using (EPO_hardwareContext context = new EPO_hardwareContext())
                {
                    context.HardwareDetectors.Add(obj);
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

        public async Task<bool> AddAsync(HardwareDetector obj)
        {
            try
            {
                using (EPO_hardwareContext context = new EPO_hardwareContext())
                {
                    context.HardwareDetectors.Add(obj);
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

        public HardwareDetector[] GetAsArray()
        {
            using (EPO_hardwareContext context = new EPO_hardwareContext())
            {
                return context.HardwareDetectors.ToArray();
            }
        }

        public async Task<HardwareDetector[]> GetAsArrayAsync()
        {
            using (EPO_hardwareContext context = new EPO_hardwareContext())
            {
                return await context.HardwareDetectors.ToArrayAsync();
            }
        }

        public bool Remove(HardwareDetector obj)
        {
            try
            {
                using (EPO_hardwareContext context = new EPO_hardwareContext())
                {
                    var entity = context.HardwareDetectors.FirstOrDefault(x => x.Id == obj.Id);
                    context.HardwareDetectors.Remove(entity);
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

        public async Task<bool> RemoveAsync(HardwareDetector obj)
        {
            try
            {
                using (EPO_hardwareContext context = new EPO_hardwareContext())
                {
                    var entity = await context.HardwareDetectors.FirstOrDefaultAsync(x => x.Id == obj.Id);
                    context.HardwareDetectors.Remove(entity);
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

        public bool Update(HardwareDetector obj)
        {
            try
            {
                using (EPO_hardwareContext context = new EPO_hardwareContext())
                {
                    context.HardwareDetectors.Add(obj);
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

        public async Task<bool> UpdateAsync(HardwareDetector obj)
        {
            try
            {
                using (EPO_hardwareContext context = new EPO_hardwareContext())
                {
                    context.HardwareDetectors.Add(obj);
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
