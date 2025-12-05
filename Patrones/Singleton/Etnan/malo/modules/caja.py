"""

"""

from modules.manejadordatos import ManejadorDatos

class Caja:
    def __init__(self, archivo):
        self.datos = ManejadorDatos(archivo)

    def vender(self, producto:str, cantidad:int):
        self.datos.actualizar(producto, -cantidad)
        self.datos.guardar()