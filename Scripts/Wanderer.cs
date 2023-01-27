﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : Kinematic
{
    Wander myMoveType;
    //LookWhereGoing myRotateType;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Wander();
        myMoveType.character = this;
        //myRotateType = new LookWhereGoing();
        //myRotateType.character = this;
        //myRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        //steeringUpdate.angular = myRotateType.getSteering().angular;
        steeringUpdate.angular = myMoveType.getSteering().angular;
        base.Update();
    }

}
