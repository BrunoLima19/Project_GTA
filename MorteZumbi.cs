//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class MorteZumbi : MonoBehaviour
//{
//
//    public bool ataque = false;
//    public AudioSource dieZombie;
//
//    void OnTriggerStay(Collider collider) {
//        if (ataque && collider.gameObject.tag == "Zombie") {
//            Animator enemyAnimator = collider.GameObject.GetComponent<Animator>();
//            enemyAnimator.SetBool("dieZombie", true);
//            dieZombie.Play();
//        }
//    }
//}
