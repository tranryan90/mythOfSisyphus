using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace APEngProj
{
    public class Button
    {
        public Texture2D texture;
        public Vector2 position;
        public Rectangle rectangle;
        private ButtonState oldState;
        private ButtonState newState;

        Color color = new Color(255, 255, 255, 255);
        public Vector2 size;

        public Button(Texture2D newTexture ,GraphicsDevice graphicsMger, EventHandler onClick = null)
        {
            texture = newTexture;
            size = new Vector2(graphicsMger.Viewport.Width / 8, graphicsMger.Viewport.Height/30);
            ButtonClicked = onClick;
            oldState = ButtonState.Released;
            newState = ButtonState.Released;
        }

        bool down;
        public void Update()
        {
            rectangle = new Rectangle((int)position.X,(int)position.Y,)

        }
        public event EventHandler ButtonClicked;
        public void OnButtonClicked()
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
