from abc import ABC,abstractclassmethod

class Ave(ABC):
    @abstractclassmethod
    def comer(self):
        pass
    def respirar(self):
        pass


class AveVoladora(Ave):
    @abstractclassmethod
    def volar(self):
        pass

class AveNadadora(Ave):
    @abstractclassmethod
    def nadar(self):
        pass

class Paloma(AveVoladora):
    def comer(self):
        print("Paloma esta comiendo")
    def respirar(self):
        print("Paloma esta respirando")
    
    