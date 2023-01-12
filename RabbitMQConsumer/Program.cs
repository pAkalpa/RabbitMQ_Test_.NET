using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQConsumer;
using System.Text;
//Here we specify the Rabbit MQ Server. we use rabbitmq docker image and use it
/*var factory = new ConnectionFactory
{
    HostName = "localhost"
};
//Create the RabbitMQ connection using connection factory details as i mentioned above
var connection = factory.CreateConnection();
//Here we create channel with session and model
using
var channel = connection.CreateModel();
//declare the queue after mentioning name and a few property related to that
channel.QueueDeclare("test", exclusive: false);
//Set Event object which listen message from chanel which is sent by producer
var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, eventArgs) => {
    var body = eventArgs.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($"Test message received: {message}");
};
//read the message
channel.BasicConsume(queue: "test", autoAck: true, consumer: consumer);*/

var rpcClient = new RpcClient();

var response = rpcClient.Call("Echo ----->>>");

Console.WriteLine($"<<<-----{response}");

rpcClient.Close();
/*
Console.ReadKey();*/