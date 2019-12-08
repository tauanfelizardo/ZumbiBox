using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public Text CronometroText;
    public float tempoAtual;

    // Start is called before the first frame update
    void Start()
    {
        tempoAtual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tempoAtual += Time.deltaTime;
        CronometroText.text = tempoAtual.ToString("F2");
    }
}
