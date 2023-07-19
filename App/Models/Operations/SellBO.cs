using App.Models.Tables;
using GenericBD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models.Operations
{
    internal class SellBO : GenericBusiness
    {
        public Sell RandomSell(List<SellDetail> randomSells)
        {
            try
            {
                InitTransaction();
                var ressell = SellByDB(randomSells);
                if (ressell == null) return null;

                ChangeDB("ClothesClone");
                var ressellclone = SellByDB(randomSells);
                if (ressellclone == null) return null;

                EndTransaction(true);
                return ressell;
            }
            catch (Exception ex)
            {
                Error.Set(1, $"[RandomSell] {ex.Message}");
                return null;
            }
        }

        public Sell SellByDB(List<SellDetail> randomSells)
        {
            var now = DateTime.Now;
            var sell = new Sell();
            sell.Amount = randomSells.Sum(a => a.Amount);
            sell.DateSell = now;
            var ressell = ExecuteInsert(sell);
            if (Error.Number != 0)
                return null;
            ressell.Detail = new List<SellDetail>();

            var goods = ExecuteTable<Good>();
            foreach (var sd in randomSells)
            {
                var good = goods.First(a => a.Id == sd.IdProduct);
                good.Stock -= sd.Quantity;
                if (good.Stock < 0)
                    throw new Exception($"insufficient stock of [{good.Id}-{good.FullDescription}]");

                var conceptSell = ExecuteTable<Concept>().FirstOrDefault(a => a.Name == "SELL")
                    ?? ExecuteInsert(new Concept() { Name = "SELL" });
                if (Error.Number != 0)
                    return null;

                var mov = new Movement();
                mov.IdProduct = sd.IdProduct;
                mov.IdConcept = conceptSell.Id;
                mov.Quantity = sd.Quantity;
                mov.DateMovement = now;
                var resmov = ExecuteInsert(mov);
                if (Error.Number != 0)
                    return null;
                resmov.Product = good;
                resmov.Concept = conceptSell;

                sd.IdSell = ressell.Id;
                sd.IdMovement = resmov.Id;
                var ressd = ExecuteInsert(sd);
                if (Error.Number != 0)
                    return null;
                ressd.Product = good;
                ressd.Movement = resmov;

                ressd.Product = good;
                ressell.Detail.Add(ressd);

                var updategood = ExecuteUpdate(good);
                if (Error.Number != 0)
                    return null;
            }

            return ressell;
        }
    }
}
