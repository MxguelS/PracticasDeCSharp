/*
 Crear un programa en C# para clasificar la etapa de vida de una persona y calcular automáticamente el precio de su entrada al cine. 
El programa solicitará 1 valor de entrada: la edad de la persona (int). 
Ejecutará 3 operaciones: calcular el precio base de la entrada según la tarifa asignada por el switch, 
calcular un descuento especial por edad restando un porcentaje fijo obtenido del proceso, y calcular el costo final con un cargo por servicio incluido.
Llevará 1 estructura switch para definir la categoría de la entrada y su tarifa base según tramos de edad. Como resultado, entregará 2 valores de salida:
la etapa de vida detectada y el precio final a pagar por el boleto.

precioBase = tarifaBase
descuentoEspecial = precioBase * 0.10
costoFinal = (precioBase - descuentoEspecial) + 2.5 // Con cargo por servicio
 
 */


class ParcialSwicth
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la edad de la persona");
        int edad = int.Parse(Console.ReadLine());

      
        double tarifabase = 10;
        double descuentoEspecial;
        double precioBase = tarifabase;

        string tipo;
        switch (edad)
        {
            case <=10:
                tipo = "niño";
                descuentoEspecial = 0.10;
                break;

            case >= 60:
                tipo = "adulto mayor";
                descuentoEspecial = 0.15;
                break;

            case > 10:
                tipo = "cliente comun";
                descuentoEspecial = 0;
                    break;
            default:
                Console.WriteLine("Tipo de dato invalido");
                return;
        }
        precioBase = tarifabase * descuentoEspecial;
        double costoFinal = (tarifabase - precioBase)+ 2.5; // Con cargo por servicio

        Console.WriteLine($"Edad y tipo : {edad} : {tipo}");
        Console.WriteLine($"precio a pagar por el boleto: {costoFinal}");

    }
}