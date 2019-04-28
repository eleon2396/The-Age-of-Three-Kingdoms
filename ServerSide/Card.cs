using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows;


namespace CardsPackage
{
    class Card
    {
        //Creating variables to work with
        private string Name;
        private string Description;
        private int Attack;
        private int Defense;
        private int Tier;
        private string CardType;
        //private Image newImage;


        //Empty Constructor
        protected Card()
        {
            Name = "None";
            Attack = 0;
            Defense = 0;
            Description = "None";
            Tier = 0;
        }

        //Fully Qualified Constructor
        public Card(string name, string desc, int atk, int def, int tier, string imagePath)
        {
            this.Name = name;
            this.Description = desc;
            this.Attack = atk;
            this.Defense = def;
            this.Tier = tier;
            this.CardType = "Unknown";
            //this.newImage = Image.FromFile(imagePath);
        }


        //                 ************Setter Methods*************
        //*****************************************************************************
        //Set Name of Card
        protected void SetName(string nameOfCard)
        {
            this.Name = nameOfCard;
        }

        //Set Description
        protected void SetDescription(string description)
        {
            this.Description = description;
        }

        //Set Attack
        protected void SetAttack(int attk)
        {
            this.Attack = attk;
        }

        //Set Defense
        protected void SetDefense(int def)
        {
            this.Defense = def;
        }

        //Set Tier
        protected void SetTier(int tier)
        {
            this.Tier = tier;
        }

        //Set Type
        public void SetType(string type)
        {
            this.CardType = type;
        }

        //Set Image path
        //protected void SetImage(string imagePath)
        //{
        //    this.newImage = Image.FromFile(imagePath);
        //}


        //                 ************Getter Methods*************
        //*****************************************************************************
        //Get Name of Card
        public string GetName()
        {
            return this.Name;
        }

        //Get Description
        public string GetDescription()
        {
            return this.Description;
        }

        //Get Attack
        public int GetAttack()
        {
            return this.Attack;
        }

        //Get Defense
        public int GetDefense()
        {
            return this.Defense;
        }

        //Get Tier
        public int GetTier()
        {
            return this.Tier;
        }

        //Get type
        public string GetType()
        {
            return this.CardType;
        }

        //public Image getImage()
        //{
        //    return this.newImage;
        //}
    }
}
