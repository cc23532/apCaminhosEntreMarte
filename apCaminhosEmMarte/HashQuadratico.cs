using System;
using System.Collections.Generic;

namespace apCaminhosEmMarte
{
    public class HashQuadratico<Tipo> : ITabelaDeHash<Tipo>
        where Tipo : IRegistro<Tipo>
    {
        private const int TAMANHO = 131; // número primo > 100
        private Tipo[] tabela;

        public HashQuadratico()
        {
            tabela = new Tipo[TAMANHO];
        }

        public int Hash(string chave)
        {
            long total = 0;
            for (int i = 0; i < chave.Length; i++)
                total += 37 * total + (char)chave[i];

            total = total % tabela.Length;
            if (total < 0)
                total += tabela.Length;
            return (int)total;
        }

        public void Inserir(Tipo item)
        {
            int indice = Hash(item.Chave);
            int tentativa = 1;

            while (tabela[indice] != null)
            {
                indice = (indice + tentativa * tentativa) % TAMANHO; // sondagem quadrática
                tentativa++;
            }

            tabela[indice] = item;
        }

        public bool Remover(Tipo item)
        {
            int indice = Hash(item.Chave);
            int tentativa = 1;

            while (tabela[indice] != null)
            {
                if (tabela[indice].Equals(item))
                {
                    tabela[indice] = default(Tipo); 
                    return true;
                }
                indice = (indice + tentativa * tentativa) % TAMANHO; // sondagem quadrática
                tentativa++;
            }

            return false;
        }

        public bool Existe(Tipo item, out int posicao)
        {
            int indice = Hash(item.Chave);
            int tentativa = 1;

            while (tabela[indice] != null)
            {
                if (tabela[indice].Equals(item))
                {
                    posicao = indice;
                    return true;
                }
                indice = (indice + tentativa * tentativa) % TAMANHO; // sondagem quadrática
                tentativa++;
            }

            posicao = -1;
            return false;
        }

        public List<Tipo> Conteudo()
        {
            List<Tipo> conteudo = new List<Tipo>();
            foreach (var item in tabela)
            {
                if (item != null)
                {
                    conteudo.Add(item);
                }
            }
            return conteudo;
        }
    }
}
