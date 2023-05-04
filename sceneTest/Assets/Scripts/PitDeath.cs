using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitDeath : MonoBehaviour
{
    public float health = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider Col)
	{
		if(Col.gameObject.tag == "Death")
		{
			Debug.Log("died lol");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
        if(Col.gameObject.tag == "Enemy")
        {
            health = health - 1;
        }
	}
    // Update is called once per frame
    void Update()
    {
        if(health == 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
