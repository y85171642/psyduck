﻿using LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psyduck.api
{
    public class StateResult : Result
    {
        public bool isDone => state == "done";
        public bool isFail => state == "fail";

        public string state;
        public object result;

        public override void Parse(JsonData jsonData)
        {
            base.Parse(jsonData);
            state = jsonData.GetString("state");
        }
    }
}
