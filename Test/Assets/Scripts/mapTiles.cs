using UnityEngine;
using System.Collections;


    public class mapTiles
    {
        private bool clear;
        private float height;
        private int advBonus;
        private string terType;
        private bool isPassable;
        private bool tilePresent;
     
        //ConstructorSafeAttribute Blank
        public mapTiles()
        {
            clear = true;
            height = 0;
            advBonus = 0;
            terType = "Plains";
            isPassable = true;
            tilePresent = false;
         
         
        }
     
        public void newHeight(float newHeight)
        {
            height = newHeight;
        }
     
        public void changeClear(bool isClearIn)
        {
            clear = isClearIn;
            isPassable = isClearIn;
        }

        public void newAdv(int newAdvBonus) {
            advBonus = newAdvBonus;
        }

        public void changeType(string newType)
        {
            terType = newType;
        }

        public string getTerType() {
            return terType; 
        } 

        public float heightPlease(){
            return height;
        }
     
        public bool clearPlease(){
            return clear;
        }

        public int advGet(){
            return advBonus; 
        }

        public void changePassable(bool isPass)
        {
            isPassable = isPass;
 
        }
 
        public bool passPlease(){
            return isPassable;
        }
 
        public void tileHereChange(bool tile){
            tilePresent = tile;
        }
 
        public bool tilePlease()
        {
            return tilePresent;
        }
 
    }