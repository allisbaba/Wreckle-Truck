using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BttnManager : MonoBehaviour
{
   public void PlayBttn()
   {
       SceneManager.LoadScene("Scenes/SampleScene");
   }

  
}
