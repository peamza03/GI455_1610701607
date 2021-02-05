var websocket = require("ws"); //using

var websocketServer = new websocket.Server({port:44002},()=>
{
    console.log("HelloWorld is running");
});

websocketServer.on('connection', function connection(ws)
 {
    console.log("client connected.");
    console.log("Well Come To The HelloWorld");

  ws.on('message', function incoming(data)
    {
        console.log("send from client : " + data);

        websocketServer.clients.forEach(function each(client) 
        {
        if (client !== ws && client.readyState === websocket.OPEN)
            {
                client.send(data);
            }
        });
       
    });
    ws.on("close",()=>
    {

        console.log("client disconnected.");

    });
});