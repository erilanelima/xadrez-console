﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());
                Console.ReadLine();
            } catch (TabuleiroException ex) {
                Console.WriteLine(ex.Message);
            }
       
        }
    }
}

