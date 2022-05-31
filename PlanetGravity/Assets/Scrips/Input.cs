
using UnityEngine;
using UnityEngine.Events;

public class Input : MonoBehaviour
{
    public EnumEvent enumEvent;

    void Update()
    {
        GetInput(1.0f);
    }

    private void GetInput(float position)
    {
       
        if (UnityEngine.Input.GetKey(KeyCode.UpArrow))
        {
            enumEvent.Invoke(Orientation.Up);
        }
        
        if (UnityEngine.Input.GetKey(KeyCode.DownArrow))
        {
            enumEvent.Invoke(Orientation.Down);
        }

        if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))
        {
            enumEvent.Invoke(Orientation.Left);
        }

        if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
        {
            enumEvent.Invoke(Orientation.Rigth);

        }

    }
}
