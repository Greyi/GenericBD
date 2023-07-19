using App.Models.Operations;
using App.Models.Tables;
using GenericBD;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static App.Models.Session;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGrid<Good>(gvGoods);
                LoadGrid<Concept>(gvConcepts);
                LoadGrid<Sell>(gvSells);
                LoadGrid<Movement>(gvMovements);
                LoadGrid<SellDetail>(gvSellsDetail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadGrid<T>(DataGridView gv) where T : class
        {
            using (var bo = new GenericBusiness())
            {
                var ls = bo.ExecuteTable<T>();
                if (bo.Error.Number != 0)
                    throw new Exception($"Error. {bo.Error}");
                gv.DataSource = null;
                gv.DataSource = ls;
            }
        }

        private string RandStr()
        {
            return Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 10);
        }

        private void ClearGrid<T>(DataGridView gv) where T : class
        {
            var attr = typeof(T).GetCustomAttribute<BDProperties>();
            var root = attr.Root ?? nameof(T);
            using (var bo = new GenericBusiness())
            {
                var res = bo.Execute($"delete from {root}");
                if (bo.Error.Number != 0)
                {
                    MessageBox.Show($"Error. {bo.Error}");
                    return;
                }
                MessageBox.Show($"{res} rows was delete");
                LoadGrid<T>(gv);
            }
        }

        private void AddGridGoods()
        {
            var _new = new Good();
            _new.Brand = RandStr();
            _new.Category = RandStr();
            _new.Color = RandStr();
            _new.Cost = new Random().Next(1, 200);
            _new.Price = new Random().Next(1, 210);
            _new.Stock = new Random().Next(1, 30);

            using (var bo = new GenericBusiness())
            {
                var res = bo.ExecuteInsert(_new);
                if (bo.Error.Number != 0)
                {
                    MessageBox.Show($"Error. {bo.Error}");
                    return;
                }
                MessageBox.Show(JsonConvert.SerializeObject(res));
                LoadGrid<Good>(gvGoods);
            }
        }

        private void MapGridGoods()
        {
            if (gvGoods.SelectedRows.Count == 0)
            {
                IdGoods.Text = "";
                BrandGoods.Text = "";
                CategoryGoods.Text = "";
                ColorGoods.Text = "";
                CostGoods.Text = "";
                PriceGoods.Text = "";
                StockGoods.Text = "";
            }
            else
            {
                var map = gvGoods.SelectedRows[0].DataBoundItem as Good;
                IdGoods.Text = map.Id.ToString();
                BrandGoods.Text = map.Brand;
                CategoryGoods.Text = map.Category;
                ColorGoods.Text = map.Color;
                CostGoods.Text = map.Cost.ToString();
                PriceGoods.Text = map.Price.ToString();
                StockGoods.Text = map.Stock.ToString();
            }
        }

        private void UpdateGridGoods()
        {
            if (gvGoods.SelectedRows.Count == 0) return;

            var _update = new Good();
            _update.Id = Convert.ToInt32(IdGoods.Text);
            _update.Brand = BrandGoods.Text;
            _update.Category = CategoryGoods.Text;
            _update.Color = ColorGoods.Text;
            _update.Cost = Convert.ToInt32(CostGoods.Text);
            _update.Price = Convert.ToInt32(PriceGoods.Text);
            _update.Stock = Convert.ToInt32(StockGoods.Text);

            using (var bo = new GenericBusiness())
            {
                var res = bo.ExecuteUpdate(_update);
                if (bo.Error.Number != 0)
                {
                    MessageBox.Show($"Error. {bo.Error}");
                    return;
                }
                MessageBox.Show(JsonConvert.SerializeObject(res));
                LoadGrid<Good>(gvGoods);
            }
        }

        private void AddGridConcept()
        {
            var _new = new Concept();
            _new.Name = RandStr();

            using (var bo = new GenericBusiness())
            {
                var res = bo.ExecuteInsert(_new);
                if (bo.Error.Number != 0)
                {
                    MessageBox.Show($"Error. {bo.Error}");
                    return;
                }
                MessageBox.Show(JsonConvert.SerializeObject(res));
                LoadGrid<Concept>(gvConcepts);
            }
        }

        private void MapGridConcept()
        {
            if (gvConcepts.SelectedRows.Count == 0)
            {
                IdConcept.Text = "";
                NameConcept.Text = "";
            }
            else
            {
                var map = gvConcepts.SelectedRows[0].DataBoundItem as Concept;
                IdConcept.Text = map.Id.ToString();
                NameConcept.Text = map.Name;
            }
        }

        private void UpdateGridConcept()
        {
            if (gvConcepts.SelectedRows.Count == 0) return;

            var _update = new Concept();
            _update.Id = Convert.ToInt32(IdConcept.Text);
            _update.Name = NameConcept.Text;

            using (var bo = new GenericBusiness())
            {
                var res = bo.ExecuteUpdate(_update);
                if (bo.Error.Number != 0)
                {
                    MessageBox.Show($"Error. {bo.Error}");
                    return;
                }
                MessageBox.Show(JsonConvert.SerializeObject(res));
                LoadGrid<Concept>(gvConcepts);
            }
        }

        private void AddMovementRandom()
        {
            using (var bo = new GenericBusiness())
            {
                var res = bo.ExecuteSingle<Movement>(ProceduresStore.RandomMovements);
                if (bo.Error.Number != 0)
                {
                    MessageBox.Show($"Error. {bo.Error}");
                    return;
                }
                MessageBox.Show(JsonConvert.SerializeObject(res));
                LoadGrid<Good>(gvGoods);
                LoadGrid<Movement>(gvMovements);
            }
        }

        private void MapGridMovement()
        {
            if (gvMovements.SelectedRows.Count == 0)
            {
                IdMovement.Text = "";
                IdProdMovement.Text = "";
                IdConceptMovement.Text = "";
                QuantityMovement.Text = "";
                DateMovement.Value = DateTimePicker.MinimumDateTime;
            }
            else
            {
                var map = gvMovements.SelectedRows[0].DataBoundItem as Movement;
                IdMovement.Text = map.Id.ToString();
                IdProdMovement.Text = map.IdProduct.ToString();
                IdConceptMovement.Text = map.IdConcept.ToString();
                QuantityMovement.Text = map.Quantity.ToString();
                DateMovement.Value = map.DateMovement;
            }
        }

        private void GoodMovement(int act)
        {
            var idGood = Convert.ToInt32(IdGoods.Text);
            var quantity = Convert.ToInt32(QuantityGoodMovement.Value) * act;
            using (var bo = new GenericBusiness())
            {
                var res = bo.ExecuteSingle<Movement>(ProceduresStore.GoodMovements, new
                {
                    IdGood = idGood,
                    Quantity = quantity,
                });
                if (bo.Error.Number != 0)
                {
                    MessageBox.Show($"Error. {bo.Error}");
                    return;
                }
                MessageBox.Show(JsonConvert.SerializeObject(res));
            }
            LoadGrid<Good>(gvGoods);
            LoadGrid<Movement>(gvMovements);
        }

        private void RandomSell()
        {
            using (var bo = new SellBO())
            {
                int mrand = 20;
                int rn() { mrand++; return new Random().Next(1, mrand); }
                List<SellDetail> randomSells = new List<SellDetail>();
                while (randomSells.Count == 0)
                {
                    randomSells = gvGoods.Rows.Cast<DataGridViewRow>()
                        .Select(a => a.DataBoundItem).Cast<Good>()
                        .Select((a) =>
                    {
                        var rd = rn();
                        if (rd % 11 != 0) return null;

                        var sd = new SellDetail();
                        sd.IdProduct = a.Id;
                        sd.Quantity = new Random().Next(1, 3);
                        sd.Price = a.Price;
                        sd.Amount = sd.Quantity * a.Price;
                        return sd;
                    }).ToList();
                    randomSells.RemoveAll(a => a is null);
                }
                var res = bo.RandomSell(randomSells);
                if (bo.Error.Number != 0)
                {
                    MessageBox.Show($"Error. {bo.Error}");
                    return;
                }
                MessageBox.Show(JsonConvert.SerializeObject(res));
                LoadGrid<Sell>(gvSells);
                LoadGrid<Movement>(gvMovements);
                LoadGrid<SellDetail>(gvSellsDetail);
                LoadGrid<Good>(gvGoods);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGridGoods();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearGrid<Good>(gvGoods);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGridGoods();
        }

        private void gvGoods_SelectionChanged(object sender, EventArgs e)
        {
            MapGridGoods();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddGridConcept();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearGrid<Concept>(gvConcepts);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateGridConcept();
        }

        private void gvConcepts_SelectionChanged(object sender, EventArgs e)
        {
            MapGridConcept();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddMovementRandom();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClearGrid<Movement>(gvMovements);
        }

        private void gvMovements_SelectionChanged(object sender, EventArgs e)
        {
            MapGridMovement();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var act = sender == button10 ? 1 : -1;
            GoodMovement(act);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RandomSell();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using(var bo = new GenericBusiness())
            {
                var sqlLastSell = "select top 1 Id from Sells order by DateSell desc";
                var id1 = bo.ExecuteScalar<int>(sqlLastSell);
                var id2 = bo.ExecuteOutput<int>(ProceduresStore.GetIdLastSellOutput);
            }
        }
    }
}
