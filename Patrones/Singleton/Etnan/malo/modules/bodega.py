"""

"""

from modules.manejadordatos import ManejadorDatos

class Bodega():
    def __init__(self, archivo):
        self.datos = ManejadorDatos(archivo)

    def reabastecer(self, producto:str, cantidad:int):
        self.datos.actualizar(producto, cantidad)
        self.datos.guardar()