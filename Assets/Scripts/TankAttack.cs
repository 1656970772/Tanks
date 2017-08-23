using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour {
    public GameObject shellPrefab; 
     private Transform firePosition;
   // public AudioClip shotAudio;
    public KeyCode fireKey = KeyCode.Space;
    public float fireSpeed = 10;
	// Use this for initialization
	void Start () {
        firePosition = transform.Find("FirePosition");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireKey))
        {
            //AudioSource.PlayClipAtPoint(shotAudio, transform.position);
           GameObject go= GameObject.Instantiate(shellPrefab, firePosition.position, firePosition.rotation)as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * fireSpeed;
        }
	}
}
