using System;
using System.Collections.Generic;

namespace apCaminhosEmMarte
{
    public class HashLinear<Tipo> : ITabelaDeHash<Tipo>
        where Tipo : IRegistro<Tipo>
    {
        private const int TAMANHO = 131; // número primo > 100
        private Tipo[] tabela;

        public HashLinear()
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

            while (tabela[indice] != null)
            {
                indice = (indice + 1) % TAMANHO; // sondagem linear
            }

            tabela[indice] = item;
        }

        public bool Remover(Tipo item)
        {
            int indice = Hash(item.Chave);

            while (tabela[indice] != null)
            {
                if (tabela[indice].Equals(item))
                {
                    tabela[indice] = default(Tipo);
                    return true;
                }
                indice = (indice + 1) % TAMANHO; // sondagem linear
            }

            return false;
        }

        public bool Existe(Tipo item, out int posicao)
        {
            int indice = Hash(item.Chave);

            while (tabela[indice] != null)
            {
                if (tabela[indice].Equals(item))
                {
                    posicao = indice;
                    return true;
                }
                indice = (indice + 1) % TAMANHO; // sondagem linear
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
