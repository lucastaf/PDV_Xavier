using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PDV_Xavier
{
    internal class JsonConector
    {
        private static JsonConector instance;
        private string connectionPath;
        public bool isConected { get; private set; } = false;

        private class Configuracoes
        {
            public decimal ValorEmCaixa;
        }

        private Configuracoes configuracao;
        public decimal ValorEmCaixa
        {
            get
            {
                if (configuracao != null)
                {
                    return configuracao.ValorEmCaixa;
                }
                else
                {
                    throw new InvalidOperationException("Configuração não carregada corretamente.");
                }
            }
            set
            {
                if (configuracao != null)
                {
                    configuracao.ValorEmCaixa = value;
                    string json = JsonConvert.SerializeObject(configuracao, Formatting.Indented);
                    File.WriteAllText(connectionPath, json);
                }
                else
                {
                    throw new InvalidOperationException("Configuração não carregada corretamente.");
                }
            }
        }

        private JsonConector()
        {
            try
            {

                if (Properties.Settings.Default.CaminhoJson != null)
                {
                    if (File.Exists(Properties.Settings.Default.CaminhoJson))
                    {
                        connectionPath = Properties.Settings.Default.CaminhoJson;
                        isConected = true;

                        string json = File.ReadAllText(connectionPath);
                        this.configuracao = JsonConvert.DeserializeObject<Configuracoes>(json);
                    }
                }
            }
            catch
            {
                connectionPath = null;
                isConected = false;
            }
        }

        public static JsonConector getInstance()
        {
            if (instance is null)
            {
                instance = new JsonConector();
            }
            return instance;
        }

        public void setConnectionPath(string path)
        {
            Console.WriteLine("Setando o caminho do JSON: " + path);
            if (File.Exists(path))
            {
                connectionPath = path;
                Properties.Settings.Default.CaminhoJson = connectionPath;
                Properties.Settings.Default.Save();
                isConected = true;

                string json = File.ReadAllText(connectionPath);
                this.configuracao = JsonConvert.DeserializeObject<Configuracoes>(json);
                if (this.configuracao == null)
                {
                    throw new Exception("Erro ao carregar o arquivo JSON. Verifique o formato do arquivo.");
                }
            }
            else
            {
                throw new FileNotFoundException("O caminho do arquivo JSON não existe.");
            }
        }

    }
}
