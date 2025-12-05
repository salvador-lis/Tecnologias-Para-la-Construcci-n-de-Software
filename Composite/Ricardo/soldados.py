import threading
import time
from tkinter import messagebox
from ordenes import Orden

class Soldado(Orden):
    def __init__(self, nombre, circulo, app):
        self.nombre = nombre
        self.circulo = circulo
        self.app = app

    def ejecutar(self):
        self.animar()
        messagebox.showinfo("Orden recibida", f"{self.nombre}: ¡Orden cumplida!")

    def animar(self):
        def mover():
            for _ in range(10):
                self.app.canvas.move(self.circulo["id"], 0, -3)
                self.app.actualizar_lineas()
                time.sleep(0.05)
            for _ in range(10):
                self.app.canvas.move(self.circulo["id"], 0, 3)
                self.app.actualizar_lineas()
                time.sleep(0.05)
        threading.Thread(target=mover, daemon=True).start()
