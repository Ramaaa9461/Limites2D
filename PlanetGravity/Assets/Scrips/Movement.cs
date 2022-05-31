using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float vel = 1.0f;
    LimitsScreen limitsScreen;

    private void Awake()
    {
        limitsScreen = GetComponent<LimitsScreen>();
    }

    public void Move(Orientation orientation)
    {
        switch (orientation)
        {
            case Orientation.Up:

                 transform.position += new Vector3(0, vel, 0);
                break;

            case Orientation.Down:

                 transform.position += new Vector3(0, -vel, 0);
                break;

            case Orientation.Left:

                 transform.position += new Vector3(-vel, 0, 0);

                break;

            case Orientation.Rigth:

                transform.position += new Vector3(vel, 0, 0);

                break;
        }
        limitsScreen.setLimits();
    }

 
}
