using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Math;
using TK.camera;
using OpenTK.Input;

namespace TK.game
{
    public class Game : GameWindow
    {
        int width;
        int height;

        public Game(int i_width, int i_height)
            : base(i_width, i_height, GraphicsMode.Default, "GameWindow")
        {
            width = i_width;
            height = i_height;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Games and Scene Setup Calls
            //
            //
            // Render initialization Calls
            
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
         
            GL.Viewport(0, 0, width, height);
            CameraUtil.SetPerspectiveMode(45.0d, width / (double)height, 1.0d, 64.0d);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            if (Keyboard[Key.Escape])
            {
                Exit();
            }

            // Process input and AI
            // Process received packets
            // Physics and Collision
            // Updata game entities
            // Send outgoing network packets
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // Render scene and game objects here
            //
            //

            SwapBuffers();
        }


    }
}
