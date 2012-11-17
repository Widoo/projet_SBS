﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sunday_Bloody_Sunday
{
    class GameMain
    {
        // FIELDS
        Player LocalPlayer;

        // CONCSTRUCTOR
        public GameMain()
        {
            this.LocalPlayer = new Player();
        }

        // METHODS


        // UPDATE & DRAW
        public void Update(MouseState mouse, KeyboardState keyboard)
        {
            LocalPlayer.Update(mouse, keyboard);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            LocalPlayer.Draw(spriteBatch);
        }
    }
}
