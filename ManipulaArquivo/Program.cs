const string caminhoArquivo = "C:\\WorkSpace\\VisualStudio\\ManipulaArquivo\\ManipulaArquivo\\arquivo.txt";

//File.Create(caminhoArquivo);

////AppendText: carrega para o objeto arquivo, todo o conteúdo já existente
//using var arquivo = File.AppendText(caminhoArquivo);
//arquivo.WriteLine("Teste");
//arquivo.Close();

////CreateText: carrega para o objeto arquivo, o arquivo limpo, para substituir o que existia, pelo que será feito
//using var arquivo = File.CreateText(caminhoArquivo);
//arquivo.WriteLine("Teste");
//arquivo.Close();

////Copy e Move possui 3 parâmetros: 1, caminho e nome do arquivo origem; 2, caminho e nome do arquivo destino; 3- bool para sobrescrita de um possível arquivo já existente
//File.Copy(caminhoArquivo,
//    "C:\\WorkSpace\\VisualStudio\\ManipulaArquivo\\ManipulaArquivo\\arquivo-copia.txt",
//    true);
//File.Move(caminhoArquivo,
//    "C:\\WorkSpace\\VisualStudio\\ManipulaArquivo\\ManipulaArquivo\\arquivo-recortado.txt",
//    true);

////Replace: Pega o conteúdo do Origem (primeiro parâmetro), e antes de substituit o conteúdo do destino (segundo parâmetro), ele copia este conteúdo que será sobrescrito para um arquivo de backup opcional
//File.Replace("C:\\WorkSpace\\VisualStudio\\ManipulaArquivo\\ManipulaArquivo\\arquivo-copia.txt",
//    caminhoArquivo,
//    "C:\\WorkSpace\\VisualStudio\\ManipulaArquivo\\ManipulaArquivo\\arquivo-backup.txt");

//File.Delete(caminhoArquivo);

//Console.WriteLine(File.Exists(caminhoArquivo) ? "Arquivo existente" : "Arquivo inexistente");
//Console.WriteLine(File.GetLastAccessTime(caminhoArquivo));

//GetAttributes: Carrega os atributos de um arquivo, que podem ser comparados num switch
var atributos = File.GetAttributes(caminhoArquivo);
switch (atributos)
{
    case FileAttributes.ReadOnly:
        Console.Write("ReadOnly");
        break;
    case FileAttributes.Hidden:
        Console.Write("Hidden");
        break;
    case FileAttributes.Archive:
        Console.Write("Archive");
        break;
    case FileAttributes.Normal:
        Console.Write("Normal");
        break;
    case FileAttributes.Compressed:
        Console.Write("Compressed");
        break;
    default:
        break;
}