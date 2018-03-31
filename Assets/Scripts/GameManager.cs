using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour {

    public GameObject UpPrefab;
    public GameObject DownPrefab;
    public GameObject RightPrefab;
    public GameObject LeftPrefab;
    public GameObject PlayerPrefab;
    public GameObject ToiletPrefab;

    public string levelFile = "pooplevel.txt";

    public float tileHeight = 2f;
    public float tileWidth = 2f;

	// Use this for initialization
	void Start () {
		
        string levelString = File.ReadAllText(Application.dataPath + Path.DirectorySeparatorChar + levelFile);

       
        string[] levelLines = levelString.Split('\n');
        int width = 0;
        
        for (int row = 0; row < levelLines.Length; row++)
        {
            string currentLine = levelLines[row];
            width = currentLine.Length;
            
            for (int col = 0; col < currentLine.Length; col++)
            {
                char currentChar = currentLine[col];
                if (currentChar == 'u')
                {
                  
                    GameObject wallObj = Instantiate(UpPrefab);
                    wallObj.transform.parent = transform;
                    wallObj.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
                else if (currentChar == 'd')
                {
               
                    GameObject playerObj = Instantiate(DownPrefab);
                    playerObj.transform.parent = transform;
                    playerObj.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
                else if (currentChar == 'r')
                {
                   
                        GameObject enemyObj = Instantiate(RightPrefab);
                        enemyObj.transform.parent = transform;
                        enemyObj.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                    }
                else if (currentChar == 'l')
                {

                    GameObject enemyObj = Instantiate(LeftPrefab);
                    enemyObj.transform.parent = transform;
                    enemyObj.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
                else if (currentChar == 'p')
                {

                    GameObject enemyObj = Instantiate(PlayerPrefab);
                    enemyObj.transform.parent = transform;
                    enemyObj.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
                else if (currentChar == 't')
                {

                    GameObject enemyObj = Instantiate(ToiletPrefab);
                    enemyObj.transform.parent = transform;
                    enemyObj.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
            }
           }
        }
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
