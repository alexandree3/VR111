using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject CUBE;
   public void Button_click()
    {
        CUBE.SetActive(!CUBE.activeSelf);
    }
}
