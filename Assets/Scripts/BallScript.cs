using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public GameObject plane;
    public GameObject spawnPoint;
    private int count;
    public GUIText winText;
    
	// Use this for initialization
	void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < plane.transform.position.y - 10)
            transform.position = spawnPoint.transform.position;
	}
    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
        }
    }
    void SetCountText()
    {
        if(count>=1)
        {
            winText.text = "YOU WIN";
        }
    }
}
