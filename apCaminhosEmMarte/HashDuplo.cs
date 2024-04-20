using System;
using System.Collections.Generic;

namespace apCaminhosEmMarte
{
    class HashDuplo<Tipo> : ITabelaDeHash<Tipo>
        where Tipo : IRegistro<Tipo>
    {
        private const int TAMANHO = 131; // número primo > 100
        private Tipo[] tabela;

        public HashDuplo()
        {
            tabela = new Tipo[TAMANHO];
        }

        public int Hash1(string chave)
        {
            long total = 0;
            for (int i = 0; i < chave.Length; i++)
                total += 37 * total + (char)chave[i];

            total = total % tabela.Length;
            if (total < 0)
                total += tabela.Length;
            return (int)total;
        }

        public int Hash2(string chave)
        {
            
            return 1 + (chave.Length % (TAMANHO - 1));
        }

        public void Inserir(Tipo item)
        {
            int hash1 = Hash1(item.Chave);
            int hash2 = Hash2(item.Chave);
            int indice = hash1;

            for (int i = 1; tabela[indice] != null; i++)
            {
                indice = (hash1 + i * hash2) % TAMANHO;
            }

            tabela[indice] = item;
        }

        public bool Remover(Tipo item)
        {
            int hash1 = Hash1(item.Chave);
            int hash2 = Hash2(item.Chave);
            int indice = hash1;

            for (int i = 1; tabela[indice] != null; i++)
            {
                if (tabela[indice].Equals(item))
                {
                    tabela[indice] = default(Tipo);
                    return true;
                }
                indice = (hash1 + i * hash2) % TAMANHO;
            }

            return false;
        }

        public bool Existe(Tipo item, out int posicao)
        {
            int hash1 = Hash1(item.Chave);
            int hash2 = Hash2(item.Chave);
            int indice = hash1;

            for (int i = 1; tabela[indice] != null; i++)
            {
                if (tabela[indice].Equals(item))
                {
                    posicao = indice;
                    return true;
                }
                indice = (hash1 + i * hash2) % TAMANHO;
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
