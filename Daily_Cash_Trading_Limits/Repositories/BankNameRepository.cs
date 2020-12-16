using System;
using Daily_Cash_Trading_Limits.Models;
using System.Linq;
using System.Collections.Generic;

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
            List<BankName> bankList = new List<BankName>()
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
            };

            return bankList;
        }

        public BankName GetBank(int id)
        {
            return new BankName()
            {
                BankId = id,
                Name = $"Bank {id}",
                Approved = true
            };
        }

        public BankName Update(BankName item)
        {
            throw new NotImplementedException();
        }
    }
}
