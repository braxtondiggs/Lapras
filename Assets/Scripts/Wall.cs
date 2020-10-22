using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo) {
		if (hitInfo.name == "ball")
		{
			string wallName = transform.name;
			GameManager.Score(wallName);
			hitInfo.gameObject.SendMessage("RestartGame", 1, SendMessageOptions.RequireReceiver);
		}
	}
}
