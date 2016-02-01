using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{
	public GameObject blackWall;
    
    IEnumerator Start()
    {
        var sceneNames = new string[] {
			 "Stage", "Characters", "UI"
		};

        foreach (var sceneName in sceneNames)
        {
            var scene = SceneManager.GetSceneByName(sceneName);
            if (scene.isLoaded == false)
            {
                Debug.Log(sceneName);
                SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
            }
        }

        yield return null;

		//GameObject.Find ("blackWall");
        
        StartCoroutine(Flow());
    }

    IEnumerator Flow()
    {
        var stage = FindObjectOfType<StageManeTest>();
        var player = GameObject.Find("MyCube");
        var Pattern = FindObjectOfType<PatternButtonCtrl>();    //

        player.SetActive(false);

        // play patterm 1
        Debug.Log("Play patterm1");
        stage.SetPathType(StageManeTest.PathType.Path01);
        Pattern.SetAfterSprite(1);                              //
        yield return new WaitForSeconds(4.5f);
        Pattern.SetBeforeSprite(1);                             //

        // play patterm 2
        Debug.Log("Play patterm2");
        stage.SetPathType(StageManeTest.PathType.Path02);
        Pattern.SetAfterSprite(2);                              //
        yield return new WaitForSeconds(6);
        Pattern.SetBeforeSprite(2);                             //

        //play patterm3
        Debug.Log("Play patterm3");
        stage.SetPathType(StageManeTest.PathType.Path03);
        Pattern.SetAfterSprite(3);                              //
        yield return new WaitForSeconds(6);
        Pattern.SetBeforeSprite(3);                             //

        Debug.Log("Play random");
        // random time
        stage.SetRandomMove();

		//yield return new WaitForSeconds(1);
        // Entry Player
		//blackWall.SetActive (true);
        player.SetActive(true);
		yield return new WaitForSeconds (3);
		//blackWall.SetActive (false);

        // play p1 & p2 ( entry UI )

        // Entry clallce

        // game clear or over.

    }
}
