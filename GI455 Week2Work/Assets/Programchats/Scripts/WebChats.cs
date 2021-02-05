using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;
public class WebChats : MonoBehaviour
{
    WebSocket websocket;
    [SerializeField] InputField chatText,port;
    [SerializeField] Text[] text;
    [SerializeField] GameObject[] active;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Sendmessage();
    }

    public void OnDestroy()
    {
        if (websocket != null)
        {
            websocket.Close();
        }
    }

    public void OnMessage(object sender, MessageEventArgs messageEventArgs)
    {
        Debug.Log("Message from server : " + messageEventArgs.Data);
        text[1].text += "\n" + messageEventArgs.Data;
        text[0].text += ""+"\n";
    }

    void Sendmessage()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            text[0].text += "\n"+chatText.text;
            text[1].text +=""+"\n";
            chatText.text = "";
        }
    }

    public void ConnectedToServer()
    {
        websocket = new WebSocket("ws://127.0.0.1:" + port.text + "/"); //127.0.0.1 คือ IP ที่ใช้ในเครื่องตัวเอง

        websocket.OnMessage += OnMessage;

        websocket.Connect();

        active[0].SetActive(true);
        active[1].SetActive(false);
    }
    public void ExitServer()
    {
        
            websocket.Close();
            active[0].SetActive(false);
            active[1].SetActive(true);
        
    }

}