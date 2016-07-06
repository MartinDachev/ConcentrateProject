using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BouncingBallGame
{
    public class GameObject
    {
        public Texture2D Texture;
        public Vector2 Position;
        public bool IsActive = true;

        public GameObject(Texture2D Texture, Vector2 Position)
        {
            this.Texture = Texture;
            this.Position = Position;
        }
    }
}
