using UnityEngine;
 using System.Collections;
 
 [RequireComponent(typeof(Rigidbody))] 
 public class FallCheck : MonoBehaviour {
 
     public Transform player; 
     public float maxDistance = 10f; 
     private Rigidbody rigidbody;

     public bool useGravity = true;
     void Awake () {
         rigidbody = GetComponent<Rigidbody> ();
         //rigidbody.useGravity = false;
     }
 
     void FixedUpdate(){
         rigidbody.useGravity = false;
         if (Vector3.Distance (player.position, transform.position) < maxDistance && useGravity) { //transform is the object that this script is attached to
             rigidbody.AddForce(Physics.gravity * (rigidbody.mass * rigidbody.mass));

            // rigidbody.WakeUp();
         }
     }
 }