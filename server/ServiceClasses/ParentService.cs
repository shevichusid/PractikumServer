using Service.Interface;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Repositories.Interfaces;
using Repositories.Entities;
using NuGet.Protocol.Core.Types;
using LibGit2Sharp;
using Microsoft.EntityFrameworkCore;


namespace Service.ServiceClasses
{
    public class ParentService : IParentService
    {
        private readonly IParentRepository rep;
        private readonly IMapper mapper;
        public ParentService(IParentRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        public async Task<ParentModel> AddAsync(ParentModel model)
        {
            Parent parent = mapper.Map<Parent>(model);
            ParentModel pm = mapper.Map<ParentModel>(parent);
            rep.AddAsync(parent);
            return pm;
        }

        public async Task DeleteAsync(string idNumber)
        {
            await rep.DeleteAsync(idNumber);
        }

        public async Task<ParentModel> GetByIdNumberAsync(string idNumber)
        {
            Parent parent = await rep.GetByIdNumberAsync(idNumber);
            ParentModel parentmodel = mapper.Map<ParentModel>(parent);
            return parentmodel;
        }

        //public async Task<ICollection<ParentModel>> GetAllAsync()
        //{
        //    ICollection<Parent> list = await Repository.GetAllAsync();
        //    ICollection<ParentModel> l = new List<ParentModel>();
        //    foreach (var item in list)
        //    {
        //        l.Add(mapper.Map<ParentModel>(item));
        //    }
        //    return l;
        //}

        public async Task<ParentModel> UpdateAsync(ParentModel model)
        {
            Parent parent = mapper.Map<Parent>(model);
            ParentModel pm = mapper.Map<ParentModel>(await rep.UpdateAsync(parent));
            return pm;
        }

        public List<ParentModel> GettAll()
        {
            throw new NotImplementedException();
        }

        public ParentModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ParentModel Add(ParentModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(ParentModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(ParentModel model)
        {
            throw new NotImplementedException();
        }

        public void Search(ParentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
