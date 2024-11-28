﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public static class Carro_Util
    {
        private static Carro[] carros = new Carro[100]; // Limite de 100 carros
        private static int count = 0; // Para llevar la cuenta de cuántos carros hay

        public static void Crear(Carro carro)
        {
            if (count < carros.Length)
            {
                carros[count] = carro;
                count++;
            }
            else
            {
                Console.WriteLine("No se pueden agregar más carros.");
            }
        }
        public static void Listar()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(carros[i]);
            }
        }
        public static void Eliminar(string placa)
        {
            for (int i = 0; i < count; i++)
            {
                if (carros[i].Placa == placa)
                {
                    // Desplazar los elementos hacia la izquierda
                    for (int j = i; j < count - 1; j++)
                    {
                        carros[j] = carros[j + 1];
                    }
                    carros[count - 1] = null; // Eliminar el último elemento
                    count--;
                    Console.WriteLine($"Carro con placa {placa} eliminado.");
                    return;
                }
            }
            Console.WriteLine("Carro no encontrado.");
        }
    } 

}

