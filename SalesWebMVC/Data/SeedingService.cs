using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService (SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed ()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "John Dee", "john@gmail.com", new DateTime(1992, 9, 10), 4000.0 , d1);
            Seller s2 = new Seller(2, "Alex Ross", "alex@gmail.com", new DateTime(1991, 11, 05), 3000.0 , d2);
            Seller s3 = new Seller(3, "Paul Walker", "paul@gmail.com", new DateTime(1990, 5, 15), 4500.0 , d3);
            Seller s4 = new Seller(4, "George Orwell", "george@gmail.com", new DateTime(1993, 12, 02), 3800.0 , d4);
            Seller s5 = new Seller(5, "Nick Mason", "nick@gmail.com", new DateTime(1995, 10, 06), 6000.0 , d1);
            Seller s6 = new Seller(6, "Emilia Blank", "emilia@gmail.com", new DateTime(1994, 03, 13), 5500.0 , d2);
            Seller s7 = new Seller(7, "Lena Strauss", "lena@gmail.com", new DateTime(1991, 04, 08), 3200.0 , d3);
            Seller s8 = new Seller(8, "Faye Valentine", "faye@gmail.com", new DateTime(1992, 08, 21), 3900.0 , d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 03, 26), 15000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 04, 24), 12000.0, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 04, 18), 14000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 05, 03), 7000.0, SaleStatus.Pending, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 05, 19), 9000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 03, 21), 12400.0, SaleStatus.Canceled, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 02, 17), 13800.0, SaleStatus.Pending, s7);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 06, 12), 8500.0, SaleStatus.Billed, s8);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 06, 09), 10400.0, SaleStatus.Billed, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 04, 05), 12300.0, SaleStatus.Pending, s2);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 05, 23), 11900.0, SaleStatus.Billed, s3);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 03, 11), 11200.0, SaleStatus.Billed, s4);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 01, 08), 4200.0, SaleStatus.Canceled, s5);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2021, 02, 10), 4900.0, SaleStatus.Billed, s6);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2021, 06, 12), 3200.0, SaleStatus.Billed, s7);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2021, 07, 09), 16200.0, SaleStatus.Pending, s8);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2021, 04, 06), 12300.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2021, 05, 03), 14200.0, SaleStatus.Canceled, s2);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2021, 03, 18), 5200.0, SaleStatus.Pending, s3);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2021, 02, 20), 4700.0, SaleStatus.Billed, s4);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2021, 01, 21), 20200.0, SaleStatus.Billed, s5);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2021, 03, 28), 9900.0, SaleStatus.Billed, s6);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2021, 05, 25), 10000.0, SaleStatus.Pending, s7);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2021, 03, 17), 13300.0, SaleStatus.Pending, s8);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24);
            _context.SaveChanges();
        }
    }
}
