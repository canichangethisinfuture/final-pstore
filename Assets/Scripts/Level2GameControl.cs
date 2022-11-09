using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2GameControl : MonoBehaviour
{
    [SerializeField]GameObject panelMenu;
    public void Congrats()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        
        if(enemys.Length == 0){
            panelMenu.SetActive(true);
        }
    }
    // Start is called before the first frame update
    

}
