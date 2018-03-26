using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject selectedCharater;

	void Start ()
    {
	    	
	}
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

            if (hit.collider)
            {
                if (hit.collider.tag == "Player")
                {
                    selectedCharater = hit.collider.gameObject;
                }
            }
            else
            {
                if (selectedCharater)
                {
                    selectedCharater.GetComponent<Character>().moveToPos = rayPos;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
            selectedCharater = GameObject.Find("Tank");
        if (Input.GetKeyDown(KeyCode.Alpha2))
            selectedCharater = GameObject.Find("Healer");
        if (Input.GetKeyDown(KeyCode.Alpha3))
            selectedCharater = GameObject.Find("DamageDealer1");
        if (Input.GetKeyDown(KeyCode.Alpha4))
            selectedCharater = GameObject.Find("DamageDealer2");

    }
}
