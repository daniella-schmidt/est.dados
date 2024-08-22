//declarando variavel//
using aula1408;

int number;

number = 10;

const int DAY_IN_WEEK =7;

//imprimindo string contatatenada
Console.WriteLine($"a semna tem {DAY_IN_WEEK} dias");

/*new TipoEnum() -> invoca metodo construtor do objeto toda classe tem o seu constutor padrao 
implicito sem argumento/param.é possivel sobreescrever o metodo especificando argumentosmas, 
se fizer, perdemos o original implicito eprecisarmos defini=lo explicitamente*/
TipoEnum tipoEnum = new TipoEnum();//NOVA INSTACIA

TipoEnum.Language enumEnglish = tipoEnum.GetLanguageEnum ("ingles");
Console.WriteLine( $"o enum de english é {enumEnglish}" );