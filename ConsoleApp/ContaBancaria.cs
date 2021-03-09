using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp{
    class ContaBancaria{

        //dados que serão setados
        public int Count { get; private set; }
        public string Name { get; set; }
        public string Bank { get; set; }
        public double Sald { get; private set; }

        // construtor 
       public ContaBancaria(int count, string name, string bank) {
            Count = count;
            Name = name;
            Bank = bank;
        }
        //construtor
        public ContaBancaria(int count, string name, string bank, double depositInitial): this (count,name,bank){
            Deposity(depositInitial);
        }

        //operação de saque e depósito 
        public void Deposity(double deposity){
            Sald += deposity;
        }
        public void Looting(double looting){
            Sald -= looting + 5.0; // utilizando uma taxa por cada operação no saque
        }

        // informações totais atualizadas
        public override string ToString(){
            return "Count : "
                + Count
                + ", "
                + "Name : "
                + Name
                + ", "
                + "Bank : "
                + Bank
                + ", "
                + "Sald : "
                + Sald.ToString("F2", CultureInfo.InvariantCulture);
             }

        }
           
    }

