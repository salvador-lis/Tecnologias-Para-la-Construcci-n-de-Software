import { ReportBuilder } from "./ReportBuilder";

export class HtmlReportBuilder implements ReportBuilder {
  private html: string = "";

  buildEncabezado(): void {
    this.html += "<!DOCTYPE html>\n<html>\n<head><title>Reporte HTML</title></head>\n<body>\n";
    this.html += "\t<header><h1>Titulo del reporte</h1></header>\n";
  }

  buildCuerpo(): void {
    this.html += "\t<main><p>Contenido del html.</p></main>\n";
  }

  buildPieDePagina(): void {
    this.html += "\t<footer><p>Pie de página - 2025</p></footer>\n";
    this.html += "</body>\n</html>";
  }

  public async getResult(): Promise<string> {
    return this.html;
  }
}