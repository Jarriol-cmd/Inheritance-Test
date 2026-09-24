using TMPro;
using UnityEngine;

public class DragonScript : EnemyBase
{

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void AttackPlayer()
    {
        textToChange.text = "Dragon is attacking player";
    }
}
