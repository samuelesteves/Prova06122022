using Microsoft.AspNetCore.Mvc;

namespace Prova06122022.Controllers
{
    public class ProdutoController : Controller
    {

        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return HttpStatusCodeResult(HttpStatusCodeResult.BadRquest);
            }
            Produto produto = _contexto.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);

        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(long id)
        {
            Produto produto = _contexto.Produtos.Find(id);
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
            returnRedirectToAction("Index");
        }
    }
    //Mensagem na view

}

