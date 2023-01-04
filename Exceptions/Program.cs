// var arr = new int[3];

// Salvar("");

// static void Salvar(string texto){
//     if(string.IsNullOrEmpty(texto))
//         throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
// }

var arr = new int[3];

try{
    for(var index = 0; index < 10; index++){
        Console.WriteLine(arr[index]);
    }
}catch(Exception ex){
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Ops, algo deu errado");
}finally{
    Console.WriteLine("Chegu ao fim");
}