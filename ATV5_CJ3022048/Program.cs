namespace ATV5_CJ3022048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcgeral;

            Console.WriteLine("**MENU DE ATIVIDADES** \n 1-ATIVIDADE DE SALA \n 2-EXERCÍCIO 1 \n 3-EXERCÍCIO 2 \n 4-EXERCÍCIO 3 \n 5-EXERCÍCIO 4 \n 6-EXERCÍCIO 5 \n 7-EXERCÍCIO 6 \n 8-EXERCÍCIO 7");
            opcgeral = int.Parse(Console.ReadLine());

            switch (opcgeral)
            {
                case 1:
                    Console.WriteLine("ATIVIDADE DE SALA");
                    //ATV SALA
                    int a, temp;
                    int soma = 0;

                    for (a = 0; a < 3; a++)
                    {
                        Console.WriteLine("digite um valor: ");
                        temp = int.Parse(Console.ReadLine());
                        if (temp < 0)
                        {
                            break;
                        }
                        soma = soma + temp;
                    }
                    Console.WriteLine("a medida é: {0}", soma / 3);
                    break;

                case 2:
                    Console.WriteLine("ATIVIDADE 1");
                    //ATV 1
                    int n, m;

                    Console.WriteLine("digite um número inteiro aleatório: ");
                    m = int.Parse(Console.ReadLine());

                    for (n = 1; n <= m; n++)
                        Console.WriteLine("{0}", n);
                break;

                case 3:
                    Console.WriteLine("ATIVIDADE 2");
                    //ATV 2
                    int a2, n1;

                    Console.WriteLine("Escreva um número inteiro aleatório: ");
                    n1 = int.Parse(Console.ReadLine());

                    for (a2 = 0; a2 <= n1; a2++)
                    {
                        if (a2 % 2 == 0)
                        {
                            Console.WriteLine(a2);
                        }
                    }
                    break;

                case 4:
     Console.WriteLine("ATIVIDADE 3");
     //ATV 3

     int div = 1000;

     Console.WriteLine("Escreva um úmero interiro menor que 1000");
     int mil = int.Parse(Console.ReadLine());

     if (mil < 1000)
     {
         for (div = 1000; div >= mil; div--)
         {
             if ((div % 2) == 0)
             {
                 Console.WriteLine(div);
             }
         }
     }
     else
     {
         Console.WriteLine("OPÇÃO INVÁLIDA");
     }

 break;


                case 5:
                    //ATV 4

                    break;

                case 6:
                    //ATV 5

                    break;

                case 7:
                    Console.WriteLine("ATIVIDADE 6");
                    //ATV 6
                    int v1 , v2, v3, v4, v5, v6, v7, v8, v9, v10;

                    Console.WriteLine("digite um valor para v1: ");
                    v1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um valor para v2: ");
                    v2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um valor para v3: ");
                    v3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um valor para v4: ");
                    v4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um valor para v5: ");
                    v5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um valor para v6: ");
                    v6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um valor para v7: ");
                    v7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um valor para v8: ");
                    v8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um valor para v9: ");
                    v9 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite um valor para v10: ");
                    v10 = int.Parse(Console.ReadLine());
                  

                    break;

                case 8:
                    //ATV 7
                    

                    break;

                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }
    }
}
