using TMPro;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public TextMeshProUGUI textToChange = new TextMeshProUGUI();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public virtual void AttackPlayer()
    {
        textToChange.text = "Enemy is attacking player";
    }

    void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.thistle;
        AttackPlayer();
    }

    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
