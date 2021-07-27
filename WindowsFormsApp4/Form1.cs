using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string url = "https://0bwg5gwq5b.execute-api.us-east-2.amazonaws.com/DEV/v1/convert";

                var client = new RestClient(url);

                var request = new RestRequest();

                var body = new post { initialValue = 11, initialUOM = "lb", desiredUOM = "kg", result = "" };

                request.AddJsonBody(body);

                var response = client.Post(request);

            textBox1.Text = "(response.StatusCode.ToString()" + ""    + response.Content.ToString();
                Console.WriteLine(response.StatusCode.ToString() + "   " + response.Content.ToString());


                Console.Read();
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

    

