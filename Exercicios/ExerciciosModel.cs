using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExerciciosModel
    {
        //area de Variaveis
        private double area;
        private double IMC;
        public int[] idade;//Estrutura de dados Finita
        public int[] num;
        public double[] num1;
        public double[] vet1;
        public double[] vet2;
        public double[] vet3;
        public int[] pares;
        public int[] impar;
        public int soma;
        public string[] nome;

        //metodo construtor

        public ExerciciosModel()
        {
            this.area = 0;
            this.IMC = 0;
            this.idade = new int[10];//de 0 até 9
            this.num = new int[10];
            this.num1 = new double[10];
            this.vet1 = new double[10];
            this.vet2 = new double[10];
            this.vet3 = new double[10];
            this.soma = 0;
            this.nome = new string[10];
            this.impar = new int[10];
            this.pares = new int[10];


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
            set { this.IMC = value; }
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

        //3. Converta um valor de dólares para reais com uma taxa fixa.
        public double ValorReal(double dolar, double taxaFixa)
        {
            if (dolar > 0 && taxaFixa > 0)
            {
                return dolar * taxaFixa;
            }
            else
            {
                return -1;
            }
        }

        //4. Calcule o perímetro de um quadrado com base no lado.

        public double ValorPerimetro(double lado)
        {
            if (lado <= 0)
            {
                return -1;
            }
            else
            {
                return lado * 4;
            }
        }

        //5. Converta um valor em horas para minutos
        public double ValorMinutos(double hora)
        {
            return hora * 60;
        }//fim

        //6. Leia um número e exiba 10% dele
        public double DezPorcento(double num)
        {
            return num * 0.1;
        }//Fim

        //7. Leia um número e exiba 25% dele.
        public double VintePorcento(double num)
        {
            return num * 0.25;
        }//Fim


        //8.Calcule a area de um losango com base nas diagonais
        //area =diagonalmaior * diagonalmenor /2

        public double AreaLosango(double diagonaMaior, double diagonalMenor)
        {
            // Validação
            if (diagonalMenor > 0 && diagonalMenor > 0)
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
            if (raio > 0 && altura > 0)
            {
                return Math.PI * Math.Pow(raio, 2) * altura;
            }
            else
            {
                return -1;
            }
        }//Fim do Método

        //10. Leia um número e exiba seu valor absoluto.
        public int ValorAbsoluto(int num)
        {
            if (num < 0)
            {
                return num * -1;
            }
            else
            {
                return num;
            }
        }//Fim

        //11. Converta um valor de quilômetros para metros.
        public double Metro(double Km)
        {
            return Km * 1000;
        }//Fim

        //12. Leia um número e exiba sua quinta potência.
        public double QuintaPotencia(int num)
        {
            return Math.Pow(num, 5);
        }//Fim

        //13.Calcule o tempo de uma viagem com base na distância e velocidade.
        public double TempoViagem(double distancia, double velocidade)
        {
            return distancia / velocidade;
        }//Fim

        //14.Calcule o consumo médio de combustível com base em km e litros.
        public double ConsumoMedio(double km, double litros)
        {
            return km / litros;
        }//Fim

        //15. Leia um número e calcule seu fatorial (sem estruturas de repetição).
        public double Fatorial(double num)
        {
            double resultado = num;
            num = num - 1;
            resultado = resultado * num;
            num = num - 1;
            resultado = resultado * num;
            num = num - 1;
            resultado = resultado * num;
            num = num - 1;
            resultado = resultado * num;
            return resultado;
        }

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
                else if (ModificarIMC < 24.9)
                {
                    resultado += "Peso Normal";
                }
                else if (ModificarIMC < 29.9)
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

        //17. Calcule o salário anual com base no valor mensal.
        public double ValorAnual(double mensal)
        {
            return mensal * 12;
        }

        //18. Leia um número e exiba seu logaritmo natural.
        public double Logaritmo(double num)
        {
            return Math.Log(num);
        }

        //19. Leia um número e exiba seu seno.
        public double Seno(double num)
        {
            return Math.Sin(num);
        }

        //20. Leia um número e exiba seu cosseno.
        public double Cosseno(double num)
        {
            return Math.Cos(num);
        }

        //21. Calcule a área de um trapézio com base na base maior, base menor e altura.

        public double AreaTrapezio(double baseMaior, double baseMenor, double altura)
        {
            return (baseMaior + baseMenor) * altura / 2;
        }

        //22. Converta um valor de dias para segundos.
        public double DiasParaSegundos(double dias)
        {
            return dias * 24 * 60 * 60;
        }

        //23. Leia um número e exiba a soma de seus dígitos.
        public int SomaDigitos(int num)
        {
            int somar = 0;
            //validação
            if (num < 0)
            {
                num = num * -1;
            }
            string nume = "" + num;
            for (int i = 0; i < nume.Length; i++)
            {
                somar += Convert.ToInt32(nume.Substring(i, 1));
            }//Fim for
            return somar;
        }//fim do metodo

        //24. Leia um número e exiba seu inverso multiplicativo.
        public int InversoMult(int num)
        {
            return num * 1 / num;
        }

        //25. Calcule a hipotenusa de um triângulo retângulo com base nos catetos.
        public double Hipotenusa(double cateno1, double cateno2)
        {
            return Math.Sqrt((cateno1 * cateno1) + (cateno2 * cateno2));
        }

        //26. Leia um valor e exiba seu correspondente em binário.
        public string Binario(int decim)
        {
            return Convert.ToString(decim, 2);
        }

        //27. Leia um número e exiba seu correspondente em hexadecimal.
        public string Hexadecimal(int decim)
        {
            string hexa = "";
            string result = "";
            while (decim != 0)
            {
                result = "" + decim % 16;
                switch (result)
                {
                    case "10":
                        result = "A";
                        break;
                    case "11":
                        result = "B";
                        break;
                    case "12":
                        result = "C";
                        break;
                    case "13":
                        result = "D";
                        break;
                    case "14":
                        result = "E";
                        break;
                    case "15":
                        result = "F";
                        break;
                }//Fim Switch
                decim /= 16;
                hexa += result;
            }//Fim While
            return Inverter(hexa);
        }//Fim Metodo
        public string Inverter(string valor)
        {
            int tamanho = valor.Length;
            string Invertido = "";
            for (int i = tamanho - 1; i >= 0; i--)
            {
                Invertido += valor.Substring(i, 1);
            }//Fim Do For
            return Invertido;
        }//Fim Do Metodo

        //28. Leia um valor e calcule sua raiz cúbica
        public double RaizCubica(double decim)
        {
            return Math.Sqrt(Math.Sqrt(decim));
        }

        public void Preeenchervetor()
        {
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(i + 1 + "ªidade:");
                    idade[i] = Convert.ToInt32(Console.ReadLine());
                    if (idade[i] <= 0)
                    {
                        Console.WriteLine("ERRO INFORME UMA IDADE POSITIVA");
                    }
                } while (idade[i] <= 0);
            }//Fim do For
        }//Fim do metodo

        //metodo de consulta
        public void Consultarvetor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}ªidade:{idade[i]}");
            }//Fim For
        }//Fim Consultar

        public void BuscarIdade(int idade)
        {
            Boolean flag = false;
            for (int i = 0; i < 10; i++)
            {
                if (this.idade[i] == idade)
                {
                    flag = true;
                    Console.WriteLine($"A idade {idade} está na Posição:{i + 1}");
                }

            }
            if (flag == false)
            {
                Console.WriteLine($"A idade {idade}, Não está no Vetor");
            }//Fim da Mensagem Alternativa
        }//Fim do metodo buscar

        //2. Leia 10 números e exiba-os na ordem inversa
        public void OrdemInversa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "ªNumero:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }//Fim do For

        }//Fim do metodo
        public void consultar()
        {
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"{i + 1}ªNumero:{num[i]}");
            }//Fim For
        }//Fim do metodo

        //3. Leia 10 números e exiba apenas os pares.
        public void Preencher()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "ªNumero:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }//Fim do For
        }
        public void Pares()
        {
            for (int i = 0; i < 10; i++)
            {
                if (this.num[i] % 2 == 0)
                {
                    Console.WriteLine($"{i + 1}ªNumero:{num[i]}");
                }

            }//Fim For
        }
        //4. Leia 10 números e exiba a média.
        public void Media()
        {
            for (int i = 0; i < 10; i++)
            {
                soma += num[i];
            }//Fim For
            Console.WriteLine($"A media é:{soma / 10}");

        }

        //5. Leia 10 nomes e exiba os que começam com “A”.
        public void PreencherVetorTexto()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "ªNome:");
                nome[i] = Console.ReadLine();
            }//Fim do For
        }//fim do método

        public void MostrarNomes()
        {
            for (int i = 0; i < 10; i++)
            {
                if (nome[i].Substring(0, 1) == "a" || nome[i].Substring(0, 1) == "A")
                {
                    Console.WriteLine($"O nome que inicia com a letra A é: {nome[i]}");
                }
            }//fim do for/
        }//fim do método

        //6. Leia 10 números e conte quantos são maiores que a média.

        public void MaiorMedia()
        {
            for (int i = 0; i < 10; i++)
            {
                soma += num[i];
            }//Fim For
            double media = soma / 10;
            int contarMaior = 0;
            for (int i = 0; i < 10; i++)
            {
                if (num[i] > media)
                {
                    contarMaior++;
                }
            }
            Console.WriteLine($"O total de numeros maior que a Média é : {contarMaior}");
        }//fim do método

        //7. Leia 10 idades e exiba a maior.
        public void IdadeMaior()
        {
            int maior = 0;
            for (int i = 0; i < 10; i++)
            {
                if (idade[i] > maior)
                {
                    maior = idade[i];
                }
            }
            Console.WriteLine($"A idade maior é : {maior}");
        }

        //8. Leia 10 alturas e exiba a média.
        public void PreeencherDou()
        {
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(i + 1 + "ªnumero:");
                    num1[i] = Convert.ToDouble(Console.ReadLine());
                
                    if (num1[i] < 0)
                    {
                        Console.WriteLine("Erro, informe um número positivo!");
                    }
                } while (num1[i] < 0);
            }//Fim do For
        }//Fim do metodo


        public void MediaAltura()
        {
            double som = 0;
            for (int i = 0; i < 10; i++)
            {
                som += num1[i];
            }//Fim For
            Console.WriteLine($"A media  de Altura é:{som / 10}");
        }//Fim Metodo

        //9. Leia 10 salários e exiba quantos ganham abaixo de R$ 1.200. 
        public void GanhaAbaixo()
        {
            double maior = 1200;
            int contar = 0;
            for (int i = 0; i < 10; i++)
            {
                if (num1[i] <= maior)
                {
                    contar++;  
                }
            }
            Console.WriteLine($" Os salarios que estão abaixo são: {contar}");
        }

        //10. Leia 10 números e exiba quantos são múltiplos de 5. 
        
        public void Mult5()
        {
            for(int i = 0;i < 10;i++)
            {
                if (this.num[i] % 5 == 0)

                {
                    Console.WriteLine($"{i + 1}ªNumero:{num[i]}");
                }

            }//Fim for        
        }//Fim Metodo

        //11. Leia 10 valores e os armazene em dois vetores(pares e ímpares). 

        public void VetPareImp()
        {
            int contarPar = 0;
            int contarImpar = 0;
            for( int i = 0;i < 10 ; i++)
            {
                if(num[i] % 2== 0)
                {
                    pares[contarPar] = num[i];
                    contarPar++;
                }
                else
                {
                    impar[contarImpar]=num[i];
                    contarImpar++;
                }

            }

            for(int i=0; i< 10; i++)
            {
                Console.WriteLine($"O vetor par é: {pares[i]}");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"O vetor Impar é: {impar[i]}");
            }
        }//Fim do Metodo

        //12. Leia 10 valores e ordene do maior para o menor.

        public void MaiorMenor()
        {
            int aux = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (num[i] > num[j])
                    {
                        aux = num[j];
                        num[j] = num[i];
                        num[i] = aux;                        
                    }//Fim If                    
                }//Fim For
            }//Fim do for
        }//Fim do Metodo

        public void Consulta()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}ªNumero {num[i]}");
            }//Fim For
        }//Fim Consultar

        //13. Leia 10 números e exiba os repetidos.

        public void Repetido()
        {
            for (int i = 0;i < 5; i++)
            {
                for (int j = 5; j < 10; j++)
                {
                    if (num[i] == num[j])
                    {
                        Console.WriteLine($"O Numero Repetidos é: {i + 1} ªNumero {num[i]}");
                    }
                }//fim for
            }//fim for
        }//Fim Metodo

        //14. Some dois vetores de 10 posições.
        
        public void Preeenchervet1()
        {
            for (int i = 0; i < 10; i++)
            {
               Console.Write(i + 1 + " ªNumero:");
               vet1[i] = Convert.ToDouble(Console.ReadLine());
                   
            }//Fim do For
        }//Fim do metodo

        public void Preeenchervet2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + " ªNumero:");
                vet2[i] = Convert.ToDouble(Console.ReadLine());

            }//Fim do For
        }//Fim do metodo


        public void SomaVetores()
        {
            double soma = 0;
            for (int i = 0; i < 10; i++)
            {
             
                soma += vet1[i] + vet2[i] ;
            }//fim for
            Console.WriteLine($"A soma é: {soma}");
        }//Fim Metodo

        //15. Multiplique dois vetores de 10 posições e armazene em outro.

        public void MultVetor()
        {
            double soma = 0;
            for(int i = 0;i < 10;i++)
            {
                vet3[i] = vet1[i] * vet2[i];
            }
        }

        public void Consultavet3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1} ªSua Multiplicação é: {vet3[i]}");
            }//Fim For
        }//Fim Consultar

        //16. Calcule a soma de todos os elementos de um vetor.

        public void SomaElemento()
        {
            for (int i = 0; i < 10; i++)
            {
                soma += num[i];
            }
            Console.WriteLine($"A Soma de todos elementos é: {soma}");
        }//Fim Metodo

        //17. Encontre o maior número em um vetor e sua posição.

        public void EncontreMaior()
        {
            int maior = 0;
            int posicao =0;
            for (int i = 0;i < 10;i++)
            {
                if (num[i]>maior)
                {
                    maior=num[i];
                    posicao = i+1;                                                                
                }//Fim if
            }
            Console.WriteLine($"{posicao} ª o numero é: { maior}");
        }


    }//Fim da Classe
}//Fim do Projeto
