"""

"""

import csv

class ManejadorDatos:
    
    def __init__(self, archivo):
        self.archivo = archivo
        self.inventario = self._cargar()

    def _cargar(self) -> dict:
        with open(self.archivo, "r", newline="") as f:
            lector = csv.reader(f)
            return {fila[0]: int(fila[1]) for fila in lector}
    
    def guardar(self):
        with open(self.archivo, "w", newline="") as f:
            writer = csv.writer(f)
            for producto, cantidad in self.inventario.items():
                writer.writerow([producto, cantidad])

    def actualizar(self, producto:str, cantidad:int):
        if producto in self.inventario:
            self.inventario[producto] += cantidad
        else:
            self.inventario[producto] = cantidad