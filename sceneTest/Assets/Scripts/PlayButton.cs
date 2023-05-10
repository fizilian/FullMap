using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
   public void playGame()
   {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   public void retry()
   {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
   }
}
