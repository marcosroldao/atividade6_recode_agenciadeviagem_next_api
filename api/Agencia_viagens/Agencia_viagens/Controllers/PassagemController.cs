﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Agencia_viagens.Context;
using Agencia_viagens.Models;

namespace Agencia_viagens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassagemController : ControllerBase
    {
        private readonly DataContext _context;

        public PassagemController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Passagem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passagem>>> GetPassagem()
        {
            return await _context.Passagem.ToListAsync();
        }

        // GET: api/Passagem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Passagem>> GetPassagem(int id)
        {
            var passagem = await _context.Passagem.FindAsync(id);

            if (passagem == null)
            {
                return NotFound();
            }

            return passagem;
        }

        // PUT: api/Passagem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPassagem(int id, Passagem passagem)
        {
            if (id != passagem.id_passsagem)
            {
                return BadRequest();
            }

            _context.Entry(passagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassagemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Passagem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Passagem>> PostPassagem(Passagem passagem)
        {
            _context.Passagem.Add(passagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPassagem", new { id = passagem.id_passsagem }, passagem);
        }

        // DELETE: api/Passagem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePassagem(int id)
        {
            var passagem = await _context.Passagem.FindAsync(id);
            if (passagem == null)
            {
                return NotFound();
            }

            _context.Passagem.Remove(passagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PassagemExists(int id)
        {
            return _context.Passagem.Any(e => e.id_passsagem == id);
        }
    }
}
