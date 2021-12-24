using AutoMapper;
using Business.Repositories;
using Data.CommonEntities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BASE.API.Controllers.BaseController
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController<T, TD> : ControllerBase
      where T : GenericEntity
      where TD : class
    {
        private readonly GenericRepository<T> _repository;
        private readonly IMapper _mapper;

        public BaseController(IMapper mapper, GenericRepository<T> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public List<T> Get()
        {
            var result = _repository.GetAll();
            return result.ToList();
        }

        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            var objectEntity = _repository.Find(x => x.Id == id);
            return objectEntity.ToString();
        }

        [HttpPost]
        public void Post([FromBody] TD body)
        {
            var resource = _mapper.Map<T>(body);

            _repository.Add(resource);
            _repository.Save();
        }

        [HttpPut]
        public void Put([FromBody] T value)
        {
            _repository.Edit(value);
            _repository.Save();
        }

        [HttpDelete]
        public void Delete([FromBody] T value)
        {
            _repository.Delete(value);
            _repository.Save();
        }
    }
}
