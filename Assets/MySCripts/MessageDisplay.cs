using UnityEngine;
using UnityEngine.UI;

public class MessageDisplay : MonoBehaviour
{
    public Text messageText; 

    
    public void DisplayMessage(string message)
    {
        messageText.text = message;
        Debug.Log("working");
        
    }

    
    public void ClearMessage()
    {
        messageText.text = "";
        
    }
}

