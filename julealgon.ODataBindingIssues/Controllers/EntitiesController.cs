using julealgon.ODataBindingIssues.Entities;
using Microsoft.AspNet.OData;
using System.Linq;

namespace julealgon.ODataBindingIssues.Controllers
{
    public class EntitiesController : ODataController
    {
        public IQueryable<Entity> Get([FromODataUri] int keyThisIsAKey)
        {
            return new[] { new Entity() }.AsQueryable();
        }
    }
}
