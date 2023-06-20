using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using PizzariaDaBiblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDevSistemas2023
{
    internal class ClassGeraPdf
    {
        readonly static string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly static string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        //métodos
        public static string pathArquivo(string nome)
        {
            SaveFileDialog savePath = new()
            {
                Title = "Selecione o local e o nome para salvar seu relatório",
                Filter = "Arquivo|*.pdf",
                FileName = nome + "-" + Convert.ToString(DateTime.Now).Replace("/", "-").Replace(":", "-") + ".pdf"
            };
            if (savePath.ShowDialog() == DialogResult.OK)
            {
                return Convert.ToString(savePath.FileName);
            }
            else
            {
                return "PizzariaDoZe.pdf";
            }
        }

        public static void PdfSabor(string pathArquivo, int id)
        {
            try
            {
                using PdfWriter pdfWriter = new(pathArquivo);
                using PdfDocument pdfDocument = new(pdfWriter);
                using Document document = new(pdfDocument, PageSize.A4.Rotate());
                //PageSize.A4 - vertical ou PageSize.A4.Rotate() - horizontal
                document.Add(new Paragraph("Pizzaria do Zé").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                document.Add(new Paragraph("Sabor" + ((id == 0) ? "es" : ": " + id)).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                document.Add(new LineSeparator(new SolidLine()));
                Table table = new(6, false);
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetTextAlignment(TextAlignment.LEFT);
                table.AddCell(new Cell().Add(new Paragraph("ID")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Nome")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Categoria")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Tipo")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Ingredientes")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Imagem")).SetBorder(Border.NO_BORDER));
                // realiza a busca no Banco de Dados
                SaborDAO saborDAO = new(provider, strConnection);
                Sabor sabor = new()
                {
                    Id = id,
                    Descricao = ""
                };
                DataTable linhas = saborDAO.Buscar(sabor);
                foreach (DataRow row in linhas.Rows)
                {
                    table.AddCell(new Cell().Add(new Paragraph(row[0].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[1].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(row[3].ToString())))).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(row[4].ToString())))).SetBorder(Border.NO_BORDER));
                    // busca e seleciona os itens do sabor
                    string auxIngredientes = "";
                    sabor.Id = int.Parse(row[0].ToString());
                    DataTable linhasIngredientes = saborDAO.BuscarItensSabor(sabor);
                    foreach (DataRow dr in linhasIngredientes.Rows)
                    {
                        auxIngredientes += dr[1].ToString() + "\n";
                    }
                    table.AddCell(new Cell().Add(new Paragraph(auxIngredientes)).SetBorder(Border.NO_BORDER));
                    // converte a imagem vinda do array de bytes do BD e adiciona na tabela, caso não consiga apresenta o texto Sem Imagem
                    try
                    {
                        table.AddCell(new Cell().Add(new iText.Layout.Element.Image(ImageDataFactory.Create((byte[])row[2]))).SetBorder(Border.NO_BORDER));
                    }
                    catch
                    {
                        table.AddCell(new Cell().Add(new Paragraph("Sem Imagem")).SetBorder(Border.NO_BORDER));
                    }
                }
                //adiciona a tabela criada, já com os dados, no documento
                document.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
