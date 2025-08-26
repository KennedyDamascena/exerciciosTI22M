using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExerciciosControl
    {
        private int opcao;
        public ExerciciosModel modelo;//Criando Conexão com a Classe Modelo
        public ExerciciosControl() 
        {
            this.opcao = 0;
            this.modelo= new ExerciciosModel();//Instanciando para Usar metodos
        }//Fim do Método

        public int ModificarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value;}
        }//Fim Do Método 

        public void MostrarMenu()
        {
            Console.WriteLine("\nMenu" +
                "\n0. Sair"+
                "\n1. Exercicio 1" +
                "\n2. Exercicio 2" +
                "\n5. Exercicio 5" +
                "\n8. Exercicio 8" +
                "\n9. Exercicio 9" +
                "\n16. Exercicio 16");
            ModificarOpcao=Convert.ToInt32(Console.ReadLine());
        }//Fim do Metodo MostraMenu
        public void ExecutarMenu()
        {
            do
            {
                //Chamar o Menu
                MostrarMenu();
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("OBRIGADO!!!");
                        break;
                    case 1:
                        Console.WriteLine("Exercicio 01 ");
                        Console.WriteLine("Informe o numero:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Chamr a ExercicioModel
                        Console.WriteLine(modelo.Triplo(num));
                        break;
                    case 2:
                        Console.WriteLine("Exercicio 02");
                        Console.WriteLine("Informe o numero");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.Metade(num));
                        break;
                    case 5:
                        Console.WriteLine("Exercicio 05");
                        Console.WriteLine("Informe a Hora");
                        double hora = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ValorMinutos(hora));
                        break;

                    case 8:
                        Console.WriteLine("Exercicio 08 ");
                        Console.WriteLine("Informe a Diagonal Maior ");
                        double diagonalMaior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a Diagonal Menor");
                        double diagonalMenor = Convert.ToDouble(Console.ReadLine());
                        //Mostrar Resultado
                        if (modelo.AreaLosango(diagonalMaior, diagonalMenor) == -1)
                        {
                            Console.WriteLine("Os Números digitados não são válidos!!");
                        }
                        else
                        {
                            Console.WriteLine($"A área do Losango é:{modelo.AreaLosango(diagonalMaior, diagonalMenor)}");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Exercicio 09");
                        Console.WriteLine("Informe o valor do raio");
                        double raio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a Altura");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        //Mostrar
                        if (modelo.VolumeCilindro(raio, altura) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos");
                        }
                        else
                        {
                            Console.WriteLine($"O volume do cilindro é:{modelo.VolumeCilindro(raio, altura)} ");
                        }
                        break;

                    case 16:
                        Console.WriteLine("Exercicio 16");
                        Console.WriteLine("Informe o seu peso");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a altura");
                        altura = Convert.ToDouble(Console.ReadLine());

                        //mostrar
                        Console.WriteLine(modelo.CalcularIMC(peso, altura));
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é valida!!");
                        break;
                }//Fim da Escolha
            }while(ModificarOpcao!=0);
        }//Fim do Método
    }//Fim Da Classe
}//Fim do Projeto
