using Confluent.Kafka;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaProducerApp
{
    public partial class Form1 : Form
    {
        private IProducer<Null, string> producer;

        public Form1()
        {
            InitializeComponent();
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };
            producer = new ProducerBuilder<Null, string>(config).Build();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                await producer.ProduceAsync("test-topic", new Message<Null, string> { Value = message });
                txtMessage.Clear();
            }
        }
    }
}
