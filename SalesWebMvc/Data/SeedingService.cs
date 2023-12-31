﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private VendasWebMvcContext _context;

        public SeedingService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() ||
                _context.Vendedor.Any() ||
                _context.RecordeDeVenda.Any())
            {
                return; // DB has been seeded
            }

            Departamento d1 = new Departamento(1, "Computers");
            Departamento d2 = new Departamento(2, "Electronics");
            Departamento d3 = new Departamento(3, "Fashion");
            Departamento d4 = new Departamento(4, "Books");

            Vendedor s1 = new Vendedor(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor s2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor s3 = new Vendedor(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor s4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedor s5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedor s6 = new Vendedor(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            RecordDeVenda r1 = new RecordDeVenda(1, new DateTime(2018, 09, 25), 11000.0, StatusDeVenda.Faturado, s1);
            RecordDeVenda r2 = new RecordDeVenda(2, new DateTime(2018, 09, 4), 7000.0, StatusDeVenda.Faturado, s5);
            RecordDeVenda r3 = new RecordDeVenda(3, new DateTime(2018, 09, 13), 4000.0, StatusDeVenda.Cancelado, s4);
            RecordDeVenda r4 = new RecordDeVenda(4, new DateTime(2018, 09, 1), 8000.0, StatusDeVenda.Faturado, s1);
            RecordDeVenda r5 = new RecordDeVenda(5, new DateTime(2018, 09, 21), 3000.0, StatusDeVenda.Faturado, s3);
            RecordDeVenda r6 = new RecordDeVenda(6, new DateTime(2018, 09, 15), 2000.0, StatusDeVenda.Faturado, s1);
            RecordDeVenda r7 = new RecordDeVenda(7, new DateTime(2018, 09, 28), 13000.0, StatusDeVenda.Faturado, s2);
            RecordDeVenda r8 = new RecordDeVenda(8, new DateTime(2018, 09, 11), 4000.0, StatusDeVenda.Faturado, s4);
            RecordDeVenda r9 = new RecordDeVenda(9, new DateTime(2018, 09, 14), 11000.0, StatusDeVenda.Pendente, s6);
            RecordDeVenda r10 = new RecordDeVenda(10, new DateTime(2018, 09, 7), 9000.0, StatusDeVenda.Faturado, s6);
            RecordDeVenda r11 = new RecordDeVenda(11, new DateTime(2018, 09, 13), 6000.0, StatusDeVenda.Faturado, s2);
            RecordDeVenda r12 = new RecordDeVenda(12, new DateTime(2018, 09, 25), 7000.0, StatusDeVenda.Pendente, s3);
            RecordDeVenda r13 = new RecordDeVenda(13, new DateTime(2018, 09, 29), 10000.0, StatusDeVenda.Faturado, s4);
            RecordDeVenda r14 = new RecordDeVenda(14, new DateTime(2018, 09, 4), 3000.0, StatusDeVenda.Faturado, s5);
            RecordDeVenda r15 = new RecordDeVenda(15, new DateTime(2018, 09, 12), 4000.0, StatusDeVenda.Faturado, s1);
            RecordDeVenda r16 = new RecordDeVenda(16, new DateTime(2018, 10, 5), 2000.0, StatusDeVenda.Faturado, s4);
            RecordDeVenda r17 = new RecordDeVenda(17, new DateTime(2018, 10, 1), 12000.0, StatusDeVenda.Faturado, s1);
            RecordDeVenda r18 = new RecordDeVenda(18, new DateTime(2018, 10, 24), 6000.0, StatusDeVenda.Faturado, s3);
            RecordDeVenda r19 = new RecordDeVenda(19, new DateTime(2018, 10, 22), 8000.0, StatusDeVenda.Faturado, s5);
            RecordDeVenda r20 = new RecordDeVenda(20, new DateTime(2018, 10, 15), 8000.0, StatusDeVenda.Faturado, s6);
            RecordDeVenda r21 = new RecordDeVenda(21, new DateTime(2018, 10, 17), 9000.0, StatusDeVenda.Faturado, s2);
            RecordDeVenda r22 = new RecordDeVenda(22, new DateTime(2018, 10, 24), 4000.0, StatusDeVenda.Faturado, s4);
            RecordDeVenda r23 = new RecordDeVenda(23, new DateTime(2018, 10, 19), 11000.0, StatusDeVenda.Cancelado, s2);
            RecordDeVenda r24 = new RecordDeVenda(24, new DateTime(2018, 10, 12), 8000.0, StatusDeVenda.Faturado, s5);
            RecordDeVenda r25 = new RecordDeVenda(25, new DateTime(2018, 10, 31), 7000.0, StatusDeVenda.Faturado, s3);
            RecordDeVenda r26 = new RecordDeVenda(26, new DateTime(2018, 10, 6), 5000.0, StatusDeVenda.Faturado, s4);
            RecordDeVenda r27 = new RecordDeVenda(27, new DateTime(2018, 10, 13), 9000.0, StatusDeVenda.Pendente, s1);
            RecordDeVenda r28 = new RecordDeVenda(28, new DateTime(2018, 10, 7), 4000.0, StatusDeVenda.Faturado, s3);
            RecordDeVenda r29 = new RecordDeVenda(29, new DateTime(2018, 10, 23), 12000.0, StatusDeVenda.Faturado, s5);
            RecordDeVenda r30 = new RecordDeVenda(30, new DateTime(2018, 10, 12), 5000.0, StatusDeVenda.Faturado, s2);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6);

            _context.RecordeDeVenda.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
