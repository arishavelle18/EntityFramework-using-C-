using EFCoreTutorial.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreTutorial.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DatabaseContext _ctx;

        public CategoryController(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Add()
        {
            try
            {
                var category = new Category
                {
                    Name = "Category1"
                };
                _ctx.Category.Add(category);
                _ctx.SaveChanges(); // for reflecting changes to the database
                return Content("Saved Successfully");
            }catch (Exception ex)
            {
                return Content(ex.Message);
            }
            
        }

        // get one category
        public IActionResult GetById(int id)
        {
            var category = _ctx.Category.Find(id);
            return Json(category);
        }

        //get all category
        public IActionResult GetAll()
        {
            // get all list of category
            var categories = _ctx.Category.ToList();
            return Json(categories);
        }

        
        //Delete Category
        public IActionResult DeleteCategory(int id)
        {
            // try to delete the category
            try
            {
                var category = _ctx.Category.Find(id);
                if (category == null)
                {
                    return Content("Error");
                }
                _ctx.Category.Remove(category);
                _ctx.SaveChanges();
                return Content("Successfully Deleted");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }


        //update the category
        public IActionResult UpdateCategory()
        {
            try
            {
                var category = new Category
                { 
                    Id = 8,
                    Name = "Category 8" 
                };

                _ctx.Category.Update(category);
                _ctx.SaveChanges();
                return Content("Successfully Updated");
            }catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        public IActionResult GetProduct()
        {
            var products = (from p in _ctx.Product join c in _ctx.Category on p.CategoryId
                equals c.Id select new Product
                {
                    Id=p.Id,
                    ProductName=p.ProductName,
                    CategoryId=p.CategoryId,
                    Cost=p.Cost,
                    CategoryName=c.Name
                }).ToList();
            return Json(products);
        }

    }
}
