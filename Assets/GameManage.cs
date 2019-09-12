using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    private int enemynum = 3;
    [SerializeField]
    private GameObject Creater;
    // Start is called before the first frame update
    void Start()
    {
        Creater = GameObject.Find("EnemyCreater");
        Creater.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.T))
        {
            SceneManager.LoadScene("TitleScene");
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.G))
        {
            SceneManager.LoadScene("Simple Sample");
        }
        if(enemynum <= 0)
        {
            if(Creater.active == false)
            {
                GameStart();
            }
        }
    }

    private void GameStart()
    {
        Creater.active = true;
        GameObject combo = GameObject.Find("ComboCheck");
        combo.GetComponent<Combo>().ResetComboCount();
    }

    public void StartEnemyHit()
    {
        enemynum--;
    }
}
