﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFase1 : MonoBehaviour
{
    public GameObject[] inimigos = new GameObject[7];

    InimigoComum inimigoComum;

    public Transform posicaoDoJogador;

    // Start is called before the first frame update
    void Start()
    {
        posicaoDoJogador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        OrganizacaoInimigos();
    }

    void OrganizacaoInimigos()
    {
        if(posicaoDoJogador.transform.position.x>= 1.5f)
        {
            for(int i = 3; i < inimigos.Length-1; i++)
            {
                inimigos[i].SetActive(true);
            }

            inimigos[0].GetComponent<InimigoComum>().SeguirJogador();
        }        
    }
}
