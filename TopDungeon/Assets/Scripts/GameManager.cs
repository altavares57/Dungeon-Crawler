using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        /*To RESET or NOT SAVE between playthroughs, this line of code will be required in this location: Player Prefs. DeleteAll();
        * *NOTE* I am unsure of the specifics/nuance regarding this line of code at this time. If you are future me, reffering the this note, beware!
        */

        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    //Resources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    //References
    public Player player;
    //public weapon, weapon...

    //Logic
    public int pesos;
    public int experience;

    //
    /*Save State
     * INT preferedSkin
     * INT pesos
     * INT experience
     * INT weaponLevel
     */
    public void SaveState()
    {
        string s = "";

        s += "0" + "|";
        s += pesos.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0";

        PlayerPrefs.SetString("SaveState", s);
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {
        if (!PlayerPrefs.HasKey("SaveState"))
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');


        //Change player skin
        pesos = int.Parse(data[1]);
        experience = int.Parse(data[2]);
        //Change Weapon level


        Debug.Log("LoadState");
    }

}
