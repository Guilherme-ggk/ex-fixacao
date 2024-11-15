using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace AppTempo
{
    public partial class Pagina1 : Form
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pagina1_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void btntestetempo_Click(object sender, EventArgs e)
        {
            string apiKey = "a722dcff608064d53bb9f544f0ee8522"; // Coloque sua API Key
            string city = txtCity.Text.Trim(); // Pega o texto da caixa de entrada
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Por favor, insira uma cidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Verifique se a resposta não está vazia ou em formato inesperado
                    if (string.IsNullOrEmpty(responseBody))
                    {
                        MessageBox.Show("Resposta da API está vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Verificar se o JSON é válido
                    JObject weatherData;
                    try
                    {
                        weatherData = JObject.Parse(responseBody);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Resposta da API não está em formato JSON esperado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar os campos necessários
                    if (weatherData["main"] == null || weatherData["weather"] == null)
                    {
                        MessageBox.Show("A resposta não contém os campos esperados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Processar os dados
                    string cityName = weatherData["name"]?.ToString();
                    string temp = weatherData["main"]["temp"]?.ToString();
                    string description = weatherData["weather"]?[0]?["description"]?.ToString();

                    txtresultado.Text = $"Cidade: {cityName}\n" +
                                        $"Temperatura: {temp} °C\n" +
                                        $"lima: {description}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao acessar a API: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
