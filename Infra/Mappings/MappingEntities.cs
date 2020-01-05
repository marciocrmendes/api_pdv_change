﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings
{
    public static class MappingEntities
    {
        /// <summary>
        /// Método que inicia o mapeamento das entidades do bancow
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Init(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CashierMap());
            modelBuilder.ApplyConfiguration(new SaleMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new SaleProductMap());
        }
    }
}
