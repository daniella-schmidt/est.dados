/*umma fila é a estrutura de dados que pode ser aplcada para 
representar a fila de atendimanto da cantina, as pessoas que 
chegam entram no fim da fila, e, primeiras são atendidas primeiro*/

//a função ENQUEUE adiciona novos elementos a fila
//a função DEQUEUE remove elementos

//desta forma obdece o FIFO (First In First Out)
using Filas;

Random random = new Random();

CallCenter center = new CallCenter();
center.Call(5561);
center.Call(2525);
center.Call(8614);
center.Call(3542);

while (center.AreWaitingCalls())
{
    Thread.Sleep (3000);
    IncomingCall call = center.Answer("Apolo");
    Console.WriteLine (@$"{DateTime.Now.ToString("HH:mm:ss")} 
                           Chamado:#{call.Id}
                           De: {call.ClientId}
                           Atendido por: {call.Consultant}"); // HH para 24 horas | @ -> quebra de linha

    Thread.Sleep(random.Next(1000, 1000));
    center.End(call);       
    Console.WriteLine(@$"Chamado: {call.Id}
                        Encerrado: {call.EndTime}");                           

}