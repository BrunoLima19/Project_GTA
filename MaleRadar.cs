using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleRadar : MonoBehaviour
{
    private Transform target; //drag and stop player object in the inspector
    public float _range;
    public float speed;
    public float rotationSpeed;

    private Animator maleAnim;
    public int currentTarget;
    public Transform[] allwayPoints;

    public Camera Cam_Male1;
    public Camera Cam_Male2;
    public Camera Cam_Male3;

    void Start()
    {
        maleAnim = GetComponent<Animator>();
        Cam_Male1.enabled = true;
        Cam_Male2.enabled = false;
        Cam_Male3.enabled = false;
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            Cam_Male1.enabled = true; 
            Cam_Male2.enabled = false;
            Cam_Male3.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            Cam_Male1.enabled = false; 
            Cam_Male2.enabled = true;
            Cam_Male3.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            Cam_Male1.enabled = false; 
            Cam_Male2.enabled = false;
            Cam_Male3.enabled = true;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Zombie") {
            Debug.Log("Enter");
        }
    }
    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "Zombie") {
            maleAnim.SetBool("runMale", true);
            target = collision.gameObject.transform;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation( allwayPoints[currentTarget].position-transform.position), rotationSpeed*Time.deltaTime);
            float dist = Vector3.Distance(target.position, transform.position);

            if (dist <= _range) {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
            }
            Debug.Log("Stay");
        }
    }
    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Zombie") {
            maleAnim.SetBool("runMale", false);
            maleAnim.SetBool("walkMale", true);
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0);
            Debug.Log("Exit");
        }
    }
}