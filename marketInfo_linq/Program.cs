using System;
using System.Collections.Generic;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace matvelickov_marketInfo_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Place du marché");

            ISheet sheet;
            using (var stream = new FileStream("../../pdm.xlsx", FileMode.Open))
            {
                stream.Position = 0;
                XSSFWorkbook xssWorkbook = new XSSFWorkbook(stream);
                sheet = xssWorkbook.GetSheetAt(1);//select 2nd sheet

                var data = new List<MarketInfo>();

                for (int i = (sheet.FirstRowNum + 1/*skip header*/); i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    int j = 0;
                    data.Add(new MarketInfo(
                        row.GetCell(j++).NumericCellValue.ToString(),
                        row.GetCell(j++).StringCellValue,
                        row.GetCell(j++).ToString(),
                        row.GetCell(j++).ToString(),
                        row.GetCell(j++).ToString(),
                        row.GetCell(j++).ToString()
                        ));
                }

                //Console.WriteLine(data);

                MarketInfo maxWatermelon = null;
                var peachSellers = new Dictionary<string, bool>();
                foreach (var item in data)
                {
                    if (item.Product == "Pêches")
                    {
                        if (!peachSellers.ContainsKey(item.Seller))
                        {
                            peachSellers.Add(item.Seller, true);
                        }
                    }

                    if (item.Product == "Pastèques")
                    {
                        if (maxWatermelon == null)
                        {
                            maxWatermelon = item;
                        }
                        else if (item.Quantity > maxWatermelon.Quantity)
                        {
                            maxWatermelon = item;
                        }
                    }
                }

                Console.WriteLine("NORMAL");

                var peachProducersLINQ = (from item in data where item.Product == "Pêches" select 1).Count();
                
                var mostMelon = (from item in data where item.Product == "Pastèques" select item);

                Console.WriteLine($"Il y a {peachProducersLINQ} vendeurs de pêches");

                Console.ReadLine();
            }
        }
    }


}