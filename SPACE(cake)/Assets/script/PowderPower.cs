using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowderPower : MonoBehaviour
{
    public GameObject PowderBomb;

    void Start()
    {
        StartCoroutine(flourBomb());
    }

    IEnumerator flourBomb()
    {
        while (true)
        {
            float randomTime = Random.Range(2f, 5f);
            float randomPosition = Random.Range(10, 30);

            yield return new WaitForSeconds(randomTime);
            Instantiate(PowderBomb, new Vector2(randomPosition, 7), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

}

