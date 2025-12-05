"""

"""

from datetime import datetime, date

class Logger:
    def __init__(self):
        self.logs = []

    def log(self, mensaje:str):
        self._logs.append(f'[{datetime.strftime("%Y-%m-%d %H:%M")}] {mensaje}')

    def show_logs(self) -> list[str]:
        return self.logs
    
class User:
    def __init__(self, id:int, name:str):
        self.id = id
        self.name = name
        self.pedidos: list["Pedido"] = []
        self.logger = Logger()

    def registrar(self):
        self.logger.log(f"El usuario {self.name} se ha registrado")

    def add_pedido(self, pedido:"Pedido"):
        self.pedidos.append(pedido)
        self.logger.log(f"El pedido {pedido} se agrego al usuario {self.name}")

    def get_pedidos(self) -> list["Pedido"]:
        return self.pedidos


class Pedidio:
    def __init__(self, id:int, fecha:date, monto:float):
        self.id = id
        self.fecha = fecha
        self.monto = monto
        self.estado = "Pendiente"
        self.logger = Logger()

    def procesar(self):
        self.estado = "Procesado"
        self.logger.log(f"El pedido {self.id} se proceso")

    def cancelado(self):
        self.estado = "Cancelado"
        self.logger.log(f"El pedido {self.id} se cancelado")

    def mostrar_detalles(self):
        return (f"Pedido: {self.fecha} - {self.fecha} - {self.monto} - {self.estado}")
    
if __name__ == "__main__":
    user = User(1, "Pedro")
    user.registrar()

    p1 = Pedidio(1, date.today().strftime(), 4000.5)