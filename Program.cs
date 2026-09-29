List<string>nome_produ = new List<string>();
List<string>segmento = new List<string>();
List<string>marca = new List<string>();
List<decimal>valor = new List<decimal>();

//Tela inicial
int opc;

do
{
    Console.WriteLine("================================");
    Console.WriteLine("       SISTEMA DE PRODUTOS");
    Console.WriteLine("================================");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Filtrar");
    Console.WriteLine("4 - Alterar");
    Console.WriteLine("5 - Remover");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("================================");

    opc = Convert.ToInt32(Console.ReadLine());

    switch (opc)
    {
        case 1: 
//Cadastrar
           Console.WriteLine("---------------------------------------");

           string nomeproduto;

           do
            {
                Console.WriteLine("Qual o nome do produto?");
                nomeproduto = Console.ReadLine().Trim();

                if(string.IsNullOrWhiteSpace(nomeproduto))
                {
                     Console.WriteLine("O nome do produto não pode ficar vazio.");
                }
            
            }while (string.IsNullOrWhiteSpace(nomeproduto));

         string tipoprodu;

            do
            {
                Console.WriteLine("Qual o segmento do produto?");
                tipoprodu = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(tipoprodu))
                {
                    Console.WriteLine("O segmento não pode ficar vazio.");
                }

            } while (string.IsNullOrWhiteSpace(tipoprodu));

         string marcaprodu;

            do
            {
                Console.WriteLine("Qual a marca do produto?");
                marcaprodu = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(marcaprodu))
                {
                    Console.WriteLine("A marca não pode ficar vazia.");
                }

            } while (string.IsNullOrWhiteSpace(marcaprodu));

         decimal valorprodu;

            do
            {
                Console.WriteLine("Qual o valor do produto?");

                if (!decimal.TryParse(Console.ReadLine(), out valorprodu))
                {
                    Console.WriteLine("Digite um valor numérico válido.");
                    continue;
                }

                if (valorprodu <= 0)
                {
                    Console.WriteLine("O valor deve ser maior que zero.");
                }

            } while (valorprodu <= 0);


        nome_produ.Add(nomeproduto);
        segmento.Add(tipoprodu);
        marca.Add(marcaprodu);
        valor.Add(valorprodu);

            break;
//Listar
        case 2:

        if (nome_produ.Count == 0)
    {
        Console.WriteLine("Não existem produtos para listar.");
        break;
    }

           for(int i = 0; i < nome_produ.Count; i ++ )
{
    Console.WriteLine($"Nome : {nome_produ[i]}");
    Console.WriteLine($"Segmento : {segmento[i]}");
    Console.WriteLine($"Marca : {marca[i]}");
    Console.WriteLine($"Valor :{valor[i]}");
}



            break;
//Filtrar
        case 3:

        if (nome_produ.Count == 0)
    {
        Console.WriteLine("Não existem produtos para filtar .");
        break;
    }
           Console.WriteLine("Filtrar por:");
           Console.WriteLine("1- Marca  ");
           Console.WriteLine("2- Segmento  ");

int opcaoo = Convert.ToInt16(Console.ReadLine());

if(opcaoo == 1)
{
   Console.WriteLine("Qual a marca do produto ? ");
   string pordu = Console.ReadLine().Trim();

   bool encontrado = false;

   for(int i =0; i <marca.Count; i ++)
    {
     if(marca[i].ToLower() == pordu.ToLower())
        {
            Console.WriteLine($" Nome do { nome_produ[i]} , Segmento {segmento[i]}, Marca {marca[i]} , Valor {valor[i]} ");

            encontrado = true;
        }
    }
     if (!encontrado)
    {
        Console.WriteLine("Produto não encontrado.");
    }

}
else if(opcaoo == 2)
{
     Console.WriteLine("Qual o segmento do produto ? ");
     string pordu2 = Console.ReadLine().Trim();

     bool encontrado = false;

    for(int i =0; i < segmento.Count; i ++)
    {
        if(segmento[i].ToLower() == pordu2.ToLower())
        {
         Console.WriteLine($" Nome do { nome_produ[i]} , Segmento {segmento[i]}, Marca {marca[i]} , Valor {valor[i]} ");

          encontrado = true;
        }
    }
   if(!encontrado)
                {
                     Console.WriteLine("Produto não encontrado.");
                }
}
else
{
    Console.WriteLine("Opção inválida.");
}


            break;

        case 4:

        if (nome_produ.Count == 0)
    {
        Console.WriteLine("Não existem produtos para alterar.");
        break;
    }
            Console.WriteLine("Qual o nome do produto que deseja alterar?");
            string allte = Console.ReadLine().Trim();

for(int i =0; i < nome_produ.Count; i ++)
{
    if(nome_produ[i].ToLower() == allte.ToLower())
    {
        Console.WriteLine("Informe os novos dados:");

         Console.Write("Novo nome: ");
    string novoNome = Console.ReadLine().Trim();

    Console.Write("Novo segmento: ");
    string novoSegmento = Console.ReadLine().Trim();

    Console.Write("Nova marca: ");
    string novaMarca = Console.ReadLine().Trim();

    Console.Write("Novo valor: ");
    decimal novoValor = Convert.ToDecimal(Console.ReadLine());
    
    nome_produ[i] = novoNome;
    segmento[i] = novoSegmento;
    marca[i] = novaMarca;
    valor[i] = novoValor;
   

    Console.WriteLine($"Nome do produto : {nome_produ[i]} , segmento : {segmento[i]} , : marca {marca[i]} , valor : {valor[i]} \n... alterado com sucesso.");
    }
}
            break;

        case 5:

          if (nome_produ.Count == 0)
    {
        Console.WriteLine("Não existem produtos para remover.");
        break;
    }    
            Console.WriteLine("Qual nome do produto deseja remover?");
            string nomeprodd = Console.ReadLine().Trim();

 bool encontradoRemover = false;


for(int i =0; i < nome_produ.Count; i ++)
{
    if(nome_produ[i].ToLower() == nomeprodd.ToLower())
    {
        nome_produ.RemoveAt(i);
        segmento.RemoveAt(i);
        marca.RemoveAt(i);
        valor.RemoveAt(i);
    encontradoRemover = true;

    Console.WriteLine("Produto removido com sucesso.");


        break;
    }
} 
 if (!encontradoRemover)
    {
        Console.WriteLine("Produto não encontrado.");
    } 
            break;

        case 0:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

} while (opc != 0);

 

