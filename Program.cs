using System;
class Program
{
    static void Main()
    {
        //1.  El Perfil de un Personaje 
        //Di el nombre de tu personaje
        Console.WriteLine("Escribe el nombre de tu personaje");
        string nombre = Console.ReadLine();
        //Nivel de tu personaje
        int nivel = 6;
        //Puntos de vida
        float puntos_de_vida = 45F;
        //¿Es un jefe? (aunque aqui no sé si esta bien que solo diga false)
        bool es_un_jefe = false;
        Console.WriteLine("Hola " + nombre + " tu nivel actual es de " + nivel + " y tienes " + puntos_de_vida + " puntos de vida " + es_un_jefe);
        //2. Conversión Implícita (De pequeño a grande) 
        int numero_entero = 8;
        long numero_largo;
        numero_largo = numero_entero;
        double numero_decimal = numero_largo;
        Console.WriteLine("Tu numero es: " + numero_largo);
        //3. Casting Explícito (Pérdida de precisión) 
        double precio_exacto = 25.89;
        int precio_redondeado;
        precio_redondeado = (int)precio_exacto;
        Console.WriteLine("El precio redondeado es: " + precio_redondeado);
        // al momento de correr el codigo, muestra "25" ya que lo redondea hacia abajo
        //4.De Texto a Número (Parse)
        //El error sucede ya que no toma el numero como un valor numerico, sino como texto tomandolo como un error
        Console.WriteLine("Ingresar un número: ");
        string entradaUsuario = Console.ReadLine();
        int v = int.Parse(entradaUsuario);
        int numero = v;
        int resultado = numero + 5;
        Console.WriteLine("El resultado de sumar 5 es: " + resultado);
        //5. El uso de la clase `Convert` 
        string valor_texto = "true";
        bool valor_booleano = Convert.ToBoolean(valor_texto);
        string valor_decimal = "25.5";
        double val_decimal = Convert.ToDouble(valor_decimal);
        Console.WriteLine("Tu valor booleano es: " + valor_booleano);
        Console.WriteLine("Tu valor decimal es: " + val_decimal);
        //6. El proceso inverso (Número a Texto)
        double pi = 3.14159265;
        string cadena = pi.ToString("F2");
        Console.WriteLine("Pi con dos decimales es igual a: " + cadena);
        // Ejercicio 7: Reto Final - Calculadora de IVA
        Console.WriteLine("Ingrese el precio del producto:");
        string precioTexto = Console.ReadLine();
        double precio = double.Parse(precioTexto);
        double iva = precio * 0.21;
        double total = precio + iva;
        int totalSinDecimales = (int)total;
        Console.WriteLine("El total a pagar (sin centavos) es: Q" + totalSinDecimales);
        Console.ReadLine();
    }
}