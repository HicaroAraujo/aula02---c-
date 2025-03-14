// using System; usado para Importar a biblioteca System, que contém funções básicas, como Console.WriteLine().

// 1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.

class Idade
{
     public static void ExibirIdade()
     {
        int idade = 35;
        Console.WriteLine($"sua idade {idade}");
     }
}


// 2 - Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
class NomeMaria
{
    public static void ExibirNome()
    {
        string nome = "Maria";
        Console.WriteLine($"seu nome é {nome}");
    }
}

// 3 - Crie uma variável chamada altura e atribua a ela o valor 3.45.

class Altura
{
    public static void ExibirAltura()
    {
        float altura = 3.45f;
        Console.WriteLine($"sua altura é {altura}");
    }
}


// 4 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor

class Constante
{
    public static void ExibirConstante()
    {
        const int ANO = 12;
        Console.WriteLine($"Ano {ANO}");
    }
}

// 4 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor

class Nota 
{
    public static void ExibirNota()
    {
        double? nota = 7.80;
        Console.WriteLine($"Nota {nota}");
    }
}




// Quais as diferenças entre os tipos por valor e os tipos por referência ?
//           Resposta: A principal diferença entre estes dois tipos está em como os dados são armazenados e manipulados. Nos de tipo de VALOR os valores 
//           são armazenado diretos nas variaveis, elas não podem ser alteradas ou subscrevidas quando passadas à metodos. Os tipos de referência as variaveis
//           podem referenciar o mesmo objeto e Alterações afetam o objeto original.



// O que é um nullable type e qual a sua utilidade ?
//         Resposta: significa que a variável pode receber null isto é muito importante quando o dado seja ausente, ou seja, 
//         quando você não nescessita tanto de um dado ou ele não é tão importante.


// O que é Camel Case ? Dê um exemplo de sua aplicação
//         Responta: É uma convenção de nomenclatura onde a primeira palavra 
//         é escrita em desimendado e apartir da segunda palavra 
//         inicia com primeira letra maiuscula e o restante minusucla ex: (camelCase, terceiraGuerraMundial, golDoInter).
//         Usa-se em variáveis, parametros de funções, funções, metodos privados. 





// O que é Pascal Case ? Dê um exemplo de sua aplicação
//         Responta: É uma convenção de nomenclatura onde apenas a primeira letra é maiuscula 
//         e se quiser usar outras palavras para complementar segue a mesma regra ex:
//         (PascalCase, TerceiraGuerraMundial, GolDoInter).
//         Usa-se em classes , metodos public e propriedade. 


// Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
// seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)

class Somando
{
    public static void SomarXeY()
    {
        int x = 77;
        int y = 66;

        int soma = x + y;
        Console.WriteLine($"A soma deu {soma}");
    }
}




// Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.

//          Tipo	Valor Padrão
        //  bool	 false
        //  char	 '\0' (caractere nulo)
        //  int	     0
        //  double	 0.0
        //  float	 0.0f
        //  decimal	 0.0m
        //  string	 null