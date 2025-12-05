export interface ReportBuilder {
  buildEncabezado(): void;
  buildCuerpo(): void;
  buildPieDePagina(): void;
  getResult(): Promise<string | Uint8Array>;
}