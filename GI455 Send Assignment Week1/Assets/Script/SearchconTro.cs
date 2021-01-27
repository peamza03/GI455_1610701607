using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchconTro : MonoBehaviour
{
    [SerializeField] Text dataTesxt;
    [SerializeField] string[] data; 
    [SerializeField] Text output;
    [SerializeField] InputField add;
    GUIStyle style = new GUIStyle();
    
    // Start is called before the first frame update
    void Start()
    {
        style.richText = true;
        dataTesxt.text = data[0]+
                            "\n"+data[1]+
                            "\n" + data[2]+
                            "\n" + data[3]+
                            "\n" + data[4];
        //for (int i = 0; i <= data.Length; i++)
        //{
        //    if (add.text == data[0])
        //    {
        //        print(add.text + " is found ");
        //    }
        //    else
        //    {
        //        output.text = add.text + " is not found ";
        //    }
        //}
    //    int i = 0;
    //    do
    //    {
    //        print(i);
    //        print(data[i] + " is not found ");
    //        i++;

    //    } while (i <= data.Length);
    }

    // Update is called once per frame
    void Update()
    {
      

    }

    public void Search ()
    {
        int i = 0;
        do
        {
            if (add.text == data[i])
            {
                output.text = add.text + " is found ";
                return;
            }
          
            i++;

        } while (i < data.Length);
        
            output.text = add.text + " is not found ";
        

    }
    
}
