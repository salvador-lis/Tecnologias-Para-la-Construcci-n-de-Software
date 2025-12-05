"""

"""

import csv

class ManejadorDatos:
    _instancia = None

    def __new__(cls, archivo):
        if cls._instancia is None:
            cls._instancia = super().__new__(cls)
            cls._instancia._inicializado = False
        return cls._instancia
    
    def __init__(self, archivo):
        if not self._inicializado:
            self.archivo = archivo
            self._inventario = self._cargar()
            self._inicializado = True

    def _cargar(self) -> dict:
        with open(self.archivo, "r", newline="") as f:
            reader = csv.reader(f)
            return {fila[0]: int(fila[1]) for fila in reader}
        
    def guardar(self):
        with open(self.archivo, "w", newline="") as f:
            writer = csv.writer(f)
            for producto, cantidad in self._inventario.items():
                writer.writerow([producto, cantidad])

    def actualizar(self, producto:str, cantidad:int):
        if producto in self._inventario:
            self._inventario[producto] += cantidad
        else:
            self._inventario[producto] = cantidad