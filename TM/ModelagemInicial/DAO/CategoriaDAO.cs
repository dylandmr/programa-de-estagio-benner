﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelagemInicial.DAO
{
    public class CategoriaDAO
    {
        public void Adiciona(Categoria categoria)
        {
            using (var contexto = new TMContext())
            {
                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
            }
        }

        public void Atualiza(Categoria categoria)
        {
            using (var contexto = new TMContext())
            {
                contexto.Entry(categoria).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public IList<Categoria> Lista()
        {
            using (var contexto = new TMContext())
            {
                return contexto.Categorias.ToList();
            }
        }
    }
}