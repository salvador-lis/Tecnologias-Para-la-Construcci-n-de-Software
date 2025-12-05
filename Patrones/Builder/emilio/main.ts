import { promises as fs } from "fs";
import { HtmlReportBuilder } from "./HtmlReportBuilder";
import { XmlReportBuilder } from "./XmlReportBuilder";
import { PdfReportBuilder } from "./PdfReportBuilder";
import { ReportDirector } from "./ReportDirector";

async function main() {
  const director = new ReportDirector();

  const htmlBuilder = new HtmlReportBuilder();
  await director.constructReport(htmlBuilder);
  const htmlReport = await htmlBuilder.getResult();
  await fs.writeFile("reporte.html", htmlReport);
  console.log("Reporte HTML (reporte.html) generado con éxito.");

  console.log("\n========================================\n");

  const xmlBuilder = new XmlReportBuilder();
  await director.constructReport(xmlBuilder);
  const xmlReport = await xmlBuilder.getResult();
  await fs.writeFile("reporte.xml", xmlReport);
  console.log("Reporte XML (reporte.xml) generado con éxito.");

  console.log("\n========================================\n");

  const pdfBuilder = await PdfReportBuilder.create();
  await director.constructReport(pdfBuilder);
  const pdfBytes = await pdfBuilder.getResult();
  await fs.writeFile("reporte.pdf", pdfBytes);
  console.log("¡Reporte PDF (reporte.pdf) generado con éxito!");
}

main().catch(console.error);