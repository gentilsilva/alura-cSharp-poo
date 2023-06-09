﻿using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao = 0;

        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            Console.WriteLine("Aumentando a capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for(int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }

        public void Remover( ContaCorrente conta )
        {
            int indiceItem = -1;
            for(int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if(contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            for(int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void ExibirLista()
        {
            for(int i = 0; i < _itens.Length; i++)
            {
                if(_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($"Índice[{i}] = Conta: {conta.Conta}");
                }
            }
        }

        public ContaCorrente RecuperarContaNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }

        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperarContaNoIndice(indice);
            }
        }

        public ContaCorrente RetornarMaiorSaldo()
        {
            double saldoMaisAlto = 0;
            ContaCorrente contaSaldoMaisAlto = null;
            for(int i = 0 ; i < _itens.Length ; i++)
            {
                if (_itens[i] != null)
                {
                    if (_itens[i].Saldo > saldoMaisAlto)
                    {
                        saldoMaisAlto = _itens[i].Saldo;
                        contaSaldoMaisAlto = _itens[i];
                    }
                }
            }
            return contaSaldoMaisAlto;
        }
    }
}