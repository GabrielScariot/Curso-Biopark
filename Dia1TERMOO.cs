// See https://aka.ms/new-console-template for more information
main();

int lerNumeroInteiro(){
    int numero =int.Parse(Console.ReadLine());
    return numero;
}

int [] lerSenhaDigitada(){
    int [] senhaDigitada = new int[5];
    for(int i=0;i<5;i++){
        Console.WriteLine("Dgiite o valor da posicao " + (i+1)+":");
        senhaDigitada[i]=lerNumeroInteiro();
    }   

    return senhaDigitada;
}

void Contador(){
    for(int i=0;i<5;i++){
        Console.WriteLine(i);
    }
} 

int[] gerarSenha(){
    Random randNumero = new Random();
    int[] senha = new int[5];
    for(int i=0;i<5;i++){
        senha[i] =randNumero.Next(10); 
        for(int j=i-1;j>=0;j--){
            if(senha[i]==senha[j]){
                i--;
                j=0;
            }
        }
                
    }
   return senha;
}

char [] comparaSenha(int [] digitado, int [] senha){
    char [] resposta = new char[5];
    for(int i=0;i<5;i++){
       resposta[i]='N'; 
        for(int j=0;j<5;j++){
            if(digitado[i]==senha[j]){
                if(i==j){
                    resposta[i]='c';
                }
                else{
                    resposta[i]='p';

                }
                
            }
        }
                
    }
    return resposta;
}

bool verificaVitoria(char [] resposta){
    for(int i =0;i<5;i++){
        if(resposta[i]!='c'){
            return false;
        }
    }
    return true;
}
void exibirSenha(int []senha){
      for(int i=0;i<5;i++){
        Console.WriteLine(senha[i]);
    }

}

int main(){
    //int numero = lerNumeroInteiro();
    bool vitoria = false;
    int[] senha = gerarSenha();
    int[] senhaDigitada = new int[5];
    char[] resposta = new char[5];
     while(!vitoria){
        senhaDigitada = lerSenhaDigitada();
        resposta= comparaSenha(senhaDigitada,senha); 
        vitoria = verificaVitoria(resposta);
    
        Console.Clear();
        exibirSenha(senhaDigitada);
        Console.WriteLine("");
        Console.WriteLine(resposta);   
    }
    Console.WriteLine("Voce venceu");
    Console.ReadKey();
    return 0;
}