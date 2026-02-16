using UnityEngine;

public class MouvementCercles : MonoBehaviour
{

    public bool peutBouger;
    public float vitesse;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float positionXAleatoire = Random.Range(-5f, 5f);

        transform.position = new Vector2(positionXAleatoire, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        float nouvellePositionX = transform.position.x;
        float nouvellePositionY = transform.position.y - vitesse;

        transform.position = new Vector2 (nouvellePositionX, nouvellePositionY);
        if(transform.position.y <= -6f)
        {
            float positionXAleatoire = Random.Range(-8f, 8f);
            transform.position = new Vector2 (positionXAleatoire, 7f);
        }
        // else if(transform.position.y >= 9f)
        // {
        //     float positionXAleatoire = Random.Range(-5f, 5f);
        //     transform.position = new Vector2 (positionXAleatoire, -7f);
        // }
    }
}
