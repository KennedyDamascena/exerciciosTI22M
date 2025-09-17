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
                "\n0.  Sair"+
                "\n1.  Exercicio 1" +
                "\n2.  Exercicio 2" +
                "\n3.  Exercicio 3" +
                "\n4.  Exercico  4" +
                "\n5.  Exercicio 5" +
                "\n6.  Exercicio 6" +
                "\n7.  Exercicio 7" +
                "\n8.  Exercicio 8" +
                "\n9.  Exercicio 9" +
                "\n10. Exercicio 10"+
                "\n11. Exercicio 11"+
                "\n12. Exercicio 12"+
                "\n13. Exercicio 13"+
                "\n14. Exercicio 14"+
                "\n15. Exercicio 15"+
                "\n16. Exercicio 16"+
                "\n17. Exercicio 17"+
                "\n18. Exercicio 18"+
                "\n19. Exercicio 19"+
                "\n20. Exercicio 20"+
                "\n21. Exercicio 21"+
                "\n22. Exercicio 22"+
                "\n23. Exercicio 23"+
                "\n24. Exercicio 24"+
                "\n25. Exercicio 25"+
                "\n26. Exercicio 26"+
                "\n27. Exercicio 27"+
                "\n28. Exercicio 28"+
                "\n29. Exercicio 29 Vetor"+
                "\n30. Exercicio 30 Vetor"+
                "\n31. Exercicio 31 vetor"+
                "\n32. Exercicio 32 Vetor"+
                "\n33. Exercicio 33 Vetor"+
                "\n34. Exercicio 34 Vetor"+
                "\n35. Exercicio 35 Vetor"+
                "\n36. Exercicio 36 Vetor"+
                "\n37. Exercicio 37 Vetor"+
                "\n38. Exercicio 38 Vetor"+
                "\n39. Exercicio 39 Vetor"+
                "\n40. Exercicio 40 Vetor"+
                "\n41. Exercicio 41 Vetor"+
                "\n42. Exercicio 42 Vetor"+
                "\n43. Exercicio 43 Vetor"+
                "\n44. Exercicio 44 Vetor"+
                "\n45. Exercicio 45 Vetor"+
                "\n46. Exercicio 46 Vetor"+
                "\n47. Exercicio 47 Vetor"+
                "\n48. Exercicio 48 Matriz"+
                "\n49. Exercicio 49 Matriz"+
                "\n50. Exercicio 50 Matriz"+
                "\n51. Exercicio 51 Matriz"+
                "\n52. Exercicio 52 Matriz"+
                "\n53. Exercicio 53 Matriz"+
                "\n54. Exercicio 54 Matriz"+
                "\n55. Exercicio 55 Matriz"+
                "\n56. Exercicio 56 Matriz");
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
                    case 3:
                        Console.WriteLine("Exercicio 03");
                        Console.WriteLine("Informe o valor do Dolar");
                        double dolar = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a Taxa Fixa");
                        double taxaFixa= Convert.ToDouble(Console.ReadLine());

                        //Mostrar Resultado
                        if (modelo.ValorReal(dolar, taxaFixa)==-1)
                        {
                            Console.WriteLine("Os Números digitados não são válidos!!");
                        }
                        else
                        {
                            Console.WriteLine($"O Valor em Real é:{modelo.ValorReal(dolar, taxaFixa)}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exerciocio 04");
                        Console.WriteLine("Informe o comprimento de um dos lados do quadrado");
                        double lado =Convert.ToDouble(Console.ReadLine());

                        //Mostrar Resultado
                        if (modelo.ValorPerimetro(lado) == -1)
                        {
                            Console.WriteLine("Os Números digitados não são válidos!!");
                        }
                        else

                            Console.WriteLine($"O valor do perimetro é:{modelo.ValorPerimetro(lado)}");
                        break;

                    case 5:
                        Console.WriteLine("Exercicio 05");
                        Console.WriteLine("Informe a Hora");
                        double hora = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"O Resultado é: {modelo.ValorMinutos(hora)} Minutos");
                        break;
                    case 6:
                        Console.WriteLine("Exercicio 06");
                        Console.WriteLine("Informe o Valor");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        if (modelo.DezPorcento(num1) == -1)
                        {
                            Console.WriteLine("Os Números digitados não são válidos!!");
                        }
                        else
                            Console.WriteLine($"O Resultado é: {modelo.DezPorcento(num1)} de dez porcento");
                        break;

                    case 7:
                        Console.WriteLine("Exercicio 07");
                        Console.WriteLine("Informe o Valor");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (modelo.VintePorcento(num1) == -1)
                        {
                            Console.WriteLine("Os Números digitados não são válidos!!");
                        }
                        else
                            Console.WriteLine($"O Resultado do valor é: {modelo.VintePorcento(num1)} de vinte porcento");
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
                            Console.WriteLine($"A área do Losango é: {modelo.AreaLosango(diagonalMaior, diagonalMenor)}");
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
                   
                    case 10:
                        Console.WriteLine("Exercicio 10");
                        Console.WriteLine("Informe o número");
                        num = Convert.ToInt32(Console.ReadLine());                       
                       
                        Console.WriteLine($"O valor absoluto é {modelo.ValorAbsoluto(num)}");
                        break;
                    
                    case 11:
                        Console.WriteLine("Exercicio 11");
                        Console.WriteLine("Informe quantos quilometros são");
                        double km = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O Valor de Quilometros é: {modelo.Metro(km)} Metros");
                        break; 
                    
                    case 12:
                        Console.WriteLine("Exercicio 12");
                        Console.WriteLine("Informe o Número");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"A quinta Potencia deste numero é: {modelo.QuintaPotencia(num)}");
                        break; 

                    case 13:
                        Console.WriteLine("Exercicio 13");
                        Console.WriteLine("Informe a Distancia");
                        double distancia = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a Velocidade");
                        double velocidade = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"O tempo de Viagem é: {modelo.TempoViagem(distancia, velocidade)}");
                        break;
                    
                    case 14:
                        Console.WriteLine("Exercicio 14");
                        Console.WriteLine("Informe quantos Quilometros");
                        km = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe quantos litros");
                        double litros = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"O Consomo médio de Combustivel é: {modelo.ConsumoMedio(km,litros)} Quilometros por Litro");
                        break;
                    case 15:
                        Console.WriteLine("Exercicio 15");
                        Console.WriteLine("Digite 5 para calcular o Fatorial");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"O fatorial de 5 é: {modelo.Fatorial(num)}");
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

                 

                    case 17:
                        Console.WriteLine("Exercicio 17");
                        Console.WriteLine("Informe o salario Mensal");
                        double mensal = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($" O salário anual é: {modelo.ValorAnual(mensal)} ao ano");
                        break;
                    
                    case 18:
                        Console.WriteLine("Exercicio 18");
                        Console.WriteLine("Digite o número");
                        
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O logaritmo natural desse Número é: {modelo.Logaritmo(num1)}");
                        break;

                    case 19:
                        Console.WriteLine("Exercicio 19");
                        Console.WriteLine("Digite o número");

                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O Seno desse Número é: {modelo.Seno(num1)}");
                        break; 

                    case 20:
                        Console.WriteLine("Exercicio 20");
                        Console.WriteLine("Digite o número");

                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O Cosseno desse Número é: {modelo.Cosseno(num1)}");
                        break;

                    case 21:
                        Console.WriteLine("Exercicio 21");
                        Console.WriteLine("Digite a base Maior");
                        double baseMaior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a base Menor");
                        double baseMenor= Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("Digite a Altura");
                        altura = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"A área desse trapézio é de: {modelo.AreaTrapezio(baseMaior,baseMenor,altura)} cm²");
                        break;

                    case 22:
                        Console.WriteLine("Exercicio 22");
                        Console.WriteLine("Digite a Quantidade de dias");
                        double dias= Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"A Quantidade de dia em Segundos é: {modelo.DiasParaSegundos(dias)} segundos");
                        break ; 
                    
                    case 23:
                        Console.WriteLine("Exercicio 23");
                        Console.WriteLine("Digite um número inteiro");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Soma dos dígitos: {modelo.SomaDigitos(num)}");
                        break; 

                    case 24:
                        Console.WriteLine("Exercicio 24");
                        Console.WriteLine("Digite um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"O inverso multiplicativo de {num} é: {modelo.InversoMult(num)} ");
                        break;

                    case 25:
                        Console.WriteLine("Exercicio 25");
                        Console.WriteLine("Digite o cateto 1: ");
                        double cateto1 = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("Digite o cateto 2: ");
                        double cateto2 = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine($"A hipotenusa é: {modelo.Hipotenusa(cateto1, cateto2)}cm");
                        break;

                    case 26:
                        Console.WriteLine("Exercicio 26");
                        Console.WriteLine("Digite o numero");
                        int decim = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"O Numero em Binario é: {modelo.Binario(decim)}");
                        break;

                    case 27:
                        Console.WriteLine("Exercicio 27");
                        Console.WriteLine("Digite o Número");
                        decim= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"O Numero em hexadecimal é: {modelo.Hexadecimal(decim)}");
                        break;

                    case 28:
                        Console.WriteLine("Exercicio 28");
                        Console.WriteLine("Digite o Número");
                        double valor = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"A Raiz Cubica é: {modelo.RaizCubica(valor)}");
                        break;

                    case 29:
                        Console.WriteLine("Exercicio 29");
                        //Mostrar
                        modelo.Preeenchervetor();
                        break; 
                    case 30:
                        Console.WriteLine("Exercicio 30");
                        modelo.Consultarvetor();
                        break ; 
                    case 31:
                        Console.WriteLine("Exercicio 31");
                        
                        Console.WriteLine("Informe a idade que deseja buscar");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        modelo.BuscarIdade(idade);
                        break;
                    
                    case 32:
                        Console.WriteLine("Exercicio 32");                                               
                        modelo.OrdemInversa();
                        modelo.consultar();
                        break;

                    case 33:
                        Console.WriteLine("Exercicio 33");
                        modelo.Preencher();
                        modelo.Pares();
                        break;

                    case 34:
                        Console.WriteLine("Exercicio 34");
                        modelo.Preencher();
                        modelo.Media();
                        break;
                    
                    case 35:
                        Console.WriteLine("Exercicio 35");
                        modelo.PreencherVetorTexto();
                        modelo.MostrarNomes();
                        break;
                    case 36:
                        Console.WriteLine("Exercicio 36");
                        modelo.Preencher();
                        modelo.MaiorMedia();
                        break ;

                    case 37:
                        Console.WriteLine("Exercicio 37");
                        modelo.Preeenchervetor();
                        modelo.IdadeMaior();
                        break;
                    case 38:
                        Console.WriteLine("Exercicio 38");
                        modelo.PreeencherDou();
                        modelo.MediaAltura();
                        break;

                    case 39:
                        Console.WriteLine("Exercicio 39");
                        modelo.PreeencherDou();
                        modelo.GanhaAbaixo();
                        break;
                    

                    case 40:
                        Console.WriteLine("Exercicio 40");
                        modelo.Preencher();
                        modelo.Mult5();
                        break;
                    
                    case 41:
                        Console.WriteLine("Exercicio 41");
                        modelo.Preencher();
                        modelo.VetPareImp();       
                        break;

                    case 42:
                        Console.WriteLine("Exercicio 42");
                        modelo.Preencher();
                        modelo.MaiorMenor();
                        modelo.Consulta();
                        break;
                     
                    case 43:
                        Console.WriteLine("Exercicio 43");
                        modelo.Preencher();
                        modelo.Repetido();
                        break;

                    case 44:
                        Console.WriteLine("Exercicio 44");
                        modelo.Preeenchervet1();
                        modelo.Preeenchervet2();
                        modelo.SomaVetores();
                        break;

                    case 45:
                        Console.WriteLine("Exercicio 45");
                        modelo.Preeenchervet1();
                        modelo.Preeenchervet2();
                        modelo.MultVetor();
                        modelo.Consultavet3();
                        break;

                    case 46:
                        Console.WriteLine("Exercicio 46");
                        modelo.Preencher();
                        modelo.SomaElemento();
                        break;

                    case 47:
                        Console.WriteLine("Exercicio 47");
                        modelo.Preencher();
                        modelo.EncontreMaior();
                        break;

                        // EXERCICIOS DE MATRIZ
                    case 48:
                        Console.WriteLine("Exercicio 48");
                        modelo.PreencherMat3x3();
                        modelo.MostrarMatriz3x3();
                        break;

                    case 49:
                        Console.WriteLine("Exercicio 49");
                        modelo.PreencherZero();
                        modelo.MostrarMatriz3x3();
                        break;

                    case 50:
                        Console.WriteLine("Exercicio 50");
                        modelo.PreencherMat3x3();
                        modelo.MatSoma();
                        break;
                    case 51:
                        Console.WriteLine("Exercicio 51");
                        modelo.PreencherMat4x4();
                        modelo.Media4x4();
                        break;

                    case 52:
                        Console.WriteLine("Exercicio 52");
                        modelo.PreencherMat4x4();
                        modelo.Maior10();
                        break;
                    case 53:
                        Console.WriteLine("Exercicio 53");
                        modelo.PreencherMat3x3();
                        modelo.PreencherSegMat3x3();
                        modelo.SomaMatriz3x3();
                        break;
                    case 54:
                        Console.WriteLine("Exercicio 54");
                        modelo.PreencheMatrix2x2();
                        modelo.PreenchesegMatrix2x2();
                        modelo.MultMatriz2x2();
                        modelo.MostrarMatriz2x2();
                        break;
                    case 55:
                        Console.WriteLine("Exercicio 55");
                        modelo.PreencheMatrix5x5();
                        modelo.TrocarMatrix5x5();
                        modelo.MostrarMatriz5x5();
                        break;
                    case 56:
                        Console.WriteLine("Exercicio 56");
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é valida!!");
                        break;


                }//Fim da Escolha
            }while(ModificarOpcao!=0);
        }//Fim do Método
    }//Fim Da Classe
}//Fim do Projeto
