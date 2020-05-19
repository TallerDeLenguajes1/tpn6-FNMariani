# Trabajo Practico N°6
## Ejercicio 4:
### ¿String es un tipo por valor o un tipo por referencia?
En el esquema siguiente se ofrece información general del sistema de tipos de C#.

+ Tipos de valor
  + Tipos simples
    + Entero con signo: sbyte, short, int,long
    + Entero sin signo: byte, ushort, uint,ulong
    + Caracteres Unicode: char
    + Punto flotante binario IEEE: float, double
    + Punto flotante decimal de alta precisión: decimal
    + Booleano: bool
  + Tipos de enumeración
    + Tipos definidos por el usuario con el formato enum E {...}
  + Tipos de estructura
    + Tipos definidos por el usuario con el formato struct S {...}
  + Tipos de valores que aceptan valores NULL
    + Extensiones de todos los demás tipos de valor con un valor null
  + Tipos de valor de tupla
    + Tipos definidos por el usuario con el formato (T1, T2, ...)
+ Tipos de referencia
  + Tipos de clase
    + Clase base definitiva de todos los demás tipos: object
    + **Cadenas Unicode: string**
    + Tipos definidos por el usuario con el formato class C {...}
  + Tipos de interfaz
    + Tipos definidos por el usuario con el formato interface I {...}
  + Tipos de matriz
    + Unidimensional y multidimensional; por ejemplo, int[] y int[,]
  + Tipos delegados
    + Tipos definidos por el usuario con el formato delegate int D(...)
    
Como vemos, string es un tipo por referencia.

    
### ¿Qué secuencias de escape tiene el tipo string?
Secuencia | Nombre de caracter
------------- | -------------
\' | Comilla simple
\" | Comilla doble
\\ | Barra diagonal inversa
\0 | Null
\a | Alerta
\b | Retroceso
\f | Avance de pagina
\n | Nueva línea
\r | Retorno de carro
\t | Tabulación horizontal
\v | Tabulación vertical
\u | Unicode (UTF-16)
\U | Unicode (UTF-32)
\x | Unicode similar a "\u"

### ¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?
**El arroba delante de una cadena:**
Se utiliza para interpretar literalmente la cadena. Es decir, no se presta atencion a secuencias de escape, saltos de linea, u otro simbolo que pudiese molestar al momento de compilar.
Esto es muy util para escribir por ejemplo rutas de archivos o carpetas.

**El arroba delante de una palabra reservada:**
Esto nos permite utilizar como nombres de variables o clases palabras reservadas.
Por ejemplo, @bool.

## Ejercicio 5) Expresiones Regulares:

### ¿Funcionan únicamente en C#?
Las expresiones regulares no solo funcionan en C# sino tambien en varios otros lenguajes como Python, Java, Ruby, PHP, Swift, etc.

### ¿En qué casos le parecen útiles?
 * Permiten encontrar porciones específicas de texto dentro de una cadena más grande.
 * En campos de texto se usa para asegurarse de que los datos coinciden con el formato requerido. Por ejemplo, en las direcciones de correo electrónico. 
 * Se pueden utilizar para reemplazar texto con unas características concretas por otro.

### ¿Cómo se hace uso de estas en C#?
El eje del procesamiento de texto mediante expresiones regulares, viene representado por el objeto **System.Text.RegularExpressions.Regex** en .NET. 
 Su uso es a traves de los métodos de la clase **Regex**.