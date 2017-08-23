using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {
    public Transform Player1;
    public Transform Player2;
    private Vector3 offset;
    private Camera camera;
	// Use this for initialization
	void Start () {
        camera = this.GetComponent<Camera>();
        offset =transform.position - (Player1.position + Player2.position) / 2;
	}
	
	// Update is called once per frame
	void Update () {
        if (Player1 == null || Player2 == null) return;
        else
        {
             transform.position = (Player1.position + Player2.position) / 2 + offset;
                    float distance = Vector3.Distance(Player1.position, Player2.position);
                    float size = distance * 0.747f;
                    camera.orthographicSize = size;
        }
       
    }
}
