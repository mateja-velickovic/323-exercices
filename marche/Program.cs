using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Linq;
using IronXL;
using System.Runtime.InteropServices;
using Aspose.Cells;
using System.Collections.Generic;

namespace _323_matvelickov_marche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> wmelon = new List<double>();

            int count_peachSeller = 0;
            string sellerName = "";
            string sellerStand = "";

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWB = excelApp.Workbooks.Open(@"C:\Users\pe04uhp\Desktop\323-matvelickov-marche\pdm-2.xlsx");
            Excel._Worksheet excelWS = excelWB.Sheets[2];
            Excel.Range excelRange = excelWS.UsedRange;

            int rowCount = excelRange.Rows.Count;
            int columnCount = excelRange.Columns.Count;
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= columnCount; j++)
                {
                    if (excelRange.Cells[i, j] != null)
                    {
                        string cellValue = excelRange.Cells[i, j].Value2.ToString();
                        if (cellValue == "Pêches")
                        {
                            count_peachSeller++;
                        }
                        if (cellValue == "Pastèques")
                        {
                            double cellPrice = excelRange.Cells[i, j + 1].Value2;
                            wmelon.Add(cellPrice);
                            if (cellPrice == wmelon.Max())
                            {
                                sellerName = excelRange.Cells[i, j - 1].Value2.ToString();
                                sellerStand = excelRange.Cells[i, j - 2].Value2.ToString();
                            }
                        }
                    }
                }
            }

            Console.Write($"Il y a {count_peachSeller} vendeurs de pêche.\n");
            Console.Write($"C'est {sellerName} qui a le plus de pastèques (stand {sellerStand}, {wmelon.Max()} pièces)\r\n");

            Console.ReadLine();
        }
    }
}
