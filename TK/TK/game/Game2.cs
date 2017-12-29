using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using System.Windows.Forms;

namespace TK.game
{
    public class Game2 : GLControl
    {



        public Game2(GraphicsMode i_graphicsMode)
            : base(i_graphicsMode)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Games and Scene Setup Calls
            //
            //
            // Render initialization Calls

            GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            GL.Enable(EnableCap.DepthTest);


        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            // Render scene and game objects here
            //
            //
            //CreateSkyBox(1, 1, 1, 10, 10, 10);

            GL.Begin(BeginMode.Lines);
            GL.Vertex3(1, 0, 0);
            GL.Vertex3(10, 0, 0);

            GL.Vertex3(0, 1, 0);
            GL.Vertex3(0, 10, 0);

            GL.Vertex3(0, 0, 1);
            GL.Vertex3(0, 0, 10);

            GL.End();

            SwapBuffers();
        }

        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                Application.Exit();
            }
        }



        protected void CreateSkyBox(double x, double y, double z, double width, double height, double length)
        {
            GL.Color3(1, 1, 1);
            x = x - width / 2;
            y = y - height / 2;
            z = z - length / 2;

            //GL.BindTexture(TextureTarget.Texture2D, 
                //GL_TEXTURE_2D, textures[BACK_ID]);

            //			// Start drawing the side as a QUAD
            GL.Begin(BeginMode.Quads);
            // Assign the texture coordinates and vertices for the BACK Side
            GL.Normal3(-1, 1, 1);
            GL.TexCoord2(1.0f, 0.0f); GL.Vertex3(x + width, y, z);
            GL.Normal3(-1, -1, 1);
            GL.TexCoord2(1.0f, 1.0f); GL.Vertex3(x + width, y + height, z);
            GL.Normal3(1, -1, 1);
            GL.TexCoord2(0.0f, 1.0f); GL.Vertex3(x, y + height, z);
            GL.Normal3(1, 1, 1);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex3(x, y, z);
            GL.End();
            //
            //			// Bind the FRONT texture of the sky map to the FRONT side of the box
            //GL.glBindTexture(GL.GL_TEXTURE_2D, textures[FRONT_ID]);
            // Start drawing the side as a QUAD
            GL.Begin(BeginMode.Quads);
            // Assign the texture coordinates and vertices for the FRONT Side
            GL.Normal3(1, 1, -1);
            GL.TexCoord2(1.0f, 0.0f); GL.Vertex3(x, y, z + length);
            GL.Normal3(1, -1, -1);
            GL.TexCoord2(1.0f, 1.0f); GL.Vertex3(x, y + height, z + length);
            GL.Normal3(-1, -1, -1);
            GL.TexCoord2(0.0f, 1.0f); GL.Vertex3(x + width, y + height, z + length);
            GL.Normal3(-1, 1, -1);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex3(x + width, y, z + length);
            GL.End();

            //			// Bind the BOTTOM texture of the sky map to the BOTTOM side of the box
            //GL.glBindTexture(GL.GL_TEXTURE_2D, textures[BOTTOM_ID]);

            // Start drawing the side as a QUAD
            GL.Begin(BeginMode.Quads);

            // Assign the texture coordinates and vertices for the BOTTOM Side
            GL.Normal3(1, 1, 1);
            GL.TexCoord2(1.0f, 0.0f); GL.Vertex3(x, y, z);
            GL.Normal3(1, 1, -1);
            GL.TexCoord2(1.0f, 1.0f); GL.Vertex3(x, y, z + length);
            GL.Normal3(-1, 1, -1);
            GL.TexCoord2(0.0f, 1.0f); GL.Vertex3(x + width, y, z + length);
            GL.Normal3(-1, 1, 1);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex3(x + width, y, z);
            GL.End();
            //
            //			// Bind the TOP texture of the sky map to the TOP side of the box
            //GL.glBindTexture(GL.GL_TEXTURE_2D, textures[TOP_ID]);
            //	
            // Start drawing the side as a QUAD
            GL.Begin(BeginMode.Quads);

            // Assign the texture coordinates and vertices for the TOP Side
            GL.Normal3(-1, -1, 1);
            GL.TexCoord2(0.0f, 1.0f); GL.Vertex3(x + width, y + height, z);
            GL.Normal3(-1, -1, -1);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex3(x + width, y + height, z + length);
            GL.Normal3(1, -1, -1);
            GL.TexCoord2(1.0f, 0.0f); GL.Vertex3(x, y + height, z + length);
            GL.Normal3(1, -1, 1);
            GL.TexCoord2(1.0f, 1.0f); GL.Vertex3(x, y + height, z);

            GL.End();
            //
            //			// Bind the LEFT texture of the sky map to the LEFT side of the box
            //GL.glBindTexture(GL.GL_TEXTURE_2D, textures[LEFT_ID]);

            // Start drawing the side as a QUAD
            GL.Begin(BeginMode.Quads);

            // Assign the texture coordinates and vertices for the LEFT Side
            GL.Normal3(1, -1, 1);
            GL.TexCoord2(1.0f, 1.0f); GL.Vertex3(x, y + height, z);
            GL.Normal3(1, -1, -1);
            GL.TexCoord2(0.0f, 1.0f); GL.Vertex3(x, y + height, z + length);
            GL.Normal3(1, 1, -1);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex3(x, y, z + length);
            GL.Normal3(1, 1, 1);
            GL.TexCoord2(1.0f, 0.0f); GL.Vertex3(x, y, z);
            GL.End();
            //
            //			// Bind the RIGHT texture of the sky map to the RIGHT side of the box
            //GL.glBindTexture(GL.GL_TEXTURE_2D, textures[RIGHT_ID]);

            // Start drawing the side as a QUAD
            GL.Begin(BeginMode.Quads);

            // Assign the texture coordinates and vertices for the RIGHT Side
            GL.Normal3(-1, 1, 1);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex3(x + width, y, z);
            GL.Normal3(-1, 1, -1);
            GL.TexCoord2(1.0f, 0.0f); GL.Vertex3(x + width, y, z + length);
            GL.Normal3(-1, -1, -1);
            GL.TexCoord2(1.0f, 1.0f); GL.Vertex3(x + width, y + height, z + length);
            GL.Normal3(-1, -1, 1);
            GL.TexCoord2(0.0f, 1.0f); GL.Vertex3(x + width, y + height, z);
            GL.End();
            //GL.glBindTexture(GL.GL_TEXTURE_2D, 0);
            //			GL.glDisable(GL.GL_TEXTURE_2D);
        }
    }
}
