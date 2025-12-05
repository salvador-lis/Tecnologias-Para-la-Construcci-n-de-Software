using System;
using System.IO;
using SkiaSharp;

namespace ProxyImagenDemo
{
    public class ImagenReal : IImagen
    {
        private readonly string _rutaArchivo;

        public ImagenReal(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
            CargarDesdeDisco(); // simula operación costosa
        }

        [Obsolete]
        private void CargarDesdeDisco()
        {
            Console.WriteLine("[ImagenReal] Preparando imagen (generar/cargar)...");
            if (!File.Exists(_rutaArchivo))
            {
                int w = 900, h = 540;

                using var bitmap = new SKBitmap(w, h);
                using var canvas = new SKCanvas(bitmap);
                canvas.Clear(new SKColor(240, 245, 255));

                // Fondo (degradado)
                using (var paint = new SKPaint())
                {
                    paint.IsAntialias = true;
                    var shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(w, h),
                        new[] { new SKColor(210, 230, 255), new SKColor(240, 245, 255) },
                        null,
                        SKShaderTileMode.Clamp);
                    paint.Shader = shader;
                    canvas.DrawRect(new SKRect(0, 0, w, h), paint);
                }

                // Marco
                using (var pen = new SKPaint { IsAntialias = true, Color = SKColors.DimGray, StrokeWidth = 6, Style = SKPaintStyle.Stroke })
                {
                    canvas.DrawRect(new SKRect(20, 20, w - 20, h - 20), pen);
                }

                // Textos
                using var titlePaint = new SKPaint { IsAntialias = true, Color = SKColors.Black, TextSize = 28, Typeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyle.Bold) };
                using var textPaint = new SKPaint { IsAntialias = true, Color = SKColors.Black, TextSize = 18, Typeface = SKTypeface.FromFamilyName("Segoe UI") };

                canvas.DrawText("Mi Imagen on-demand", 40, 60, titlePaint);
                canvas.DrawText("Este .jpg se crea sólo cuando el cliente lo solicita (lazy loading).", 40, 110, textPaint);
                canvas.DrawText("Siguientes llamadas reutilizan el archivo existente sin recrearlo.", 40, 140, textPaint);

                // "Cámara" decorativa
                using (var body = new SKPaint { IsAntialias = true, Color = new SKColor(60, 60, 60) })
                    canvas.DrawRect(new SKRect(650, 70, 830, 190), body);

                using (var lens = new SKPaint { IsAntialias = true, Color = new SKColor(120, 200, 255) })
                    canvas.DrawOval(new SKRect(740, 110, 810, 180), lens);

                using (var flash = new SKPaint { IsAntialias = true, Color = new SKColor(255, 255, 180) })
                    canvas.DrawRect(new SKRect(660, 80, 690, 95), flash);

                // Sello/fecha
                string sello = $"Generada: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                canvas.DrawText("Proxy evita trabajo innecesario hasta que se usa.", 40, h - 40, textPaint);
                canvas.DrawText(sello, 40, h - 70, textPaint);

                // Guardar como JPG
                using var image = SKImage.FromBitmap(bitmap);
                using var data = image.Encode(SKEncodedImageFormat.Jpeg, 90);
                using var fs = File.OpenWrite(_rutaArchivo);
                data.SaveTo(fs);

                Console.WriteLine("[ImagenReal] Imagen generada: " + Path.GetFullPath(_rutaArchivo));
            }
            else
            {
                Console.WriteLine("[ImagenReal] Imagen ya existe, se reutiliza: " + Path.GetFullPath(_rutaArchivo));
            }
        }

        public string Mostrar()
        {
            Console.WriteLine("[ImagenReal] Mostrando imagen: " + _rutaArchivo);
            return _rutaArchivo;
        }
    }
}