using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace DataLayer.Context
{
    /// <summary>
    /// اینترفیس مربوط به الگوی واحد کار
    /// </summary>
    public interface IUnitOfWork
    {

        /// <summary>
        /// متدی برای استفاده از الگوی مخزن توکار 
        /// EF
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <returns>IDbSet از موجودیت</returns>
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        /// <summary>
        /// متد ذخیره سازی
        /// </summary>
        /// <returns></returns>
        int SaveAllChanges();
        ///// <summary>
        ///// متد ذخیره سازی به صورت ناهمزمان
        ///// </summary>
        ///// <returns></returns>
        //Task<int> SaveChangesAsync();
        /// <summary>
        /// برای نشانه گذاری یک آبجکت که ویرایش شده است
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <param name="entity">آبجکت ارسالی</param>
        void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class;
        /// <summary>
        /// برای نشانه گذاری یک آبجکت که از کانتکس خارج  شده است
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <param name="entity">آبجکت ارسالی</param>
        void MarkAsDetached<TEntity>(TEntity entity) where TEntity : class;
        /// <summary>
        /// برای نشانه گذاری یک آبجکت که حذف شده است
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <param name="entity">آبجکت ارسالی</param>
        void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class;
        /// <summary>
        /// برای نشانه گذاری یک آبجکت که درج شده است
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <param name="entity">آبجکت ارسالی</param>
        void MarkAsAdded<TEntity>(TEntity entity) where TEntity : class;
      
        void AddThisRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
       

    }
}







