using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosEmMarte
{
    interface IStack<Tipo>
{ 
  void Empilhar(Tipo o);  // atualiza o topo e empilha objeto o
    Tipo Desempilhar();     // remove e devolve objeto do topo da pilha
    int Tamanho { get; }    // número de objetos empilhados
    bool EstaVazia { get; }// informa situação da pilha
    Tipo OTopo();           // devolve objeto do topo da pilha
    List<Tipo> Conteudo();  // retorna a relação de dados da pilha
}
}
