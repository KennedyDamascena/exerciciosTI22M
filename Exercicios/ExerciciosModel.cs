using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExerciciosModel
    {
        //area de Variaveis
        private double area;
        private double IMC;
        //metodo construtor

        public ExerciciosModel() 
        {
            this.area = 0;
            this.IMC = 0;
        }//Fim do Construtor

        //Metodo Get e Set
        public double ModificarArea
        {
            get { return this.area; }
            set { this.area = value; }
        }//Fim do Metodo getSet

        public double ModificarIMC
        {
            get { return this.IMC; } 
            set {this.IMC = value; } 
        }
        

        //1.Leia um numero e exiba seu triplo
        public int Triplo(int num)
        {
            return num * 3;
        }//fim do metodo

        //2.Leia um numero e exiba sua metadade
        public int Metade(int num) 
        {
            return num / 2;
        }//Fim do Método

        //8.Calcule a area de um losango com base nas diagonais
        //area =diagonalmaior * diagonalmenor /2

        public double AreaLosango(double diagonaMaior,double diagonalMenor)
        {
            // Validação
            if (diagonalMenor > 0 && diagonalMenor>0)
            {
                ModificarArea = (diagonaMaior * diagonalMenor) / 2;
            }
            else
            {
                ModificarArea = -1;//Criando Um alerta com simbolo
            }//fim do if... else            
            return ModificarArea;
        }//Fim do Método

        //9.Calcule o Volume de um cilindro a partir do raio e altura
        //volume =math.pi * math.pow(raio,2)* altura
        public double VolumeCilindro(double raio, double altura)
        {
           if(raio> 0 && altura>0)
            {
                return Math.PI* Math.Pow(raio,2)* altura;
            }
            else 
            {
                return -1;
            }
        }//Fim do Método

        //16.Leia a altura e peso de uma pessoa e calcule o IMC
        //se IMC < 18.5 Abaixo do peso
        //Se IMC >=18.5 e IMC < 24.9 - Peso Normal
        //Se Imc >= 24.9 e IMC< 29.9 - sobrepeso
        //Se IMC >=29.9 e IMC < 34.4 - Obesidade Grau 1
        //Se IMC >=34.4 e IMC < 39.9 - Obesidade Grau 2 
        //Se IMC >= 39.9               Obesidade Grau 3
        //devolva o grau
        public string CalcularIMC(double peso, double altura)
        {
            string resultado = "";
            if (peso > 0 && altura >= 0)
            {
                //Calculei
                ModificarIMC = peso / Math.Pow(altura, 2);
                //Verificando resposta
                resultado = "\nSeu IMC é:" + ModificarIMC;
                if (ModificarIMC < 18.5)
                {
                    resultado += "-Abaixo do peso";
                }
                else if (ModificarIMC <24.9)
                {
                    resultado += "Peso Normal";
                }
                else if(ModificarIMC<29.9)
                {
                    resultado += "Sobrepeso";
                }
                else if (ModificarIMC < 34.9)
                {
                    resultado += "Obesidade Grau 1";
                }
                else if (ModificarIMC < 39.9)
                {
                    resultado += "Obesidade Grau 2";
                }
                else
                {
                    resultado += "Obesidade Grau 3";
                }//Fim do resultado If
            }//Fim do If
            else
            {
                resultado = "Impossivel Calcular IMC com Peso e/ou ALTURA NEGATIVO"; 
            }
            return resultado;
        } //Fim do IMC

        //5. Converta um valor em horas para minutos
        public double ValorMinutos(double hora)
        {
            return hora * 60;
        }//fim




    }//Fim da Classe
}//Fim do Projeto
