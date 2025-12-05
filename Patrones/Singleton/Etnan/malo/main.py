"""

"""

from modules.caja import Caja
from modules.bodega import Bodega

def main():
    file = "./malo/docs/db.csv"
    caja = Caja(file)
    bodega = Bodega(file)

    caja.vender("huevo", 10)
    bodega.reabastecer("huevo", 3)

if __name__=="__main__":
    main()