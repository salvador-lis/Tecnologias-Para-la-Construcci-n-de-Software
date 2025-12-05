import { ReportBuilder } from "./ReportBuilder";
import { PDFDocument, StandardFonts, rgb } from "pdf-lib";

export class PdfReportBuilder implements ReportBuilder {
  private pdfDoc: PDFDocument;
  private page;

  constructor() {
  }

  private async initialize() {
    this.pdfDoc = await PDFDocument.create();
    this.page = this.pdfDoc.addPage();
  }

  public static async create(): Promise<PdfReportBuilder> {
    const builder = new PdfReportBuilder();
    await builder.initialize();
    return builder;
  }

  async buildEncabezado(): Promise<void> {
    const { width, height } = this.page.getSize();
    const font = await this.pdfDoc.embedFont(StandardFonts.HelveticaBold);

    this.page.drawText("Encabezado del Reporte", {
      x: 50,
      y: height - 50,
      font: font,
      size: 24,
      color: rgb(0, 0, 0),
    });
  }

  async buildCuerpo(): Promise<void> {
    const font = await this.pdfDoc.embedFont(StandardFonts.Helvetica);

    this.page.drawText("Este es el contenido principal del reporte, generado de forma real.", {
      x: 50,
      y: 700,
      font: font,
      size: 12,
      color: rgb(0.2, 0.2, 0.2),
    });
  }

  async buildPieDePagina(): Promise<void> {
    const font = await this.pdfDoc.embedFont(StandardFonts.HelveticaOblique);

    this.page.drawText("Pie de página - 2025", {
      x: 50,
      y: 50,
      font: font,
      size: 10,
      color: rgb(0.5, 0.5, 0.5),
    });
  }

  async getResult(): Promise<Uint8Array> {
    return this.pdfDoc.save();
  }
}