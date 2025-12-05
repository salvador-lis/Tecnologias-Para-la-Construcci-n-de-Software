"""

"""

from modules.manejadordatos import ManejadorDatos

class Caja:
    def __init__(self, file):
        self.datos = ManejadorDatos(file)

    def vender(self, producto:str, cantidad:int):
        self.datos.actualizar(producto, -cantidad)
        self.datos.guardar()