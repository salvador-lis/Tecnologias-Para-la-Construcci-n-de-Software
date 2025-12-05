import tkinter as tk
from soldados import Soldado
from escuadron import Escuadron

class App:
    def __init__(self, root):
        self.root = root
        self.root.title("Patrón Composite - StarCraft Simulation")
        self.root.geometry("500x500")
        self.root.config(bg="#202020")

        tk.Label(root, text="StarCraft: Órdenes Jerárquicas (Patrón Composite)",
                 fg="white", bg="#202020", font=("Arial", 13, "bold")).pack(pady=10)

        self.canvas = tk.Canvas(root, width=480, height=300, bg="#2c2c2c", highlightthickness=0)
        self.canvas.pack(pady=10)

        
        self.general_circle = self.crear_circulo(230, 60, "General Eric", "#ff4d4d")
        self.capitan_circle = self.crear_circulo(230, 160, "Capitán René", "#4d79ff")
        self.soldado1_circle = self.crear_circulo(150, 260, "Soldado Salvador", "#4dff88")
        self.soldado2_circle = self.crear_circulo(310, 260, "Soldado Luis", "#4dff88")

        
        self.conexiones = [
            (self.general_circle, self.capitan_circle),
            (self.capitan_circle, self.soldado1_circle),
            (self.capitan_circle, self.soldado2_circle)
        ]

        
        self.lineas = []
        self.actualizar_lineas()

        
        self.general = Escuadron("General Eric", self.general_circle, self)
        self.capitan = Escuadron("Capitán René", self.capitan_circle, self)
        self.soldado1 = Soldado("Soldado Salvador", self.soldado1_circle, self)
        self.soldado2 = Soldado("Soldado Luis", self.soldado2_circle, self)

        self.capitan.agregar(self.soldado1)
        self.capitan.agregar(self.soldado2)
        self.general.agregar(self.capitan)

       
        tk.Button(root, text="Orden del General Eric", command=self.general.ejecutar,
                  bg="#ff4d4d", fg="white", width=25, font=("Arial", 10, "bold")).pack(pady=5)
        tk.Button(root, text="Orden del Capitán René", command=self.capitan.ejecutar,
                  bg="#4d79ff", fg="white", width=25, font=("Arial", 10, "bold")).pack(pady=5)
        tk.Button(root, text="Orden directa a Salvador", command=self.soldado1.ejecutar,
                  bg="#4dff88", fg="black", width=25, font=("Arial", 10, "bold")).pack(pady=5)

    def crear_circulo(self, x, y, texto, color):
        r = 30
        id_figura = self.canvas.create_oval(x - r, y - r, x + r, y + r, fill=color, outline="white", width=2)
        texto_id = self.canvas.create_text(x, y + 50, text=texto, fill="white", font=("Arial", 9, "bold"))
        return {"canvas": self.canvas, "id": id_figura, "texto": texto_id, "color": color}

    def obtener_posicion_circulo(self, circulo):
        coords = self.canvas.coords(circulo["id"])
        x = (coords[0] + coords[2]) / 2
        y = (coords[1] + coords[3]) / 2
        return x, y

    def actualizar_lineas(self):
        for linea in self.lineas:
            self.canvas.delete(linea)
        self.lineas.clear()
        for padre, hijo in self.conexiones:
            x1, y1 = self.obtener_posicion_circulo(padre)
            x2, y2 = self.obtener_posicion_circulo(hijo)
            linea = self.canvas.create_line(x1, y1, x2, y2, fill="white", width=2)
            self.lineas.append(linea)
