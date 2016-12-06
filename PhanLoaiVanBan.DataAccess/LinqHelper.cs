using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;


namespace PhanLoaiVanBan.DataAccess.Linq
{
    public class LinqHelper<TDatabase> : IDisposable where TDatabase : DataContext, new()
    {
        #region Constructors
        public LinqHelper()
        {
            tDatabase = new TDatabase();
        }

        public TDatabase DataContext
        {
            get
            {
                return tDatabase;
            }
        }
        #endregion

        #region Property
        private TDatabase tDatabase;
        public LinqTransaction<TDatabase> Transaction;
        /// <summary>
        /// Begin new transaction if transaction is null.
        /// </summary>
        public void BeginTransaction()
        {
            if (tDatabase.Transaction == null || tDatabase.Transaction.Connection == null)
                Transaction = new LinqTransaction<TDatabase>(tDatabase);
        }
        #endregion

        #region Select

        /// <summary>
        /// Return a current datetime from server.
        /// </summary>
        /// <returns></returns>
        public DateTime GetServerDateTime()
        {
            return tDatabase.ExecuteQuery<DateTime>("SELECT GETDATE()").First();
            //this function in DataContext is protected.
            //return (DateTime) ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), null).ReturnValue;
        }

        /// <summary>
        /// Return a collection of objects of a particular type, where the type is defined by the T parameter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IQueryable<T> GetTable<T>() where T : class
        {
            return tDatabase.GetTable<T>();
        }

        /// <summary>
        /// Get all data and return a list of objects of a particular type, where the type is defined by the T parameter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetAll<T>() where T : class
        {
            return tDatabase.GetTable<T>().ToList();
        }

        /// <summary>
        /// Get limited data by paging.
        /// Return a list of objects of a particular type, where the type is defined by the T parameter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<T> GetAll<T>(int pageNumber, int pageSize) where T : class
        {
            if (pageNumber < 1)
                throw new Exception("Page number is invalid.");
            return tDatabase.GetTable<T>().Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        /// <summary>
        /// Return a list of entities by filter (T parameter is a type of the entity).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<T> Filter<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return tDatabase.GetTable<T>().Where(predicate).ToList();
        }

        /// <summary>
        /// Return a list of entities by filter and paging (T parameter is a type of the entity).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<T> Filter<T>(Expression<Func<T, bool>> predicate, int pageNumber, int pageSize)
        where T : class
        {
            if (pageNumber < 1)
                throw new Exception("Page number is invalid.");
            return tDatabase.GetTable<T>().Where(predicate).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        /// <summary>
        /// Return an entity if exist, or not return Null. (T parameter is a type of the entity)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public T GetOne<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return tDatabase.GetTable<T>().Where(predicate).SingleOrDefault();
        }
        /// <summary>
        /// Check an entity is exist in database. (T parameter is a type of the entity).
        /// Return True if the entity is exist.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public bool EntityExists<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return tDatabase.GetTable<T>().Where(predicate).Count() > 0;
        }

        #endregion

        #region Void

        /// <summary>
        /// Update all changes to database.
        /// Notes: Apply for all objects in reference to objects which get from database.
        /// </summary>
        public void UpdateChanges()
        {
            tDatabase.SubmitChanges();
        }

        /// <summary>
        /// Insert an entity into database (T parameter is a type of the entity).
        /// Notes: After inserting, this entity is mapping with database.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void Insert<T>(T entity) where T : class
        {
            tDatabase.GetTable<T>().InsertOnSubmit(entity);
            tDatabase.SubmitChanges();
        }
        /// <summary>
        /// Insert a list of entities (T parameter is a type of the entity).
        /// Notes: After inserting, this list is mapping with database.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityList"></param>
        public void Insert<T>(List<T> entityList) where T : class
        {
            tDatabase.GetTable<T>().InsertAllOnSubmit(entityList);
            tDatabase.SubmitChanges();
        }

        /// <summary>
        /// Update an entity by expression (T parameter is a type of the entity).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="predicate"></param>
        public void Update<T>(T entity, Expression<Func<T, bool>> predicate) where T : class
        {
            var t = tDatabase.GetTable<T>().Where(predicate).SingleOrDefault();
            if (t == null)
                throw new NullReferenceException("Error: Entity is not exist.");
            if (!t.Equals(entity))
                foreach (var p in t.GetType().GetProperties())
                    p.SetValue(t, p.GetValue(entity, null), null);

            tDatabase.SubmitChanges();
        }

        /// <summary>
        /// Delete data of one table has name is T parameter by expression.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        public void Delete<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            var t = tDatabase.GetTable<T>().Where(predicate);
            if (t.Count() == 0) return;
            tDatabase.GetTable<T>().DeleteAllOnSubmit(t);
            tDatabase.SubmitChanges();
        }

        /// <summary>
        /// Delete all data of one table has name is T parameter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void DeleteAll<T>() where T : class
        {
            var t = tDatabase.GetTable<T>();
            if (t.Count() == 0) return;
            tDatabase.GetTable<T>().DeleteAllOnSubmit(t);
            tDatabase.SubmitChanges();
        }
        #endregion

        public void Dispose()
        {
            tDatabase = null;
        }
    }

    #region Class Transaction
    public class LinqTransaction<TDatabase> where TDatabase : DataContext
    {
        public LinqTransaction(TDatabase tDatabase)
        {
            this.tDatabase = tDatabase;
            OpenConnection();
            this.tDatabase.Transaction = tDatabase.Connection.BeginTransaction();
        }
        private readonly TDatabase tDatabase;

        #region Private
        private void OpenConnection()
        {
            if (tDatabase.Connection.State == ConnectionState.Closed)
            {
                tDatabase.Connection.Open();
            }
        }
        private void CloseConnection()
        {
            if (tDatabase.Connection.State == ConnectionState.Open)
            {
                tDatabase.Connection.Close();
            }
        }
        private void Rollback()
        {
            if (tDatabase.Transaction != null)
                tDatabase.Transaction.Rollback();
        }
        private void Dispose()
        {
            if (tDatabase.Transaction == null) return;
            tDatabase.Transaction.Dispose();
            tDatabase.Transaction = null;
        }
        #endregion

        #region Public

        /// <summary>
        /// Commite and dispose transaction.
        /// </summary>
        public void CommitAndDispose()
        {
            try
            {
                tDatabase.Transaction.Commit();
            }
            catch
            {
                Rollback();
                throw;
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
        }

        /// <summary>
        /// Rollback and dispose transaction.
        /// </summary>
        public void RollbackAndDispose()
        {
            Rollback();
            CloseConnection();
            Dispose();
        }
        #endregion
    }
    #endregion
}
