using System;
using System.Collections.Generic;

using Curso.Fundamentos;
using Curso.EstruturasDeControle;
using Curso.ClassesEMetodos;
using Curso.Colecoes;
using Curso.OO;
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
                 {"Struct - classes e metodos", Struct.Executar},
                 {"Classe vs Struct - classes e metodos", ClassevsStruct.Executar},
                 {"Valor VS Referencia - classes e metodos", ValorVSReferencia.Executar},
                 {"Parametros Por Referencias - classes e metodos", ParametrosPorReferencias.Executar},
                 {"Parametro Padrão - classes e metodos", ParametroPadrao.Executar},
                 
                //Coleções
                
                
                {"Array - Coleções", Colecoes.Array.Executar},//se caso ouver conflitos de nomes, pode usar nesta forma
                {"List - Coleções", List.Executar},//se caso ouver conflitos de nomes, pode usar nesta forma
                {"Array List- Coleções", ArrayListCodigo.Executar},//se caso ouver conflitos de nomes, pode usar nesta forma
                {"Colecoes Set- Coleções", ColecoesSet.Executar},//se caso ouver conflitos de nomes, pode usar nesta forma
                {"Queue- Coleções", Queue.Executar},//se caso ouver conflitos de nomes, pode usar nesta forma
                {"igualdade- Coleções", igualdade.Executar},//se caso ouver conflitos de nomes, pode usar nesta forma
                {"Stack- Coleções", Stack.Executar},//se caso ouver conflitos de nomes, pode usar nesta forma
                {"Dictionary- Coleções", Dictionary.Executar},//se caso ouver conflitos de nomes, pode usar nesta forma
                
                //OO
                
                {"Herança- OO", Heranca.Executar},//se caso ouver conflitos de nomes, pode usar nesta forma

            });

            central.SelecionarEExecutar();

            
        }

    }

    
}