using Susing System;

namespace program
{
    public class Program
    {
            static void Main ()
            {
                int tempo = 0;
                char escolha;

                inicio:
                Console.WriteLine("Viagem de rolandia para londrina:");
                Console.WriteLine("ESCOLHA SEU MEIO DE TRANSPORTE: A) CARRO B) MOTO");
                escolha = char.Parse(Console.ReadLine());

                switch (escolha)
                {

                    case 'a':
                    case 'A':
                    tempo = 30;
                    break;

                    case 'b':
                    case 'B':
                    tempo = 20;
                    break;



                    
                    default:

                    tempo = -1;

                    break;
                }

                if(tempo == 30){
                    Console.WriteLine("VC ESCOLHEU IR DE CARRO, 30 MNTS");
                }
                else if(tempo == 20){
                    Console.WriteLine("VC ESCOLHEU IR DE MOTO, LEVARA 20 MNTS");
                }

                goto inicio;
            }
    }
}
using System;

namespace program
{
    public class Program
    {
            static void Main ()
            {
                int tempo = 0;
                char escolha;

                inicio:
                Console.WriteLine("Viagem de rolandia para londrina:");
                Console.WriteLine("ESCOLHA SEU MEIO DE TRANSPORTE: A) CARRO B) MOTO");
                escolha = char.Parse(Console.ReadLine());

                switch (escolha)
                {

                    case 'a':
                    case 'A':
                    tempo = 30;
                    break;

                    case 'b':
                    case 'B':
                    tempo = 20;
                    break;



                    
                    default:

                    tempo = -1;

                    break;
                }

                if(tempo == 30){
                    Console.WriteLine("VC ESCOLHEU IR DE CARRO, 30 MNTS");
                }
                else if(tempo == 20){
                    Console.WriteLine("VC ESCOLHEU IR DE MOTO, LEVARA 20 MNTS");
                }

                Console.WriteLine("DESEJA CONTINUAR?");
                Console.WriteLine("S / N");
                escolha = char.Parse(Console.ReadLine());

                if(escolha == 's' || escolha == 'S'){
                    Console.Clear();
                    goto inicio;
                }else if(escolha == 'N' || escolha == 'n'){
                    Console.Clear();
                    Console.WriteLine("FIM");
                }

            }
    }
}
using System;

namespace program
{
    public class  Program
    {
        static void Main ()
        {
            int[] num = new int[3]{11,22,33};
        }
    }
}
 Console.Write(num[2]);
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro.Elo.Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopularDataGridView();
        }

        private void PopularDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=base_pessoas;User=root;Password="))
                {
                    string query = "SELECT * FROM pessoas";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    DTtabela.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conexão = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=base_pessoas;User=root;Password="))
            {
                conexão.Open();

                using (MySqlCommand cmd = conexão.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO pessoas (nome,documento,endereco,Número) VALUES (@nome,@documento,@endereco,@Número)";
                    cmd.Parameters.AddWithValue("@nome", Txtnome.Text);
                    cmd.Parameters.AddWithValue("@documento", textBoxCPF.Text);
                    cmd.Parameters.AddWithValue("@endereco", Txtendereco.Text);
                    cmd.Parameters.AddWithValue("@Número", numeroTxt.Text);


                    cmd.ExecuteNonQuery();
                }

                    MessageBox.Show("CADASTRADO COM SUCESSO!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCPF_Leave(object sender, EventArgs e)
        {
            string cpf = textBoxCPF.Text.Replace(".", "").Replace("-", "");

            if (ValidaCPF(cpf))
            {
                MessageBox.Show("CPF válido!");
            }
            else
            {
                MessageBox.Show("CPF inválido! Por favor, insira um CPF válido.");
            }
        }
        private bool ValidaCPF(string cpf)
        {
            
            if (cpf.Length != 11)
                return false;

            
            if (new string(cpf[0], cpf.Length) == cpf)
                return false;

            
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

           
            if (digitoVerificador1 != int.Parse(cpf[9].ToString()))
                return false;

           
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            
            if (digitoVerificador2 != int.Parse(cpf[10].ToString()))
                return false;

            return true;
        }

        private void textBoxCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTtabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numeroTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
