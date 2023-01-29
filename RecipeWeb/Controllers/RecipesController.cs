using Microsoft.AspNetCore.Mvc;
using RecipeBizObjects;
using CPUFramework;
using Microsoft.AspNetCore.Cors;

namespace RecipeWeb.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            List<BizRecipe> lst = BizRecipe.GetAll();
            return View(lst);
        }
        [EnableCors("Policy1")]
        public IActionResult APIRecipeList()
        {
            List<BizRecipe> lst = BizRecipe.GetAll();
            return Json(lst);
        }

        [EnableCors("Policy1")]
        public IActionResult APICuisineTypeList()
        {
            List<BizCuisineType> lst = BizCuisineType.GetAll();
            return Json(lst);
        }
   
        public IActionResult RecipeDetail(string code)
        {
            BizRecipe rec = BizRecipe.Get("Code", code);          
            return View(rec);
        }

        public ActionResult Edit(string id)
        {
            BizRecipe r;
            if (string.IsNullOrEmpty(id))
            {
                r = new();
            }
            else
            {
                r = BizRecipe.Get("RecipeName", id);
            }
            return View(r);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BizRecipe recobj)
        {
            try
            {
                recobj.Save();
                return RedirectToAction(nameof(Index));
            }
            catch(CPUException ex)
            {
                recobj = BizRecipe.Get(recobj.RecipeId);
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                return View(recobj);
            }
        }

        public ActionResult Delete(string id)
        {
            BizRecipe r  = BizRecipe.Get("RecipeName", id);
            return View(r);
        }

        // POST: PartiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(BizRecipe recipe)
        {
            try
            {
                recipe.Delete();
                return RedirectToAction(nameof(Index));
            }
            catch (CPUException ex)
            {
                recipe = BizRecipe.Get(recipe.RecipeId);
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                return View(recipe);
            }

        }
    }
}
