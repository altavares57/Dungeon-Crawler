using UnityEngine;


public class Portal : Collidable
{
    // ~I believe this is the beggining sequence to RNG -- HOW Exciting!
    public string[] sceneNames;
    protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            //Teleport the player ~Also RNG related code; Take Notes!
            GameManager.instance.SaveState();
            string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}


// **NOTE** Loading a random scene WITHOUT using the manual (single-scene) code method above -- Ensure using UnityEngine.SceneManagement is written above i.e SceneManager.LoadScene(sceneName);