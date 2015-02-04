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
        public Form1()
        {
            InitializeComponent();
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
        private async Task<MijnPlant> GetPlantAsync(String art_code)
        {
            using (HttpClient client = new HttpClient())
            {
                MijnPlant planten = null;
                client.BaseAddress = new Uri("http://localhost:59318/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/planten/"+art_code);
                if (response.IsSuccessStatusCode)
                {
                    return planten = await response.Content.ReadAsAsync<MijnPlant>();
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
            MijnPlant p = await GetPlantAsync((string)plantComboBox.SelectedValue);
            if (p != null)
            {
                mijnPlantBindingSource.DataSource = p;
            }
            else
            {
                MessageBox.Show("Niet gevonden");
            }
        }
    }
}
