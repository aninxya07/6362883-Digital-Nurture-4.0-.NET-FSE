using Confluent.Kafka;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaConsumerApp
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Run(() => StartConsumer());
        }

        private void StartConsumer()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "consumer-group-1",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("test-topic");

            try
            {
                while (true)
                {
                    var cr = consumer.Consume(CancellationToken.None);
                    Invoke(new Action(() => lstMessages.Items.Add(cr.Message.Value)));
                }
            }
            catch (OperationCanceledException) { consumer.Close(); }
        }
    }
}
