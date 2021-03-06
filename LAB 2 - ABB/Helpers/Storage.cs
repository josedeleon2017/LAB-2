﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LAB_2___ABB.Models;

namespace LAB_2___ABB.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }
        public NoLinealStructures.Structures.Tree<DrugModel> drugTree = new NoLinealStructures.Structures.Tree<DrugModel>();
        public List<DrugOrderModel> drugList = new List<DrugOrderModel>();
        public List<DrugOrderModel> drugOrderList = new List<DrugOrderModel>();
        public List<DrugOrderModel> drugCartList = new List<DrugOrderModel>();


    }
}