"""

"""

from modules.manejadordatos import ManejadorDatos

class Bodega:
    def __init__(self, file):
        self.datos = ManejadorDatos(file)

    def reabastecer(self, producto:str, cantidad:int):
        self.datos.actualizar(producto, cantidad)
        self.datos.guardar()