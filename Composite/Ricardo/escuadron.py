import threading
import time
from tkinter import messagebox
from ordenes import Orden

class Escuadron(Orden):
    def __init__(self, nombre, circulo, app):
        self.nombre = nombre
        self.circulo = circulo
        self.app = app
        self.subordinados = []

    def agregar(self, orden):
        self.subordinados.append(orden)

    def ejecutar(self):
        self.animar()
        messagebox.showinfo("Orden general", f"{self.nombre}: ¡Ejecuten la orden!")
        for o in self.subordinados:
            o.ejecutar()

    def animar(self):
        def mover():
            for _ in range(10):
                self.app.canvas.move(self.circulo["id"], 0, -4)
                self.app.actualizar_lineas()
                time.sleep(0.05)
            for _ in range(10):
                self.app.canvas.move(self.circulo["id"], 0, 4)
                self.app.actualizar_lineas()
                time.sleep(0.05)
        threading.Thread(target=mover, daemon=True).start()
