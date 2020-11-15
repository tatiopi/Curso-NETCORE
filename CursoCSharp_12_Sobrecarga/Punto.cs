using System;
using System.Collections.Generic;
using System.Text;

    public class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto()
        {
            X = 0;
            Y = 0;
        }

        public Punto(int x , int y)
        {
            X = x;
            Y = y;
        }

        public Punto(int x)
        {
            X = x;
        }

        // Sobrcarga de operadores - 
        public static Punto operator+(Punto valor)
        {
            Punto nuevoPunto = new Punto();
            nuevoPunto.X = valor.X + 1;
            nuevoPunto.Y = valor.Y + 1;

            return nuevoPunto;
        }

        public static Punto operator -(Punto valor)
        {
            Punto nuevoPunto = new Punto();
            nuevoPunto.X = valor.X - 1;
            nuevoPunto.Y = valor.Y - 1;

            return nuevoPunto;
        }

        //Virgulilla alt + 126
        ~Punto()
        {
            X = 0;
            Y = 0;
        }

    }
