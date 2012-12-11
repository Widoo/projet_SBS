﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace Sunday_Bloody_Sunday
{
    class Map
    {
        // FIELDS
        Rectangle MapTexture;
        public Player joueur;
        string action_a_traite = "";
        PhysicsEngine map_physique;


        // CONSTRUCTOR
        public Map(Player j1, PhysicsEngine map_physique)
        {
            MapTexture = new Rectangle(0, 0, 800, 480);
            joueur = j1;
            this.map_physique = map_physique;
        }


        // METHODS
        // Get the width of the map
        public int Width
        {
            get { return MapTexture.Width; }
        }

        // Get the height of the map
        public int Height
        {
            get { return MapTexture.Height; }
        }


        // UPDATE & DRAW
        public void Update(MouseState mouse, KeyboardState keyboard)
        {
            //Update l'objet joueurs contenue par la map
            this.joueur.Update( mouse, keyboard);

            //Devrait vérifier si l'action du joueur est faisable, et si oui l'autorise, pour l'instant, ne permet que le déplacement.
            if (joueur.actionjoueur == "up" || joueur.actionjoueur == "down" || joueur.actionjoueur == "left" || joueur.actionjoueur == "right")
            {
                if ((!(map_physique.mur(this.joueur.futur_position_X(), this.joueur.futur_position_Y()))) && (!(map_physique.mur(this.joueur.futur_position_X() + this.joueur.Width, this.joueur.futur_position_Y() + this.joueur.Height)))) // Teste de collision
                {
                    this.joueur.mise_a_jour(joueur.actionjoueur); //Met le joueur à jour si le déplacement peut avoir lieu
                }
            }
            this.joueur.actionjoueur = "";// "Remet à zéros" les actions du joueurs
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Ressources.Map, this.MapTexture, Color.CadetBlue);
        }
    }
}
