using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ResourceRepo<T> : BaseRepo, IResourceRepo<T> where T : Resource, new()
    {
        public ResourceRepo() { }

        public T GetItemById(int id)
        {
            var index = base.GetIndex();

            object resource;
            if(typeof(T).IsAssignableFrom(typeof(Newsletter)))
            {
                resource = Activator.CreateInstance(typeof(T));
                Newsletter newsletter = (Newsletter)resource;
                newsletter.Name = typeof(T).FullName;
                newsletter.OtherField = "Rando Value";
                return (T)resource;
            }

            resource = new T() { Name = typeof(T).FullName };
            return (T)resource;
        }
    }
}
