/******************************************************************************
Autor:          Julián A. Peña
Fecha:          18 de Julio de 2024
Descripción:    Monitorea la temperatura en diferentes 
                zonas del Jardín Botánico.
*******************************************************************************/

using System;

class JardinBotanico
{
    static string[] zonas = new string[10];
    static double[] temperaturas = new double[10];
    static int cantidadZonas = 0;

    static void Main()
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n--- Jardín Botánico - Control de Temperatura ---");
            Console.WriteLine("1. Agregar zona y temperatura");
            Console.WriteLine("2. Mostrar todas las zonas y temperaturas");
            Console.WriteLine("3. Actualizar temperatura de una zona");
            Console.WriteLine("4. Eliminar zona");
            Console.WriteLine("5. Buscar temperatura de una zona");
            Console.WriteLine("6. Ordenar zonas por temperatura");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AgregarZona();
                    break;
                case "2":
                    MostrarZonas();
                    break;
                case "3":
                    ActualizarTemperatura();
                    break;
                case "4":
                    EliminarZona();
                    break;
                case "5":
                    BuscarTemperatura();
                    break;
                case "6":
                    OrdenarPorTemperatura();
                    break;
                case "7":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void AgregarZona()
    {
        if (cantidadZonas < zonas.Length)
        {
            Console.Write("Ingrese el nombre de la zona: ");
            zonas[cantidadZonas] = Console.ReadLine();
            Console.Write("Ingrese la temperatura de la zona: ");
            temperaturas[cantidadZonas] = Convert.ToDouble(Console.ReadLine());
            cantidadZonas++;
            Console.WriteLine("Zona agregada con éxito.");
        }
        else
        {
            Console.WriteLine("No se pueden agregar más zonas. Capacidad máxima alcanzada.");
        }
    }

    static void MostrarZonas()
    {
        if (cantidadZonas == 0)
        {
            Console.WriteLine("No hay zonas registradas.");
            return;
        }

        for (int i = 0; i < cantidadZonas; i++)
        {
            Console.WriteLine($"Zona: {zonas[i]}, Temperatura: {temperaturas[i]}°C");
        }
    }

    static void ActualizarTemperatura()
    {
        Console.Write("Ingrese el nombre de la zona a actualizar: ");
        string nombreZona = Console.ReadLine();
        int indice = Array.IndexOf(zonas, nombreZona);
        
        if (indice != -1)
        {
            Console.Write("Ingrese la nueva temperatura: ");
            temperaturas[indice] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperatura actualizada con éxito.");
        }
        else
        {
            Console.WriteLine("Zona no encontrada.");
        }
    }

    static void EliminarZona()
    {
        Console.Write("Ingrese el nombre de la zona a eliminar: ");
        string nombreZona = Console.ReadLine();
        int indice = Array.IndexOf(zonas, nombreZona);
        
        if (indice != -1)
        {
            for (int i = indice; i < cantidadZonas - 1; i++)
            {
                zonas[i] = zonas[i + 1];
                temperaturas[i] = temperaturas[i + 1];
            }
            cantidadZonas--;
            Console.WriteLine("Zona eliminada con éxito.");
        }
        else
        {
            Console.WriteLine("Zona no encontrada.");
        }
    }

    static void BuscarTemperatura()
    {
        Console.Write("Ingrese el nombre de la zona a buscar: ");
        string nombreZona = Console.ReadLine();
        int indice = Array.IndexOf(zonas, nombreZona);
        
        if (indice != -1)
        {
            Console.WriteLine($"La temperatura de {nombreZona} es {temperaturas[indice]}°C");
        }
        else
        {
            Console.WriteLine("Zona no encontrada.");
        }
    }

    static void OrdenarPorTemperatura()
    {
        for (int i = 0; i < cantidadZonas - 1; i++)
        {
            for (int j = 0; j < cantidadZonas - i - 1; j++)
            {
                if (temperaturas[j] > temperaturas[j + 1])
                {
                    // Intercambiar temperaturas
                    double tempTemp = temperaturas[j];
                    temperaturas[j] = temperaturas[j + 1];
                    temperaturas[j + 1] = tempTemp;

                    // Intercambiar zonas
                    string tempZona = zonas[j];
                    zonas[j] = zonas[j + 1];
                    zonas[j + 1] = tempZona;
                }
            }
        }
        Console.WriteLine("Zonas ordenadas por temperatura.");
        MostrarZonas();
    }
}
