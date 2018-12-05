using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            Action executar = Colecoes.Array.Executar;
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador ternário - Fundamentos", OperadorTernario.Executar},
                //Estruturas de controle
                { "Estrutura If - Estruturas de controle", EstruturaIf.Executar},
                { "Estrutura If-Else - Estruturas de controle", EstruturaIfElse.Executar},
                { "Estrutura If Else If - Estruturas de controle", IfElseIf.Executar},
                { "Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar},
                { "Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                { "Estrutura Do While - Estruturas de controle", EstruturaDoWhile.Executar},
                { "Estrutura For - Estruturas de controle", EstruturaFor.Executar},
                { "Estrutura Foreach - Estruturas de controle", EstruturaForeach.Executar},
                { "Usando Break - Estruturas de controle", UsandoBreak.Executar},
                { "Usando Continue - Estruturas de controle", UsandoContinue.Executar},
                //Classes e Metódos
                { "Membros - Classes e Metodos", Membros.Executar},
                { "Construtores - Classes e Metodos", Construtores.Executar},
                { "Metodos com retorno - Classes e Metodos", MetodosComRetorno.Executar},
                { "Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                { "Desafio atributo - Classes e Metodos", DesafioAtributo.Executar},
                { "Params - Classes e Metodos", Params.Executar},
                { "Parametros nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                { "GetSet - Classes e Metodos", GetSet.Executar},
                { "Props - Classes e Metodos", Props.Executar},
                { "ReadOnly - Classes e Metodos", Readonly.Executar},
                { "Exemplo Enum - Classes e Metodos", ExemploEnum.Executar},
                { "Struct - Classes e Metodos", ExemploStruct.Executar},
                { "Struct VS Classe - Classes e Metodos", StructVSClasse.Executar},
                { "Valor VS Referencia - Classes e Metodos", ValorVSReferencia.Executar},
                { "Parametros por referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                { "Parametro padrão - Classes e Metodos", ParametroPadrao.Executar},

                //Coleções
                { "Array - Colecoes", executar},
                { "List - Colecoes", Colecoes.ColecoesList.Executar},
                { "ArrayList - Colecoes", ColecoesArrayList.Executar},
                { "Colecoes-Set - Colecoes", ColecoesSet.Executar},
                { "Queue - Colecoes", ColecoesQueue.Executar},
                { "Igualdade - Colecoes", Igualdade.Executar},
                { "Stack - Colecoes", ColecaoStack.Executar},
                { "Dicionário - Colecoes", ColecoesDicionario.Executar},
                //Orientação a objetos
                { "Herança - OO", Heranca.Executar},
                { "Contrutor This - OO", ConstrutorThis.Executar},
                { "Encapsulamento - OO", OO.Encapsulamento.Executar},
                { "Polimorfismo - OO", Polimorfismo.Executar},
                { "Abstract - OO", Abstract.Executar},
                { "Interface - OO", Interface.Executar},
                { "Sealed - OO", Sealed.Executar},
                //Metodos e Funcoes
                { "Exemplo Lambda - Metodos e funcoes", ExemploLambda.Executar},
                { "Lambdas como Delegate- Metodos e funcoes", LambdasDelegate.Executar},
                { "Usando Delegate - Metodos e funcoes", UsandoDelegate.Executar},
                { "Delegates como funcoes anonimas- Metodos e funcoes", DelegateFunAnonima.Executar},
                { "Delegates como parametros- Metodos e funcoes", DelegatesComoParametros.Executar},
                { "Métodos de Extensão- Metodos e funcoes", MetodosDeExtensao.Executar},
                //Excecoes
                { "Primeira Excecao- Excecoes", PrimeiraExcecao.Executar},
                { "Excecoes Personalizadas- Excecoes", ExcecoesPersonalizadas.Executar},
                //Api
                { "Primeiro Arquivo- Api", PrimeiroArquivo.Executar},
                { "Lendo arquivos - Api", LendoArquivos.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}