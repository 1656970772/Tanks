using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {
    public int hp = 100;
    public GameObject tankExplosion;
    public float tankExplosionTime;
    public AudioClip tankExplosionAudio;
    public Slider hpSlider;
    private int hpTotal;
    // Use this for initialization
    void Start () {
        hpTotal = hp;  
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void TankDamage()
    {
        if (hp<=0)
        {
            return;
        }
        else
        {
            hp -= Random.Range(5, 10);
            hpSlider.value = (float)hp / hpTotal;
            if (hp<=0)
            {
                AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position );
                GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
               
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
