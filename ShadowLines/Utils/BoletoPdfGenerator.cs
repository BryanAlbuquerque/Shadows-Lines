using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using ShadowLines.Models;
using System;
using System.Diagnostics;
using System.IO;

namespace ShadowLines.Utils
{
    public static class BoletoPdfGenerator
    {
        public static void GerarBoleto(AgendamentoModel agendamento)
        {
            string pasta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Boletos"
            );

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            string caminhoArquivo =
                Path.Combine(pasta, $"Boleto_{agendamento.AgendamentoID}.pdf");

            PdfWriter writer = new PdfWriter(caminhoArquivo);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // 🔹 Título
            var fonteNegrito = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            document.Add(new Paragraph("BOLETO DE PAGAMENTO")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(18)
                .SetFont(fonteNegrito));

            document.Add(new Paragraph("\n"));

            // 🔹 Dados do cliente
            document.Add(new Paragraph($"Cliente: {agendamento.NomeCliente}"));
            document.Add(new Paragraph($"Data do Agendamento: {agendamento.DataAgendamento:dd/MM/yyyy}"));
            document.Add(new Paragraph($"Serviço: {agendamento.Servicos}"));
            document.Add(new Paragraph($"Valor: R$ {agendamento.Valor:N2}"));

            document.Add(new Paragraph("\n"));

            // 🔹 Linha separadora
            document.Add(new Paragraph("-----------------------------------------------------"));

            // 🔹 Dados fictícios de boleto
            document.Add(new Paragraph("Linha Digitável: 34191.79001 01043.510047 91020.150008 5 87770000015000"));
            document.Add(new Paragraph("Vencimento: " + DateTime.Now.AddDays(5).ToString("dd/MM/yyyy")));

            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("Este boleto é válido para pagamento até a data de vencimento."));

            document.Close();

            // 🔹 Abrir automaticamente
            Process.Start(new ProcessStartInfo()
            {
                FileName = caminhoArquivo,
                UseShellExecute = true
            });
        }
    }
}
