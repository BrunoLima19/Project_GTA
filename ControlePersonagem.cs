using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{

    [SerializeField] float speed = 5.0f;
    private Animator heroi;
    public GameObject ObjTaco;
    private bool comTaco = false;
    public AudioSource somPegarTaco;
    public AudioSource somZombie;
    public AudioSource somBater;

    void Start() {
        speed = 5.0f;
        heroi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            heroi.SetBool("Correndo", true);
            heroi.SetBool("Parado", false);
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
            heroi.SetBool("Correndo", true);
            heroi.SetBool("Parado", false);
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, -1, 0);
            heroi.SetBool("Correndo", true);
            heroi.SetBool("Parado", false);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, 1, 0);
            heroi.SetBool("Correndo", true);
            heroi.SetBool("Parado", false);
        }

        if (!Input.anyKey) {
            heroi.SetBool("Correndo", false);
            heroi.SetBool("Parado", true);
        }

        if (Input.GetKey(KeyCode.Space)) {
            heroi.SetBool("Ataque", true);
            somBater.Play();
        }
    }

    void OnTriggerStay(Collider collider) 
    {
        if (collider.gameObject.tag == "Taco")
        {
            comTaco = true;
            Destroy(collider.gameObject);
            somPegarTaco.Play();
        }
        if (collider.gameObject.tag == "Zombie"){
            somZombie.Play();
        }
    }
}