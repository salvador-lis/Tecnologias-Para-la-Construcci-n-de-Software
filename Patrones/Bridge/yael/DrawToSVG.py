from yael.DrawAPI import DrawAPI

class DrawToSVG(DrawAPI):
    def __init__(self):
        super().__init__()
        self._svg_elements : list

    def comenzar_dibujos(self):
        print("Dibujando...")

    def terminar_dibujos(self):
        print("Dibujo terminado...")

    def dibujar_rec(self, x, y, height, width, color, alpha):
        self._svg_elements.append(f'<rect cx="{x}" cy="{y}" alto="{width}" anchot="{height}" relleno="{color}" opacidad="{alpha}" />')

    def dibujar_circle(self, x, y, height, width, color, alpha):
        self._svg_elements.append(f'<circle cx={x} cy={y} alto={width} anchot={height} relleno="{color}" opacidad={alpha} />')