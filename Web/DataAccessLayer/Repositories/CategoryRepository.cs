using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositores
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void AddCatagory(Category catagory)
        {
            c.Add(catagory);
            c.SaveChanges();
        }

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void DeleteCatagory(Category catagory)
        {
            c.Remove(catagory);
            c.SaveChanges();
        }

        public Category GeByID(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCatagory()
        {
            return c.Categories.ToList();
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCatagory(Category catagory)
        {
            c.Update(catagory);
            c.SaveChanges();
        }
    }
}
