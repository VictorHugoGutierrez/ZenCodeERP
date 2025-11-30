using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ZenCodeERP.Utils
{
    public static class ExportadorRelatorio
    {
        public static void ExportarDataGridViewParaCsv(DataGridView grid)
        {
            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.");
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "relatorio.csv";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                var sb = new StringBuilder();

                // Cabeçalho
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    if (!grid.Columns[i].Visible) continue;

                    sb.Append(EscaparCsv(grid.Columns[i].HeaderText));
                    if (i < grid.Columns.Count - 1)
                        sb.Append(";");
                }
                sb.AppendLine();

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue;

                    for (int i = 0; i < grid.Columns.Count; i++)
                    {
                        if (!grid.Columns[i].Visible) continue;

                        var valor = row.Cells[i].Value?.ToString() ?? "";
                        sb.Append(EscaparCsv(valor));
                        if (i < grid.Columns.Count - 1)
                            sb.Append(";");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("CSV gerado com sucesso!");
            }
        }

        private static string EscaparCsv(string valor)
        {
            // Troca aspas por aspas duplas e envolve em aspas
            if (valor.Contains(";") || valor.Contains("\"") || valor.Contains("\n"))
            {
                valor = valor.Replace("\"", "\"\"");
                valor = $"\"{valor}\"";
            }
            return valor;
        }

        public static void ExportarDataGridViewParaPdf(DataGridView grid, string tituloRelatorio = "Relatório") 
        {
            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.");
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "relatorio.pdf";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(doc, stream);

                    doc.Open();

                    var fonteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                    Paragraph titulo = new Paragraph(tituloRelatorio + "\n\n", fonteTitulo);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    int colunasVisiveis = 0;
                    foreach (DataGridViewColumn col in grid.Columns)
                    {
                        if (col.Visible) colunasVisiveis++;
                    }

                    PdfPTable tabela = new PdfPTable(colunasVisiveis);
                    tabela.WidthPercentage = 100;

                    var fonteCabecalho = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9);
                    foreach (DataGridViewColumn col in grid.Columns)
                    {
                        if (!col.Visible) continue;

                        PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, fonteCabecalho));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Padding = 3;
                        tabela.AddCell(cell);
                    }

                    var fonteCelula = FontFactory.GetFont(FontFactory.HELVETICA, 8);
                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        if (row.IsNewRow) continue;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (!cell.OwningColumn.Visible) continue;

                            string texto = cell.Value?.ToString() ?? "";
                            PdfPCell pdfCell = new PdfPCell(new Phrase(texto, fonteCelula));
                            pdfCell.HorizontalAlignment = Element.ALIGN_LEFT;
                            pdfCell.Padding = 2;
                            tabela.AddCell(pdfCell);
                        }
                    }

                    doc.Add(tabela);
                    doc.Close();
                    writer.Close();
                }

                MessageBox.Show("PDF gerado com sucesso!");
            }
        }

    }
}
