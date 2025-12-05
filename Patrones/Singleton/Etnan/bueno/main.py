"""

"""

from modules.bodega import Bodega
from modules.caja import Caja

def main():
    file = "./bueno/docs/db.csv"
    caja = Caja(file)
    bodega = Bodega(file)

    producto = "oreos"

    caja.vender(producto, 5)
    bodega.reabastecer(producto, 3)

if __name__ == "__main__":
    main()