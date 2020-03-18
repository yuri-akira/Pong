using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{   
    public int pontosJ1;
    public int pontosJ2;
    public Text txtPontuacao;
    public AudioSource somGol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Saiu do jogo");
        }
    }

    public void pontuacaoJ1()
    {
        pontosJ1++;
        attTxtPontuacao();
    }
    public void pontuacaoJ2()
    {
        pontosJ2++;
        attTxtPontuacao();
    }

    public void attTxtPontuacao()
    {
        txtPontuacao.text = pontosJ1 + " - "+ pontosJ2;
        somGol.Play();
    }

}
