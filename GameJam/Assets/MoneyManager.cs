using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{

    public Text moneyText;
    public double salary;
    public Button workBtn;
    public Image timebar;
    public float workTime;

    private bool working;
    private bool isGameStarted;

    protected double moneyOwned;

    // Use this for initialization
    void Start()
    {
        working = false;
        moneyOwned = 0;
        workBtn.onClick.AddListener(ActivatingWork);
        StartCoroutine(WaitAndEarn(workTime));
    }

    // Update is called once per frame
    void Update()
    {
        isGameStarted = gameObject.GetComponent<StartGame>().gameStarted;
        DisplayMoney();
    }

    void DisplayMoney()
    {
        if (isGameStarted == true)
        {
            moneyText.text = "$" + moneyOwned;
        }
    }

    void ActivatingWork()
    {
        working = !working;
    }

    private IEnumerator WaitAndEarn(float wait) {
        while (true) {
            if (working) {
                moneyOwned += salary;
            }
            yield return new WaitForSeconds(wait);
        }
    }
}
