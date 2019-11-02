using UnityEngine;
using System.Collections;

public class HPAnimScript : MonoBehaviour
{

    public void Destroy()
    {
        transform.parent.SendMessage("Destroy");
    }
}
