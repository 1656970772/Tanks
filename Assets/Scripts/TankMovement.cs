using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TankMovement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 10;
    private new Rigidbody rigidbody;
    public AudioClip drivingAudio;
    public AudioClip idleAudio;
  
    private AudioSource audio;
    public float number=2;//增加一个数字来灵活控制坦克
	// Use this for initialization
	void Start () {
        audio = this.GetComponent<AudioSource>();
        rigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       
        float v = Input.GetAxis("VerticalPlayer"+number);
        rigidbody.velocity = transform.forward * speed * v;
        float h = Input.GetAxis("HorizontalPlayer"+number);
        rigidbody.angularVelocity=transform.up*angularSpeed*h;
        if (Mathf.Abs(h)>0.1||Mathf.Abs(v)>0.1)
        {
            audio.clip = drivingAudio;
            if (audio.isPlaying==false)
            {
                audio.Play();
            }
           
        }
        else
        {
            audio.clip = idleAudio;
            if (audio.isPlaying == false)
            {
                audio.Play(); 
            }
           
        }
        // AudioSource.PlayClipAtPoint(moveAudio,transform.position);
	}
}
