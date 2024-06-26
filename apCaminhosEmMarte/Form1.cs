﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCaminhosEmMarte
{
  public partial class FrmCaminhos : Form
  {
        SaveFileDialog dlgSalvar;

        public FrmCaminhos()
    {
          InitializeComponent();
          dlgSalvar = new SaveFileDialog();

     }

        ITabelaDeHash<Cidade> tabela;

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {

    }
        private void AtualizarListaCidades()
        {
            lsbCidades.Items.Clear(); // Limpar o ListBox
            var asCidades = tabela.Conteudo();
            foreach (Cidade cid in asCidades)
                lsbCidades.Items.Add(cid);
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
          if (dlgAbrir.ShowDialog() == DialogResult.OK)
          {
            if (rbBucketHash.Checked)
               tabela = new BucketHash<Cidade>();
            else
              if (rbHashLinear.Checked)
                 tabela = new HashLinear<Cidade>();
              else 
                if (rbHashQuadratico.Checked)
                   tabela = new HashQuadratico<Cidade>();
                else
                  if (rbHashDuplo.Checked)
                    tabela = new HashDuplo<Cidade>();

            var arquivo = new StreamReader(dlgAbrir.FileName);
            while (! arquivo.EndOfStream) 
            {
              Cidade umaCidade = new Cidade();
              umaCidade.LerRegistro(arquivo);
              tabela.Inserir(umaCidade);
            }
            AtualizarListaCidades();
            arquivo.Close();
            DesenharPontos(pbMapa.CreateGraphics());
            DesenharPontos(pbMapaCaminhos.CreateGraphics());

            }
        }

        private void FrmCaminhos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabela != null)
            {
                if (dlgSalvar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter arquivoSaida = new StreamWriter(dlgSalvar.FileName))
                        {
                            var conteudo = tabela.Conteudo();

                            foreach (var cidade in conteudo)
                            {
                                cidade.GravarDados(arquivoSaida);
                            }
                        }

                        MessageBox.Show("Dados salvos com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao salvar os dados: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há dados para salvar.");
            }
        }

        private void DesenharPontos(Graphics g)
        {
            if (tabela != null)
            {
                var conteudo = tabela.Conteudo();
                Brush brush = Brushes.Black;
                int pontoSize = 7;

                double escalaX = pbMapa.Width;
                double escalaY = pbMapa.Height;

                foreach(var cidade in conteudo)
                {
                    int x = (int)(cidade.X * escalaX);
                    int y = (int)(cidade.Y * escalaY);

                    g.FillEllipse(brush, x - pontoSize / 2, y - pontoSize / 2, pontoSize, pontoSize);
                    g.DrawString(cidade.NomeCidade, Font, brush, x + pontoSize, y);
                }

            }
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Criar uma nova cidade com base nos valores fornecidos pelo usuário
            Cidade novaCidade = new Cidade();
            novaCidade.NomeCidade = txtCidade.Text;
            novaCidade.X = (double)udX.Value;
            novaCidade.Y = (double)udY.Value;

            // Verificar se a tabela não é nula
            if (tabela != null)
            {
                // Verificar se a cidade já existe na tabela
                int posicao;
                if (tabela.Existe(novaCidade, out posicao))
                {
                    MessageBox.Show("A cidade já existe na tabela.");
                    return; // Sair do método sem inserir a cidade novamente
                }

                // Inserir a nova cidade na tabela de hash
                tabela.Inserir(novaCidade);

                // Atualizar a lista de cidades exibida no ListBox
                AtualizarListaCidades();
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Verificar se uma cidade está selecionada no ListBox
            if (lsbCidades.SelectedItem != null)
            {
                // Obter a cidade selecionada
                Cidade cidadeSelecionada = (Cidade)lsbCidades.SelectedItem;

                // Remover a cidade da tabela de hash
                if (tabela != null)
                {
                    // Verificar se a cidade existe na tabela antes de tentar removê-la
                    int posicao;
                    if (!tabela.Existe(cidadeSelecionada, out posicao))
                    {
                        MessageBox.Show("A cidade não existe na tabela.");
                        return; // Sair do método sem tentar remover a cidade
                    }

                    // Remover a cidade da tabela de hash
                    bool removido = tabela.Remover(cidadeSelecionada);
                    if (removido)
                    {
                        // Atualizar a lista de cidades exibida no ListBox
                        AtualizarListaCidades();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao remover a cidade da tabela.");
                    }
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                string nomeCidadeBusca = txtCidade.Text.Trim();

                if (tabela != null)
                {
                    Cidade cidadeBusca = new Cidade { NomeCidade = nomeCidadeBusca };

                    int posicao;
                    bool encontrada = tabela.Existe(cidadeBusca, out posicao);

                    if (encontrada)
                    {
                        MessageBox.Show($"A cidade '{nomeCidadeBusca}' foi encontrada na posição {posicao} da tabela de hash.");
                    }
                    else
                    {
                        MessageBox.Show($"A cidade '{nomeCidadeBusca}' não foi encontrada na tabela de hash.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome da cidade para realizar a busca.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lsbCidades.Items.Clear(); // Limpar o ListBox

            if (tabela != null)
            {
                var conteudo = tabela.Conteudo();

                foreach (var cidade in conteudo)
                {
                    lsbCidades.Items.Add(cidade);
                }
            }
            else
            {
                MessageBox.Show("A tabela de hash está vazia. Não há cidades para listar.");
            }
        }

    }
}
