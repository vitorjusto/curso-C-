using System;
using System.Collections.Generic;

using Curso.Fundamentos;
using Curso.EstruturasDeControle;
using Curso.ClassesEMetodos;
namespace Curso {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                 //fundamentos
                 {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                 {"Comentarios - Fundamentos", Comentarios.Executar},
                 {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
                 {"Inferencia - Fundamentos", Inferencia.Executar},
                 {"Interpolação - Fundamentos", Interpolacao.Executar},
                 {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                 {"Lendo Dados - Fundamentos", LendoDados.Executar},
                 {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                 {"Conversões - Fundamentos", Conversoes.Executar},
                 {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                 {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                 {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                 {"Operadores de Atribuição - Fundamentos", OperadoresAtribuição.Executar},
                 {"Operadores Unario - Fundamentos", OperadoresUnario.Executar},
                 {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                 //estruturas de controle

                 {"Estruturas IF - EstruturasDeControle", EstruturaIF.Executar},
                 {"Estruturas IF Else - EstruturasDeControle", If_Else.Executar},
                 {"Estruturas IF Else If - EstruturasDeControle", If_Else_If.Executar},
                 {"Estruturas Switch - EstruturasDeControle", Switch.Executar},
                 {"Estrutura While - EstruturasDeControle", While.Executar},
                 {"Estrutura Do While - EstruturasDeControle", Do_While.Executar},
                 {"Estrutura For - EstruturasDeControle", For.Executar},
                 {"Estrutura ForEach - EstruturasDeControle", ForEach.Executar},
                 {"Estrutura Break - EstruturasDeControle", Break.Executar},
                 {"Estrutura Continue - EstruturasDeControle", Continue.Executar},
                 

                 //Classes e Objetos
                 {"Membros - classes e metodos", Membros.Executar},
                 {"Construtores - classes e metodos", Construtores.Executar},
                 {"Metodos Com Retorno - classes e metodos", MetodosComRetorno.Executar},
                 {"Metdos Estaticos - classes e metodos", MetdosEstaticos.Executar},
                 {"Atributos Estaticos - classes e metodos", AtributosEstaticos.Executar},
                 {"Desafio - classes e metodos", Desafio.Executar},
                 {"Parametros Variaveis - classes e metodos", ParametrosVariaveis.Executar},
                 {"Parametros Nomeados - classes e metodos", ParametrosNomeados.Executar},
                 {"Geters e Seters - classes e metodos", GeterseSeters.Executar},
                 {"Props - classes e metodos", Props.Executar},
                 {"ReadOnly - classes e metodos", ReadOnly.Executar},
                 {"Exemplo Enum - classes e metodos", ExemploEnum.Executar},

            });

            central.SelecionarEExecutar();

            
        }

    }

    
}