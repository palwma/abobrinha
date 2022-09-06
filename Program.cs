//Alunos: Iago Theodoro e Paloma Tavares
using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pergunta = new string[5] {"(pressione as teclas <A> , <B> ou <C> de acordo com a letra da alternativa!)"+
        "\r\nPergunta 1: Qual dos três é o maior animal?\r\nA: Baleia Cinzenta\r\nB: Lula Colossal\r\nC: Tubarão Baleia"
        ,"Pergunta 2: Qual desse animais é conhecido por ter clamídia?\r\nA: Canguru\r\nB: Diabo da Tasmânia\r\nC: Coala"
         ,"Pergunta 3: Qual dos três é o animal mais perigoso para humanos?\r\nA: Casuar do sul\r\nB: Tarântula babuína laranja\r\nC: Abutre de capuz",
          "Pergunta 4: Qual dessas cobras não é peçonhenta?\r\nA: Cobra Hognose\r\nB: Cobra Boca-de-Algodão\r\nC: Cobra Surucucu"
         ,"Pergunta 5: Qual dos desses dois é o que caça?\r\nA: Leão Adulto\r\nB: Leoa Adulta\r\nC: Filhotes"};
            string[] respostasComparacao = new string[5] { "C", "C", "A", "A", "B" };
            string[] resposta = new string[5];
            string[] respostaVerificacao = new string[5];
            int respostaCorreta = 0, respostaErrada = 0;

            Console.WriteLine("Bem vindo ao jogo Perguntanu!");
            Console.WriteLine("Caso queria participar, pressione a tecla <enter>");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Você pressionou a tecla errada. Pressione novamente");
            }

            for (int i = 0; i < pergunta.Length; i++)
            {
                Console.WriteLine(pergunta[i]);
                resposta[i] = Console.ReadLine().ToUpper();

                while (resposta[i] != "A" &&  resposta[i] != "B" && resposta[i] != "C")
                {
                    Console.WriteLine("Você pressionou a tecla errada. Pressione <A>, <B> ou <C>");
                    resposta[i] = Console.ReadLine().ToUpper();
                }
                

                if (resposta[i] == respostasComparacao[i])
                {
                    respostaVerificacao[i] = "Correta";
                    respostaCorreta++;
                }
                else
                {
                    if (resposta[i] != respostasComparacao[i])
                    {
                        respostaVerificacao[i] = "Errado";
                        respostaErrada++;
                    }
                }
            }

            if (respostaCorreta == 5)
            {
                Console.WriteLine("Parabéns! Você acertou todas as questões!\r\nMuito obrigado por ter jogado Perguntanu <3");
                Environment.Exit(0);
            }

            Console.WriteLine("Parabéns!! Você terminou o quiz *clap* *clap* \r\nVocê acertou: " + respostaCorreta + " questões, e errou: " + respostaErrada + " questões.");
            Console.WriteLine("Se desejar sair do quiz, aperte: <enter>. Se quiser refazer o quiz, aperte qualquer tecla.");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                respostaErrada = 0;
                respostaCorreta = 0;
                for (int i = 0; i < pergunta.Length; i++)
                {
                    if (respostaVerificacao[i] == "Errado")
                    {
                        Console.WriteLine(pergunta[i]);
                        resposta[i] = Console.ReadLine().ToUpper();
                        while (resposta[i] != "A" && resposta[i] != "B" && resposta[i] != "C")
                        {
                            Console.WriteLine("Você pressionou a tecla errada. Pressione <A>, <B> ou <C>");
                            resposta[i] = Console.ReadLine().ToUpper();
                        }

                        if (resposta[i] == respostasComparacao[i])
                        {
                            respostaVerificacao[i] = "Correta";
                            respostaCorreta++;
                        }
                        else
                        {
                            if (resposta[i] != respostasComparacao[i])
                            {
                                respostaVerificacao[i] = "Errado";
                                respostaErrada++;
                            }
                        }
                    }

                }
                if (respostaErrada == 0)
                {
                    Console.WriteLine("Parabens! Você acertou todas as questões!\r\nMuito obrigado por ter jogado Perguntanu <3");
                    Environment.Exit(0);
                }
                Console.WriteLine("Parabéns!! Você terminou o quiz *clap* *clap* \r\nVocê acertou: " + respostaCorreta + " questões, e errou: " + respostaErrada + " questões.");
                Console.WriteLine("Se desejar sair do quiz, aperte: <enter>. Se quiser refazer o quiz, aperte qualquer tecla  ");
            }

            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
        }

    }
}
