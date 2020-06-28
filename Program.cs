using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5]; 
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Digite o Nome do Aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a Nota do Aluno:");

                        if (double.TryParse(Console.ReadLine(), out double nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da Nota deve conter casas Decimais!!!");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO(A): {a.Nome} - NOTA: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        double notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i=0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal += alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = (notaTotal / nrAlunos);
                        Console.WriteLine("A Média Geral é: " + mediaGeral);
                        Conceito conceitoGeral;
                            if (mediaGeral < 2)
                            {
                                
                                conceitoGeral = Conceito.E;
                                Console.WriteLine("O Conceito é: " + Conceito.E);
                            }
                            else if (mediaGeral < 4)
                            {
                                conceitoGeral = Conceito.D;
                                Console.WriteLine("O Conceito é: " + Conceito.D);
                            }
                          else if (mediaGeral < 6)
                          {
                            conceitoGeral = Conceito.C;
                            Console.WriteLine("O Conceito é: " + Conceito.C);
                          }
                          else if (mediaGeral < 8)
                          {
                            conceitoGeral = Conceito.B;
                            Console.WriteLine("O Conceito é: " + Conceito.B);
                          }
                          else
                          { 
                            conceitoGeral = Conceito.A;
                            Console.WriteLine("O Conceito é: " + Conceito.A);
                          }
                        

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");

                        break;
                    
                    
                    default:
                         throw new ArgumentOutOfRangeException(" ====== Opção Inválida!!! Tente Novamente!!! ====== ");
                } 
                
                
                
                opcaoUsuario = ObterOpcaoUsuario();
                
            }
             if(opcaoUsuario == "X") //O X deverá ser digitado maiúsculo
             {
                    Console.Write(" ... Saindo da Aplicação!!! ..." );
                    Console.WriteLine();

             }
                     
                    
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Digite uma das Opções: ");
            Console.WriteLine("1 - Inserir Novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular Média Geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
