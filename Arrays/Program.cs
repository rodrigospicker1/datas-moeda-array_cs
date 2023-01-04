Console.Clear();

// var meuArray = new int[5];

// var meuArray = new int[5]{23, 42, 54, 67, 99};
// meuArray[0] = 12; 

// for(var index = 0; index < meuArray.Length; index++){
//     Console.WriteLine(meuArray[index]);
// }

var funcionarios = new Funcionario[5];
funcionarios[0] = new Funcionario(){Id = 2579, Nome = "André"};

foreach(var funcionario in funcionarios){
    Console.WriteLine(funcionario.Id);
    Console.WriteLine(funcionario.Nome);
}

public struct Funcionario{
    public int Id{ get; set;}

    public string Nome{ get; set;}
}
