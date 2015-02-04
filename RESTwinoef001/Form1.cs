using RESTapioef001.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RESTwinoef001
{
    public partial class Form1 : Form
    {
        private static String[] maanden = { "januari", "februari", "maart", "april", "mei", "juni", "juli", "augustus", "september", "oktober", "november", "december" };
        public Form1()
        {
            InitializeComponent();
            Binding b = bLOEIBEGINTextBox.DataBindings[0];
            b.Format += b_Format;
            Binding b2 = bLOEIEINDETextBox.DataBindings[0];
            b2.Format += b_Format;
        }

        void b_Format(object sender, ConvertEventArgs e)
        {
            int nummerMaand = Convert.ToInt32(e.Value);
            e.Value = maanden[nummerMaand - 1];

        }
        private async Task<Plant[]> GetPlantenAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                Plant[] planten = null;
                client.BaseAddress = new Uri("http://localhost:59318/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/planten");
                if (response.IsSuccessStatusCode)
                {
                    planten = await response.Content.ReadAsAsync<Plant[]>();
                }
                return planten;
            }
        }
        private async Task<PLANTEN> GetPlantAsync(String art_code)
        {
            using (HttpClient client = new HttpClient())
            {
                PLANTEN planten = null;
                client.BaseAddress = new Uri("http://localhost:59318/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/planten/"+art_code);
                if (response.IsSuccessStatusCode)
                {
                    return planten = await response.Content.ReadAsAsync<PLANTEN>();
                }
                else
                {
                    return null;
                }
                
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            plantBindingSource.DataSource = await GetPlantenAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PLANTEN p = await GetPlantAsync((string)plantComboBox.SelectedValue);
            if (p != null)
            {
                pLANTENBindingSource.DataSource = p;
            }
            else
            {
                MessageBox.Show("Niet gevonden");
            }
        }
    }
}
