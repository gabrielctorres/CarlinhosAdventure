﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aranha : InimigoComum
{

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();            
        dano = 2f;
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();        
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();        
    }       
}