using System;

namespace Panaderia;

public class MostrarFacturas{
    public static void Ejecutar(){

        foreach (var item in FacturaRepositorio.ListaFacturas())
            {
                item.Imprimir();
            }
    }
}