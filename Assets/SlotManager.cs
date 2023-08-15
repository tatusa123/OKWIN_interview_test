using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{
    [SerializeField] List<string> slotList;
    public List<string> list1, list2, list3;
    [SerializeField] int money;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text moneyText;
    void Start()
    {
        list1 = new List<string>(3);
        list2 = new List<string>(3);
        list3 = new List<string>(3);
    }

    void Update()
    {
        
    }
    public void randomButton()
    {
        list1.Clear();
        list2.Clear();
        list3.Clear();
        money = 0;

        for (int i = 3; i < slotList.Count; i++)
        {
            list1.Add(slotList[Random.Range(0, slotList.Count)]);
            list2.Add(slotList[Random.Range(0, slotList.Count)]);
            list3.Add(slotList[Random.Range(0, slotList.Count)]);
        }
        string result1 = "";
        string result2 = "";
        string result3 = "";
        foreach (string x in list1)
        {
            result1 += x.ToString() + ", ";
        }
        foreach (string x in list2)
        {
            result2 += x.ToString() + ", ";
        }
        foreach (string x in list3)
        {
            result3 += x.ToString() + ", ";
        }
        Debug.Log(result1 + " " + result2 + " " + result3);
        CheckReward();
        Debug.Log("Money This Round: " + money);

        setText();
    }
    public bool AllEmentEqual(string value, List<string> list)
    {
        foreach (string element in list)
        {
            if (element != value)
            {
                return false;
            }
        }
        return true;
    }
    public bool TwoElementEqual(string value, List<string> list)
    {
        if (list[0] == value && list[1] == value)
        {
            return true;
        }
        if (list[1] == value && list[2] == value)
        {
            return true;
        }
        if (list[0] == value && list[2] == value)
        {
            return true;
        }
        return false;
    }
    public bool OneCherry(List<string> list)
    {
        if (list[0] == "cherry" || list[1] == "cherry" || list[2] == "cherry")
        {
            if (list[0] == "cherry" && list[1] == "cherry")
            {
                return false;
            }
            if (list[0] == "cherry" && list[2] == "cherry")
            {
                return false;
            }
            if (list[1] == "cherry" && list[2] == "cherry")
            {
                return false;
            }
            if (list[0] == "cherry" && list[1] == "cherry" && list[2] == "cherry")
            {
                return false;
            }
            return true;
        }
        return false;
    }
    public void CheckReward()
    {
        if (AllEmentEqual("globe" , list1))
        {
            money += 500;
        }
        if (AllEmentEqual("globe", list2))
        {
            money += 500;
        }
        if (AllEmentEqual("globe", list3))
        {
            money += 500;
        }
        if (AllEmentEqual("bar" , list1))
        {
            money += 100;
        }
        if (AllEmentEqual("bar", list2))
        {
            money += 100;
        }
        if (AllEmentEqual("bar", list3))
        {
            money += 100;
        }
        if (AllEmentEqual("plum", list1))
        {
            money += 50;
        }
        if (AllEmentEqual("plum", list2))
        {
            money += 50;
        }
        if (AllEmentEqual("plum", list3))
        {
            money += 50;
        }
        if (AllEmentEqual("bell" , list1))
        {
            money += 20;
        }
        if (AllEmentEqual("bell", list2))
        {
            money += 20;
        }
        if (AllEmentEqual("bell", list3))
        {
            money += 20;
        }
        if (AllEmentEqual("orange", list1))
        {
            money += 15;
        }
        if (AllEmentEqual("orange", list2))
        {
            money += 15;
        }
        if (AllEmentEqual("orange", list3))
        {
            money += 15;
        }
        if (AllEmentEqual("cherry" , list1))
        {
            money += 10;
        }
        if (AllEmentEqual("cherry", list2))
        {
            money += 10;
        }
        if (AllEmentEqual("cherry", list3))
        {
            money += 10;
        }
        if (TwoElementEqual("cherry", list1))
        {
            money += 5;
        }
        if (TwoElementEqual("cherry", list2))
        {
            money += 5;
        }
        if (TwoElementEqual("cherry", list3))
        {
            money += 5;
        }
        if (OneCherry(list1))
        {
            money += 2;
        }
        if (OneCherry(list2))
        {
            money += 2;
        }
        if (OneCherry(list3))
        { 
            money += 2;
        }
    }
    public void setText()
    {
        text1.text = list1[0];
        text2.text = list1[1];
        text3.text = list1[2];
        text4.text = list2[0];
        text5.text = list2[1];
        text6.text = list2[2];
        text7.text = list3[0];
        text8.text = list3[1];
        text9.text = list3[2];

        moneyText.text = "Congratulations, You got " + money.ToString() + " this round";
    }
}
