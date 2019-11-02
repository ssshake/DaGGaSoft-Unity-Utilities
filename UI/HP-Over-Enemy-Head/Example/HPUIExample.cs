using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPUIExample : MonoBehaviour
{

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            showHPUI(20);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            showHPUI(-20);
        }
    }
    public void showHPUI(int value)
    {
        GameObject HPUI = GameObject.Instantiate(
            Resources.Load("HPUI", typeof(GameObject)),
            new Vector3(transform.position.x, gameObject.GetComponent<BoxCollider>().size.y / 2, transform.position.z - 1),
            Quaternion.Euler(0, 0, 0)
        ) as GameObject;
        HPUI.SendMessage("SetText", value);
    }
}