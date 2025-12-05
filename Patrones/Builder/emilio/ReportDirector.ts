import { ReportBuilder } from "./ReportBuilder";

export class ReportDirector {

  public async constructReport(builder: ReportBuilder): Promise<void> {
      (builder).buildEncabezado();
      (builder).buildCuerpo();
      (builder).buildPieDePagina();
  }
}