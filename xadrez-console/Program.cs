﻿using System;
using tabuleiro;
using xadrez_console;
using xadrez;

namespace tabuleiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
           
            tab.ColocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadKey();
        }
    }
}
