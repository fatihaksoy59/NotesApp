using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestCompany.Notes.API.DTOs;
using TestCompany.Notes.Business.Abstract;
using TestCompany.Notes.Entities.Concrete;

namespace TestCompany.Notes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        private readonly IMapper _mapper;

        public NoteController(INoteService noteService, IMapper mapper)
        {
            _noteService = noteService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var notes = _noteService.GetAll();

            return Ok(_mapper.Map<IEnumerable<NoteDto>>(notes));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var note = _noteService.GetById(id);

            return Ok(_mapper.Map<NoteDto>(note));
        }

        [HttpPost]
        public IActionResult Save(NoteDto noteDto)
        {
            var newNote = _noteService.Add(_mapper.Map<Note>(noteDto));

            return Created(string.Empty,_mapper.Map<NoteDto>(newNote));
        }
        [HttpPut]
        public IActionResult Update(NoteDto noteDto)
        {
            _noteService.Update(_mapper.Map<Note>(noteDto));

            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(NoteDto noteDto)
        {
            _noteService.Delete(_mapper.Map<Note>(noteDto));

            return NoContent();
        }
    }
}