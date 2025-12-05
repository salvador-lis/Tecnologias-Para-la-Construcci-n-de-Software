from yael.DrawAPI import DrawAPI

class DrawOnPaper(DrawAPI):
    def comenzar_dibujos(self):
        print("Dibujando...")

    def terminar_dibujos(self):
        print("Dibujo terminado...")

    def dibujar_rec(self, x, y, height, width, color, alpha):
        print("Rectangulo dibujado")

    def dibujar_circulo(self, x, y, radio, color, alpha):
        print("Circulo cibujado")