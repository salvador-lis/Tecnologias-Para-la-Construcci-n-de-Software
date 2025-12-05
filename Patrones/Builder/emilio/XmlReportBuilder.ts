import { ReportBuilder } from "./ReportBuilder";

export class XmlReportBuilder implements ReportBuilder {
  private xml: string = "";

  buildEncabezado(): void {
    this.xml += "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n";
    this.xml += "<reporte>\n";
    this.xml += "\t<encabezado>\n\t\t<titulo>Encabezado del Reporte</titulo>\n\t</encabezado>\n";
  }

  buildCuerpo(): void {
    this.xml += "\t<cuerpo>\n\t\t<contenido>Este es el contenido principal del reporte.</contenido>\n\t</cuerpo>\n";
  }

  buildPieDePagina(): void {
    this.xml += "\t<pie>\n\t\t<texto>Pie de página - 2025</texto>\n\t</pie>\n";
    this.xml += "</reporte>";
  }

  public async getResult(): Promise<string> {
    return this.xml;
  }
}