using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStats : MonoBehaviour
{

    
    public string charName;
    public int playerLevel = 1;
    public int currentExp;
    public int[] expToNextLevel;
    public int maxLevel = 10;
    public int baseEXP = 1000;

    [Header("Player Values")]
    public int currentHP;
    public int maxHP = 100;
    public int currentAP;
    public int maxMP = 100;
    public int currentMP;
    public int[] mpLvlBonus;
    public int strength;
    public int defense;
    public int wpnPwr;
    public int armrPwr;
    public string equippedWpn;
    public string equippedArmr;

    [Header("Component Details")]
    public Sprite charImage;

    // Start is called before the first frame update
    void Start()
    {
        SetLevels();

    }

    private void SetLevels()
    {
        expToNextLevel = new int[maxLevel];
        expToNextLevel[1] = baseEXP;

        for (int i = 2; i < expToNextLevel.Length; i++)
        {
            expToNextLevel[i] = Mathf.FloorToInt(expToNextLevel[i - 1] * 1.05f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            AddEXP(500);
        }
    }

    public void AddEXP(int expToAdd)
    {
        currentExp += expToAdd;

        if (playerLevel >= maxLevel)
        {
            currentExp = 0;
        }
        else
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {

       

        if (playerLevel <= maxLevel)
        {
            if (currentExp > expToNextLevel[playerLevel])
            {
                currentExp -= expToNextLevel[playerLevel];

                playerLevel++;

                //determine whether to add to str based on odd or even
                FightingLevelUp();


                maxHP = Mathf.FloorToInt(maxHP * 1.05f);
                currentHP = maxHP;


                maxMP += mpLvlBonus[playerLevel];
                currentMP = maxHP;

            }
        }
        
    }

    private void FightingLevelUp()
    {
        if (playerLevel % 2 == 0)
        {
            strength++;
        }
        else
        {
            defense++;
        }
    }
}
