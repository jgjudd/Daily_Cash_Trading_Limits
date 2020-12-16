using System;
using Daily_Cash_Trading_Limits.Models;
using Microsoft.EntityFrameworkCore;

namespace Daily_Cash_Trading_Limits
{
    public class DatabaseContext : DbContext
    {
        public DbSet<BankName> BankNames { get; set; }

        public DbSet<RiskRating> RiskRatings { get; set; }

        public DbSet<TotalAssets> TotalAssets { get; set; }

        public DbSet<DailyCalculatedLimit> DailyCalculatedLimits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Database.db");
        }
    }
}


/*
 DB SEED:

CREATE TABLE BankNames (
  bankName varchar(50),
  approved int 
);
CREATE TABLE RiskRatings (
  riskRating int,
  effectOnLimit decimal 
);
CREATE TABLE TotalAssets (
  name varchar(50),
  rating int,
  totalAssets bigint,
  currentDate Date
);
CREATE TABLE CalculatedLimits (
  bankName varchar(50),
  dailyLimit bigint
);

insert into BankNames values("Bank A", 1);
insert into BankNames values("Bank B", 1);
insert into BankNames values("Bank C", 1);

insert into RiskRatings values(1, 0.10);
insert into RiskRatings values(3, 0.30);
insert into RiskRatings values(5, 0.50);

insert into TotalAssets values("bank a", 1, 500000, CURRENT_TIMESTAMP);
insert into TotalAssets values("bank b", 3, 1000000, CURRENT_TIMESTAMP);
insert into TotalAssets values("bank c", 5, 1500000, CURRENT_TIMESTAMP);

insert into CalculatedLimits values("Bank A", 3432560);
insert into CalculatedLimits values("Bank B", 656630);
insert into CalculatedLimits values("Bank C", 7654322456);
 
 
 
 ---------------------------------------------------------------
    What I had when i stopped, Monday night...



CREATE FUNCTION dbo.updateCalculatedLimit(
    @bankName AS varchar(50)
)
RETURNS bigint
AS
BEGIN
    @assets = (SELECT * FROM TotalAssets WHERE "name" = @bankName)
    @effect = (SELECT effectOnLimit FROM RiskRating WHERE 'riskRating' = @assets.rating)
    @newLimit = 2000000 + (2000000 * @effect)
    
    -- if Total Assets > 3M, increase limit by 23%
    IF @assets.totalAsset > 3000000
        RETURN (@newLimit + (@newLimit * 0.23))
        ELSE
        RETURN @newLimit
END:

DECLARE
    @bank varchar(50) = 'Bank A'
BEGIN
    UPDATE CalculatedLimit
    SET dailyLimit = updateCalculatedLimit(@bank)
    WHERE bankName = @bank
END;


-- BEGIN
-- SELECT * 
--     FROM TotalAssets AS TA
--     JOIN BankName AS BN ON TA.name=BN.bankName
--     JOIN CalculatedLimit AS CL ON BN.bankName=CL.bankName
-- END;

-- SELECT name AS @name from TotalAssets
-- UNION
-- SELECT rating AS @rating from TotalAssets
-- UNION
-- SELECT totalAssets AS @totalAssets from TotalAssets
-- UNION
-- SELECT currentDate AS @currentDate from TotalAssets


*/