using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IChildService
    {
        List<ChildModel> GettAll();
        ChildModel GetById(int id);
        ChildModel Add(ChildModel model);
        void Update(ChildModel model);
        void Delete(ChildModel model);
        void Search(ChildModel model);
    }
}
