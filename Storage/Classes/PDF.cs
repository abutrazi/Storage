using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Storage.Classes
{
   /*This class describe PDF File */
    public class PDF
    {
        // Variables
        private Document doc;
        private Font myFont;
        private DBSQL datab = DBSQL.Instance;


        // C'tor with no params which creates PDF file with a default name
        public PDF()
        {
            doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("NewFile.pdf", FileMode.Create));
            doc.Open();
        }

        // C'tor that receives a file name as a parameter and creates a new PDF file with the received file name
        public PDF(string fileName)
        {
            doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(fileName + ".pdf", FileMode.Create));
            doc.Open();
        }
        //Function to set title 
        public void SetTitle(string title)
        {
            myFont = new Font(Font.FontFamily.COURIER, 18, Font.BOLD);
            myFont.Color = BaseColor.BLACK;
            Paragraph p = new Paragraph(title, myFont);
            p.Alignment = Element.ALIGN_CENTER;
            doc.Add(p);
            doc.Add(new Paragraph("\n\n", myFont));
        }
       
        // Method that sets a width for table cells
        private float[] WidthCell(int len)
        {
            float[] widthCell = new float[len];
            int i;
            for (i = 0; i < len; i++)
            {
                widthCell[i] = 10;
            }
            return widthCell;
        }
        // Method that adds a new cell
        private PdfPCell NewCell(string pharse)
        {
            PdfPCell cell = new PdfPCell();
            cell.GrayFill = 0.7F;
            cell.FixedHeight = 20;
            cell.BorderColor = BaseColor.GRAY;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Phrase = new Phrase(pharse);
            return cell;
        }
        private PdfPCell NewHeaderCell(string name)
        {
            PdfPCell cell = NewCell(name);
            cell.BackgroundColor = BaseColor.BLUE;
            return cell;
        }

        // Method that closes PDF file
        public void CloseReport()
        {
            doc.Close();
        }
        //Function to set table of products in PDF file
        public void SetProductsTable(Product[] p)
        {
            int i;
            PdfPTable pTable = new PdfPTable(4);
            pTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pTable.SetTotalWidth(WidthCell(4));

            pTable.AddCell(NewHeaderCell("Code"));
            pTable.AddCell(NewHeaderCell("Name"));
            pTable.AddCell(NewHeaderCell("Size"));
            pTable.AddCell(NewHeaderCell("Price"));


            for (i = 0; i < p.Length; i++)
            {
                pTable.AddCell(NewCell(p[i].ProdCode.ToString()));
                pTable.AddCell(NewCell(p[i].ProdName));
                pTable.AddCell(NewCell(p[i].ProdSize));
                pTable.AddCell(NewCell(p[i].ProdPrice.ToString()));

            }
            doc.Add(pTable);
        }
       
       //Function to set table of order details in PDf file  
        public void SetOrderDetailsTable(OrderDetails[] order)
        {
            int i;
            PdfPTable pTable = new PdfPTable(3);
            pTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pTable.SetTotalWidth(WidthCell(3));

            

            pTable.AddCell(NewHeaderCell("Product Code"));
            pTable.AddCell(NewHeaderCell("Product Name"));
            pTable.AddCell(NewHeaderCell("Quantity"));



            for (i = 0; i < order.Length; i++)
            {
                pTable.AddCell(NewCell(order[i].ProductCode.ToString()));
                pTable.AddCell(NewCell(order[i].ProductName));
                pTable.AddCell(NewCell(order[i].Quantity.ToString()));
            }
            doc.Add(pTable);
        }
        //Function to set tabel of order details with sum of quantity of products in PDF file 
        public void SetsumTable(OrderDetails[] order)
        {
            int i;
            PdfPTable pTable = new PdfPTable(3);
            pTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pTable.SetTotalWidth(WidthCell(3));



            pTable.AddCell(NewHeaderCell("Code"));
            pTable.AddCell(NewHeaderCell("Name"));
            pTable.AddCell(NewHeaderCell("Quantity"));


            for (i = 0; i < order.Length; i++)
            {
               pTable.AddCell(NewCell(order[i].ProductCode.ToString()));
               pTable.AddCell(NewCell(order[i].ProductName.ToString()));
               pTable.AddCell(NewCell((order[i].Quantity.ToString())));
            }
            doc.Add(pTable);
        }
    }
}
