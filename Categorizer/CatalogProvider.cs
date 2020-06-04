using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categorizer
{
    interface CatalogProvider
    {
        void MoveCategory(object from, object to);
        void CreateCategory(string name, string path);
        void DeleteCategory(string path);
        object GetCategory(string name);
        object[] GetAllCategories();
    }
}
