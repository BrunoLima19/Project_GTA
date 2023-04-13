using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;

    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = false;
    }

    // Update is called once per frame
    void Update() {
    if (Input.GetKeyDown(KeyCode.Alpha1)) { // verifica se a tecla 1 foi pressionada
        camera1.enabled = true; // ativa a camera 1
        camera2.enabled = false; // desativa a camera 2
        camera3.enabled = false; // desativa a camera 3
    }
    if (Input.GetKeyDown(KeyCode.Alpha2)) { // verifica se a tecla 2 foi pressionada
        camera1.enabled = false; // desativa a camera 1
        camera2.enabled = true; // ativa a camera 2
        camera3.enabled = false; // desativa a camera 3
    }
    if (Input.GetKeyDown(KeyCode.Alpha3)) { // verifica se a tecla 3 foi pressionada
        camera1.enabled = false; // desativa a camera 1
        camera2.enabled = false; // desativa a camera 2
        camera3.enabled = true; // ativa a camera 3
    }
}

}
