# Builder pattern

Es un patron de diseño creacional que permite un enfoque de construccion de objetos completos paso a paso

Separa el proceso de construccion de un objeto de su representacion

permite constriir diferentes tipos y representaciones de un objeto usando el mismo codigo.

# En resumen

## BUILDER separa la creación de un objeto complejo (el producto) de su proceso de construcción (el builder).

🧱 Paso a paso:

Objeto 1 — El “Producto” (por ejemplo, Hamburguesa)

Es la clase que representa el resultado final.

Normalmente no se llena todo en el constructor, sino que se le van asignando partes (atributos) a través del builder.

Su constructor suele ser vacío o muy simple.

Objeto 2 — El “Builder”

Es otra clase que sabe cómo construir el objeto 1 paso a paso.

Tiene métodos del tipo:

poner_pan(), poner_carne(), agregar_queso(), build()


Cada método configura una parte del objeto, y al final build() devuelve el producto completo.

A veces también hay un “Director” (otra clase) que usa el builder para crear versiones predefinidas (por ejemplo, “hamburguesa clásica” o “vegetariana”).

## Situaciones

Aplica cuando, por ejemplo, construimos un objeto que requiere muchos atributos para una instancia.

- User (name, age, mail, number, direction)

Dejar muchas partes en null durante la instancia puede ser confuso.

### Enfoque

- Sobrecarga / telescoping: de constructor, es decir, crear una sobrecarga que genere los atributos en null, y seguir sobrecargando dependiendo el caso.

- Cuando tenemos objetos similares y con pasos de construccion comun, dividirlo en una interfaz que tenga los pasos de construccion común

- Composite tree: omitir ejecucion de algunos pasos sin afectar el producto final
    - llamara a los pasos de forma recursiva, util para un arbol de objetos.

## Estructura:

```Mermaid
classDiagram
    class Cliente {
        +main()
    }

    class Director {
        -builder : Builder
        +setBuilder(b : Builder)
        +construirProducto()
    }

    class Builder {
        <<interface>>
        +reset()
        +buildParteA()
        +buildParteB()
        +getResultado() : Producto
    }

    class ConcreteBuilder1 {
        -producto : Producto1
        +reset()
        +buildParteA()
        +buildParteB()
        +getResultado() : Producto1
    }

    class ConcreteBuilder2 {
        -producto : Producto2
        +reset()
        +buildParteA()
        +buildParteB()
        +getResultado() : Producto2
    }

    class Producto1 {
    }

    class Producto2 {
    }

    Cliente --> Director
    Director --> Builder
    Builder <|.. ConcreteBuilder1
    Builder <|.. ConcreteBuilder2
```

## Beneficios

- LUEGO

## Consideraciones

- Requiere mayor conocimiento del cliente
- El codigo aumenta en cimplejidad debido a las clases del patrón

## Diferencias con factory

- Factory es una familia de objetos

- Builder se centra en construir objetos paso a paso.

# Builder Emilio

## Por que usarlo

Evita tener multiples constructores

Evitar atributos en new

Builder crea la casa con o sin ciertos datos. Es decir, construir la solucion de diversas formas.

### Funcionamiento

builder: constructor que declara los pasos para construir el producto, por ejemplo

construirParedes(), construirTecho(), etc.

---

### 💡 ¿Qué es la arquitectura (o patrón) *Builder*?

Imagina que quieres construir una **hamburguesa** 🍔.

* Algunas hamburguesas tienen queso, otras no.
* Algunas tienen doble carne, otras pollo.
* Algunas tienen pepinillos, otras no.

Si cada vez escribes un “constructor” distinto para cada tipo de hamburguesa, vas a acabar con un **lío enorme** de código.

Entonces aparece el **patrón Builder** y dice:

> “Oye, ¿por qué no separas el proceso de **cómo se construye** una hamburguesa de **qué ingredientes tiene**?”

---

### 🧱 ¿Cómo funciona?

1. **El "Builder" (constructor)**
   Es como el cocinero. Sabe *cómo* armar una hamburguesa, paso a paso: poner pan, luego carne, luego queso, etc.

2. **El "Director" (jefe de cocina)**
   Es el que le dice al cocinero qué tipo de hamburguesa quiere:

   * “Hazme una hamburguesa vegetariana” 🥬
   * “Hazme una con doble carne” 🍖

3. **El "Producto"**
   Es la hamburguesa final lista para servir 😋

---

### 🧩 ¿Qué tipo de arquitectura o patrón es?

El *Builder* no es una arquitectura completa, sino un **patrón de diseño** —más concretamente, un:

> 🧠 **Patrón creacional**

Los **patrones creacionales** se encargan de **cómo se crean los objetos** en un programa.
Otros ejemplos del mismo tipo son:

* `Singleton`
* `Factory Method`
* `Abstract Factory`
* `Prototype`

---

### 📚 En resumen:

| Concepto       | Explicación simple                                                                             |
| -------------- | ---------------------------------------------------------------------------------------------- |
| Qué es         | Un patrón que separa la construcción de un objeto complejo de su representación final          |
| Tipo           | Patrón **creacional**                                                                          |
| Para qué sirve | Crear objetos paso a paso, sin escribir mil constructores distintos                            |
| Ejemplo        | Construir una hamburguesa, un coche o una casa de distintas maneras, pero con el mismo proceso |

---

## Ejemplo de builder en python

### 🍔 Ejemplo: construir una **hamburguesa**

```python
# 1️⃣ El "Producto": lo que queremos construir
class Hamburguesa:
    def __init__(self):
        self.pan = None
        self.carne = None
        self.queso = False

    def __str__(self):
        return f"Hamburguesa con {self.pan}, carne de {self.carne}" + (" y queso" if self.queso else "")


# 2️⃣ El "Builder": sabe cómo armar la hamburguesa paso a paso
class HamburguesaBuilder:
    def __init__(self):
        self.hamburguesa = Hamburguesa()

    def poner_pan(self, tipo):
        self.hamburguesa.pan = tipo
        return self  # Permite encadenar métodos

    def poner_carne(self, tipo):
        self.hamburguesa.carne = tipo
        return self

    def agregar_queso(self):
        self.hamburguesa.queso = True
        return self

    def build(self):
        return self.hamburguesa


# 3️⃣ El "Director": indica cómo construir una hamburguesa específica
class Cocinero:
    def preparar_clasica(self):
        return (
            HamburguesaBuilder()
            .poner_pan("blanco")
            .poner_carne("res")
            .agregar_queso()
            .build()
        )

    def preparar_vegetariana(self):
        return (
            HamburguesaBuilder()
            .poner_pan("integral")
            .poner_carne("soya")
            .build()
        )


# 4️⃣ Uso
cocinero = Cocinero()
hamb1 = cocinero.preparar_clasica()
hamb2 = cocinero.preparar_vegetariana()

print(hamb1)  # 👉 Hamburguesa con blanco, carne de res y queso
print(hamb2)  # 👉 Hamburguesa con integral, carne de soya
```

---

### 💡 Qué pasa aquí

* `Hamburguesa` → el **producto final**.
* `HamburguesaBuilder` → define **cómo se construye** paso a paso.
* `Cocinero` → decide **qué receta usar** (el tipo de hamburguesa).

Así separas **el proceso de construcción** de **la definición del producto**.
Y si mañana quieres una hamburguesa “doble carne con bacon”, no cambias nada del código base: solo creas otra receta 🧑‍🍳