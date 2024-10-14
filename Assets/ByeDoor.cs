using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeDoor : MonoBehaviour
{
    public GameObject door;
    int socketsFull;
    
    // Start is called before the first frame update
    void Start()
    {
        socketsFull = 0;
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SocketIn()
    {
        socketsFull = socketsFull + 1;
        Debug.Log(socketsFull);

        if (socketsFull == 2)
        {
            door.SetActive(false);
            
        }
    }

    public void SocketOut() 
    { 
        //socketsFull--;
    }
}
