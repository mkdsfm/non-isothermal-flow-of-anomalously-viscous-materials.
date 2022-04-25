﻿using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using ProgramSystem.Bll.Services.Interfaces;

namespace ProgramSystem.Bll.Services.Services
{
    public class FileExcelService: IFileExcelService
    {
        public bool CreateExcel(string path, string? type, double? w, double? h, double? l, double? ro, double? c, double? T0, double? Vu, double? Tu,
                                                double? mu0, double? b, double? Tr, double? n, double? alphau, double? step, Results r)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Отчет");


            IFont font1 = workbook.CreateFont();
            font1.IsBold = true;
            ICellStyle style1 = workbook.CreateCellStyle();
            style1.SetFont(font1);
            style1.Alignment = HorizontalAlignment.Center;

            IFont font2 = workbook.CreateFont();
            font2.IsBold = true;
            ICellStyle style2 = workbook.CreateCellStyle();
            style2.SetFont(font2);
            style2.Alignment = HorizontalAlignment.Left;

            IFont font3 = workbook.CreateFont();
            font3.IsBold = false;
            ICellStyle style3 = workbook.CreateCellStyle();
            style3.SetFont(font3);
            style3.Alignment = HorizontalAlignment.Left;

            IFont font4 = workbook.CreateFont();
            font4.IsBold = false;
            ICellStyle style4 = workbook.CreateCellStyle();
            style4.SetFont(font4);
            style4.Alignment = HorizontalAlignment.Right;

            IRow row0 = sheet.CreateRow(0);
            ICell cell00 = row0.CreateCell(0);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, 1));
            cell00.SetCellValue("Входные параметры:");
            cell00.CellStyle= style1;           

            IRow row1 = sheet.CreateRow(1);
            ICell cell10 = row1.CreateCell(0);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(1, 1, 0, 1));
            cell10.SetCellValue("Геометрические параметры канала:");
            cell10.CellStyle = style2;

            IRow row2 = sheet.CreateRow(2);
            ICell cell20 = row2.CreateCell(0); cell20.SetCellValue("Ширина, м"); cell20.CellStyle = style3;
            ICell cell22 = row2.CreateCell(1); cell22.SetCellValue(Math.Round((double)w,2).ToString()); cell22.CellStyle = style4;

            IRow row3 = sheet.CreateRow(3);
            ICell cell30 = row3.CreateCell(0); cell30.SetCellValue("Глубина, м"); cell30.CellStyle = style3;
            ICell cell33 = row3.CreateCell(1); cell33.SetCellValue(Math.Round((double)h, 2).ToString()); cell33.CellStyle = style4;

            IRow row4 = sheet.CreateRow(4);
            ICell cell40 = row4.CreateCell(0); cell40.SetCellValue("Длина, м"); cell40.CellStyle = style3;
            ICell cell44 = row4.CreateCell(1); cell44.SetCellValue(Math.Round((double)l, 2).ToString()); cell44.CellStyle = style4;

            IRow row5 = sheet.CreateRow(5);
            ICell cell50 = row5.CreateCell(0); cell50.SetCellValue("Тип материала"); cell50.CellStyle = style2;
            ICell cell55 = row5.CreateCell(1); cell55.SetCellValue(type); cell55.CellStyle = style4;

            IRow row6 = sheet.CreateRow(6);
            ICell cell60 = row6.CreateCell(0);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(6, 6, 0, 1));
            cell60.SetCellValue("Параметры свойств материала:");
            cell60.CellStyle = style2;

            IRow row7 = sheet.CreateRow(7);
            ICell cell70 = row7.CreateCell(0); cell70.SetCellValue("Плотность, кг/м^3"); cell70.CellStyle = style3;
            ICell cell77 = row7.CreateCell(1); cell77.SetCellValue(Math.Round((double)ro, 2).ToString()); cell77.CellStyle = style4;

            IRow row8 = sheet.CreateRow(8);
            ICell cell80 = row8.CreateCell(0); cell80.SetCellValue("Удельная теплоемкость, Дж/(кг*С)"); cell80.CellStyle = style3;
            ICell cell88 = row8.CreateCell(1); cell88.SetCellValue(Math.Round((double)c, 2).ToString()); cell88.CellStyle = style4;

            IRow row9 = sheet.CreateRow(9);
            ICell cell90 = row9.CreateCell(0); cell90.SetCellValue("Температура плавления, С"); cell90.CellStyle = style3;
            ICell cell99 = row9.CreateCell(1); cell99.SetCellValue(Math.Round((double)T0, 2).ToString()); cell99.CellStyle = style4;

            IRow row10 = sheet.CreateRow(10);
            ICell cell100 = row10.CreateCell(0);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(10, 10, 0, 1));
            cell100.SetCellValue("Варьируемые параметры:");
            cell100.CellStyle = style1;

            IRow row11 = sheet.CreateRow(11);
            ICell cell110 = row11.CreateCell(0);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(11, 11, 0, 1));
            cell110.SetCellValue("Режимные параметры процесса:");
            cell110.CellStyle = style2;

            IRow row12 = sheet.CreateRow(12);
            ICell cell120 = row12.CreateCell(0); cell120.SetCellValue("Скорость крышки, м/с"); cell120.CellStyle = style3;
            ICell cell1212 = row12.CreateCell(1); cell1212.SetCellValue(Math.Round((double)Vu, 2).ToString()); cell1212.CellStyle = style4;

            IRow row13 = sheet.CreateRow(13);
            ICell cell130 = row13.CreateCell(0); cell130.SetCellValue("Температура крышки, С"); cell130.CellStyle = style3;
            ICell cell1313 = row13.CreateCell(1); cell1313.SetCellValue(Math.Round((double)Tu, 2).ToString()); cell1313.CellStyle = style4;

            IRow row14 = sheet.CreateRow(14);
            ICell cell140 = row14.CreateCell(0);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(14, 14, 0, 1));
            cell140.SetCellValue("Параметры математической модели:");
            cell140.CellStyle = style1;

            IRow row15 = sheet.CreateRow(15);
            ICell cell150 = row15.CreateCell(0);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(15, 15, 0, 1));
            cell150.SetCellValue("Эмпирические коэффициенты математической модели");
            cell150.CellStyle = style2;

            IRow row16 = sheet.CreateRow(16);
            ICell cell160 = row16.CreateCell(0); cell160.SetCellValue("Коэффициент консистенции при температуре приведения, Па*с^n"); cell160.CellStyle = style3;
            ICell cell1616 = row16.CreateCell(1); cell1616.SetCellValue(Math.Round((double)mu0, 2).ToString()); cell1616.CellStyle = style4;

            IRow row17 = sheet.CreateRow(17);
            ICell cell17 = row17.CreateCell(0); cell17.SetCellValue("Температурный коэффициент вязкости, 1/С"); cell17.CellStyle = style3;
            ICell cell1717 = row17.CreateCell(1); cell1717.SetCellValue(Math.Round((double)b, 2).ToString()); cell1717.CellStyle = style4;

            IRow row18 = sheet.CreateRow(18);
            ICell cell180 = row18.CreateCell(0); cell180.SetCellValue("Температура приведения, С"); cell180.CellStyle = style3;
            ICell cell1818 = row18.CreateCell(1); cell1818.SetCellValue(Math.Round((double)Tr, 2).ToString()); cell1818.CellStyle = style4;

            IRow row19 = sheet.CreateRow(19);
            ICell cell190 = row19.CreateCell(0); cell190.SetCellValue("Индекс течения"); cell190.CellStyle = style3;
            ICell cell1919 = row19.CreateCell(1); cell1919.SetCellValue(Math.Round((double)n, 2).ToString()); cell1919.CellStyle = style4;

            IRow row20 = sheet.CreateRow(20);
            ICell cell200 = row20.CreateCell(0); cell200.SetCellValue("Коэффициент теплоотдачи от крышки канала к материалу, Вт/(м^2*С)"); cell200.CellStyle = style3;
            ICell cell2020 = row20.CreateCell(1); cell2020.SetCellValue(Math.Round((double)alphau, 2).ToString()); cell2020.CellStyle = style4;

            IRow row21 = sheet.CreateRow(21);
            ICell cell210 = row21.CreateCell(0);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(21, 21, 0, 1));
            cell210.SetCellValue("Параметры метода решения уравнений модели:");
            cell210.CellStyle = style2;

            IRow row22 = sheet.CreateRow(22);
            ICell cell220 = row22.CreateCell(0); cell220.SetCellValue("Шаг расчета по длине канала, м"); cell220.CellStyle = style3;
            ICell cell2222 = row22.CreateCell(1); cell2222.SetCellValue(Math.Round((double)step, 2).ToString()); cell2222.CellStyle = style4;

            /*
            IRow row = sheet.CreateRow();
            ICell cell = row.CreateCell(0); cell.SetCellValue("Ширина, м"); cell.CellStyle = style3;
            ICell cell3 = row.CreateCell(1); cell3.SetCellValue(Math.Round((double)w, 2).ToString()); cell3.CellStyle = style4;

            IRow row = sheet.CreateRow();
            ICell cell1 = row.CreateCell(0);
            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(, , 0, 1));
            cell1.SetCellValue("Геометрические параметры канала:");
            cell1.CellStyle = style2;
            */

            sheet.SetColumnWidth(0, 70 * 256);
            int leng = type.Length+10;
            sheet.SetColumnWidth(1, leng * 256);

            using (FileStream stream = new FileStream(path+".xlsx", FileMode.Create, FileAccess.Write))
            {
                workbook.Write(stream);
            }

            return true;
        }
    }
}
