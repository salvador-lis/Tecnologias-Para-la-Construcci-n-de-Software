from datetime import datetime

class Longger:
    _instance = None

    def __new__(cls, *args, **kwargs):
        if not cls._instance:
            cls._instance = super(Longger, cls).__new__(cls)
        return cls._instance

    def __init__(self):
        self.logs=[]

    def log(self, message:str) -> None:
        self.logs.append(f"{datetime.now()}: {message}")

    def show_logs(self) -> list[str]:
        return self.logs
    
class Usuario :
    def __init__(self, nombre:str,usuario_id:int):
        self.nombre = nombre
        self.usuario_id = usuario_id
        self.logger = Longger()



    def registrar(self)-> None:
        self.logger.log(f"Usuario {self.nombre} con ID {self.usuario_id} registrado.")

    def agregar_pedido(self, pedido:str)-> None:
        self.logger.log(f"Usuario {self.nombre} con ID {self.usuario_id} agregó el pedido: {pedido}.")

    def get_pedidos(self)-> list[str]:
        return self.logger.show_logs()
    
class Pedido:
    def __init__(self, pedido_id:int, descripcion:str):
        self.pedido_id = pedido_id
        self.descripcion = descripcion
        self.logger = Longger()
        self.logger.log(f"Pedido {self.pedido_id} creado con la descripción: {self.descripcion}.")

    def procesar(self)-> None:
        self.logger.log(f"Pedido {self.pedido_id} procesado.")

    def cancelar(self)-> None:
        self.logger.log(f"Pedido {self.pedido_id} cancelado.")

    def mostrar_estado(self)-> list[str]:
        return self.logger.show_logs()
if __name__ == "__main__":
    usuario1 = Usuario("Alice", 1)
    usuario1.registrar()
    usuario1.agregar_pedido("Pizza")
    
    usuario2 = Usuario("Bob", 2)
    usuario2.registrar()
    usuario2.agregar_pedido("Sushi")
    
    pedido1 = Pedido(101, "Pizza")
    pedido1.procesar()
    
    pedido2 = Pedido(102, "Sushi")
    pedido2.cancelar()
    
    print("Logs de Usuario 1:")
    for log in usuario1.get_pedidos():
        print(log)
    
    print("\nLogs de Pedido 1:")
    for log in pedido1.mostrar_estado():
        print(log)
        


    


