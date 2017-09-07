using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using Db4objects.Db4o;
using Domain.PCyP.Biz;
using Solution.PCyP.DAL;
using Domain.PCyP.DAL;

namespace Domain.PCyP.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class CategoryRepository : BaseRepository, ICrud<Category>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        public void Add(Category category)
        {

            using (var db = Db4oFactory.OpenFile(Path))
            {
                db.Store(category);
                db.Commit();
                db.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Category> All()
        {
            var lista = new List<Category>();
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Category());
                while (result != null && result.HasNext())
                    lista.Add((Category)result.Next());

                db.Close();
            }
            return lista;
        }

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Delete(Category model)
        {
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Category { RowGuid = model.RowGuid });
                var proto = (Category)result[0];
                db.Delete(proto);
                db.Commit();
                db.Close();
            }
        }

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Edit(Category model)
        {
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Category { RowGuid = model.RowGuid });
                var proto = (Category)result[0];
                ObjectMapper(model, proto);
                db.Store(proto);
                db.Commit();
                db.Close();
            }
        }

        public Category Find_id(string id)
        {
            Category proto;
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Category { RowGuid = id });
                proto = (Category)result[0];
                db.Close();
            }

            return proto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Category Find(Category model)
        {
            Category proto;
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(model);
                proto = (Category)result[0];
                db.Close();
            }
            return proto;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ParallelQuery<Category> ParallelQuery()
        {
            var lista = new List<Category>();
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Category());
                while (result != null && result.HasNext()) lista.Add((Category)result.Next());
                db.Close();
            }
            return lista.AsParallel();
        }

        List<Category> ICrud<Category>.All()
        {
            throw new NotImplementedException();
        }

        ParallelQuery<Category> ICrud<Category>.ParallelQuery()
        {
            throw new NotImplementedException();
        }
    }
}