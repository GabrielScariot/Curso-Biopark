
main();

int main(){
    
    /*Endereco endereco1= new Endereco();
    endereco1.exibirEndereco();

    Endereco endereco2= new Endereco(54, "Parigot", "Porto Alegre", "Toledo");
    endereco2.exibirEndereco();*/
    /*Endereco end = new Endereco(54, "Parigot", "Porto Alegre", "Toledo");

    Pessoa pessoa1= new Pessoa("Joao", "655666", end);

    pessoa1.getDados();

    pessoa1.setSenha("1254");

    pessoa1.getDados();*/
    

    Pessoa test = new Pessoa();

    test.setNome();
    test.setSenha();
    test.setRua();
    test.setNumero();
    test.setBairro();
    test.setCidade();
    
    test.getDados();

    return 0;
}


class Endereco{
    private int numero;
    private string rua;
    private string bairro;
    private string cidade;
    public Endereco(){
        this.numero=0;
        this.rua ="";
        this.bairro= "";
        this.cidade ="";
    }
    public Endereco(int numero, string rua, string bairro, string cidade){
        this.numero= numero;   
        this.rua = rua;
        this.bairro= bairro;
        this.cidade = cidade;
    }
    public string getCidade(){return this.cidade;}
    public int getNumero(){return this.numero;}
    public string getBairro(){return this.bairro;}
    public string getRua(){return this.rua;}
    public void setNumero(int numero){this.numero=numero;}
    public void setRua(string rua){this.rua=rua;}
    public void setCidade(string cidade){this.cidade=cidade;}
    public void setBairro(string bairro){this.bairro=bairro;}
    public void exibirEndereco(){
        Console.WriteLine("Numero: "+ getNumero()+ " Rua: "+ getRua()+ " Bairro: " + getBairro()+ " Cidade: "+ getCidade());
    }
}

class Pessoa : Endereco{
    private string nome;

    private string senha;

    private Endereco endereco;

    public Pessoa(){
        this.nome="";
        this.senha="";
        this.endereco= new Endereco();
    }

    public Pessoa(string nome, string senha,Endereco endereco){
        this.senha=senha;

        this.nome=nome;
        this.endereco= endereco;
    }

    public string getNome(){return this.nome;}

    public string getSenha(){return this.senha;}

    public void getEndereco(){
        endereco.exibirEndereco();

    }

    public void getDados(){

        Console.WriteLine("Nome: "+getNome()+ " Senha:"+ senha);

       this.endereco.exibirEndereco();

    }

    public void setSenha()
    {
        Console.WriteLine("Digite sua senha:");
        senha = Console.ReadLine();
    }
    public void setNome(){
        Console.WriteLine("Digite seu nome:");
        this.nome= Console.ReadLine();


    }
    public void setNumero(){
        Console.WriteLine("Digite o numero da sua casa");

        int numero = int.Parse(Console.ReadLine());

        this.endereco.setNumero(numero);
        
        }
    public void setRua(){
        Console.WriteLine("Digite sua rua");
        string rua= Console.ReadLine();

        this.endereco.setRua(rua);



    }
    public void setCidade(){
        Console.WriteLine("Digite sua cidade");
        string cidade= Console.ReadLine();
    
        this.endereco.setCidade(cidade);



    }
    public void setBairro(){
        Console.WriteLine("Digite seu Bairro");
        string bairro= Console.ReadLine();
    
        this.endereco.setBairro(bairro);




    }
}
