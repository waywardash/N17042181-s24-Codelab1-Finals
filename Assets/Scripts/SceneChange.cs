using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadSceneAsync(1);

        }
    }

    public void PlayGame()
    {
        
        StartCoroutine( LoadDelay());
        SceneManager.LoadSceneAsync(1);
    }

    private IEnumerator LoadDelay() 
    {
        yield return new WaitForSeconds(3);
    }
}
