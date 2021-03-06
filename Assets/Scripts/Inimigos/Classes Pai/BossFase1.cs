﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BossFase1 : MonoBehaviour
{

    public List<GameObject> inimigos = new List<GameObject>();

    InimigoComum inimigoComum;

    public Transform posicaoDoJogador;

    public float hpBoss = 7;

    public GameObject lifeCanvas;
    public Image lifeImage;   
    // Start is called before the first frame update
    void Start()
    {
        posicaoDoJogador = GameObject.Find("Personagem").transform;
    }

    // Update is called once per frame
    private void Update()
    {
        lifeImage.fillAmount = hpBoss / 7;
        OrganizacaoInimigos();
    }

    void OrganizacaoInimigos()
    {
        if(posicaoDoJogador.transform.position.x >= 102f)
        {
            lifeCanvas.SetActive(true);
            for(int i = 3; i < inimigos.Count; i++)
            {
                inimigos[i].SetActive(true);
            }

            for (int i = 0; i < inimigos.Count; i++)
            {
                if(inimigos[i]!= null)
                {
                    inimigos[i].GetComponent<InimigoComum>().podeSeguir = true;
                    inimigos[i].GetComponent<BoxCollider2D>().enabled = true;
                    inimigos[i].GetComponent<SpriteRenderer>().color = Color.white;
                    inimigos[i].GetComponent<SpriteRenderer>().sortingOrder = 0;
                    inimigos[i].GetComponent<Rigidbody2D>().gravityScale = 1;
                    break;
                }                    
                else if (i < 7)
                {
                    inimigos[i++].GetComponent<InimigoComum>().podeSeguir = true;
                    inimigos[i].GetComponent<BoxCollider2D>().enabled = true;
                    inimigos[i].GetComponent<SpriteRenderer>().color = Color.white;
                    inimigos[i].GetComponent<SpriteRenderer>().sortingOrder = 0;
                    inimigos[i].GetComponent<Rigidbody2D>().gravityScale = 1;
                    break;
                }
                    
            }
            
        }        
    }
}
