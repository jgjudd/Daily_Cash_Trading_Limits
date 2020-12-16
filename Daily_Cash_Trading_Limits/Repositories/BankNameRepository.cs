using System;
using Daily_Cash_Trading_Limits.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Daily_Cash_Trading_Limits
{
    public interface IBankNameRepository
    {
        IEnumerable<BankName> GetAll();
        BankName GetBank(int id);
        void Add(BankName item);
        BankName Update(BankName item);
        void Delete(BankName item);
    }

    public class BankNameRepository : IBankNameRepository
    {
        //private readonly DatabaseContext _context;

        //public BankNameRepository(DatabaseContext context)
        //{
        //    _context = context;
        //}

        public void Add(BankName item)
        {
            throw new NotImplementedException();
        }

        public void Delete(BankName item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankName> GetAll()
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                //IEnumerable<BankName> query =
                //    from bankName in _context.BankNames.AsEnumerable()
                //    select bankName;
                //return query;

                return new List<BankName>
                {
                    new BankName()
                    {
                        BankId = 1,
                        Name = "Bank 1",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 2,
                        Name = "Bank 2",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 3,
                        Name = "Bank 3",
                        Approved = false
                    },
                    new BankName()
                    {
                        BankId = 4,
                        Name = "Bank 4",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 5,
                        Name = "Bank 5",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 6,
                        Name = "Bank 6",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 7,
                        Name = "Bank 7",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 8,
                        Name = "Bank 8",
                        Approved = false
                    },
                    new BankName()
                    {
                        BankId = 9,
                        Name = "Bank 9",
                        Approved = true
                    },
                    new BankName()
                    {
                        BankId = 10,
                        Name = "Bank 10",
                        Approved = true
                    }
                };
            }
        }

        public BankName GetBank(int bankId)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                // return _context.BankNames.FirstOrDefault(x => x.BankId == bankId);
                
                return new BankName()
                {
                    BankId = 5,
                    Name = "Bank 5",
                    Approved = true
                };
            }

        }

        public BankName Update(BankName item)
        {
            throw new NotImplementedException();
        }
    }
}
