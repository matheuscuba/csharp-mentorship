## #1 - Estruturas e Tipos

Informações retiradas da [documentação oficial da Microsoft](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/types)

Artigo útil para [diferença entre tipos númericos](https://exceptionnotfound.net/decimal-vs-double-and-other-tips-about-number-types-in-net/#:~:text=Int64%20(aka%20long)%3A%20A,range%20than%20Single%20or%20Double.)


### Class Types

#### Object

O tipo `object` no C# é tipo pai de todos outros tipos. Cada um dos tipos na linguagem herda diretamente ou indiretamente desse:

```
object obj = "Matheus Cuba";
```

#### Dynamic

O tipo `dynamic` assim como `object` pode ser aplicado para qualquer outro tipo. Quando são aplicadas operações a esse tipo, estas são resolvidas apenas em _runtime_

```
dynamic dyn = "Matheus Cuba";
```

#### String

O tipo `string` pode ser declarado como `string` ou `String`. Representa um conjunto carácteres unicode e é declarado usando aspas duplas `"`;
```
string nome = "Matheus Cuba";
```

### Value Types

#### Char

O tipo `char` representa um único carácter unicode e é declarado usando aspas simples `'`;
```
char inicial = 'M';
```

#### Boolean

O tipo `bool` representa um booleano que pode ser `true` ou `false`;
```
bool verdadeiro = true;
```

#### Números

O tipo `int` representa um número inteiro de 32 bits (4 bytes)
```
int idade = 24;
```

O tipo `long` representa um número inteiro de 64 bits (8 bytes)
```
long numeroGrande = 1111111111111111111;
```

O tipo `float` representa um número decimal de 32 bits
```
float numeroFloat = 999.12F;
```


O tipo `double` representa um número decimal de 64 bits
```
double numeroDouble = 999.10;
```


O tipo `decimal` representa um número decimal de 128 bits com um range menor, porém com melhor precisão do que um `float` ou `double`
```
decimal numeroDecimal = 999.10m;
```


#### Enums

Enum é um tipo distinto que declara um conjunto de constantes nomeadas
```
enum Color
{
    Red,
    Green,
    Blue
}
```