using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenTK.Graphics;

namespace TK.camera
{
    public class CameraUtil
    {

        /// <summary>
        /// 원근법 설정
        /// </summary>
        /// <param name="fovy">시야각</param>
        /// <param name="aspect">near View의 w/h (aspect = width / height)</param>
        /// <param name="near">near View 거리</param>
        /// <param name="far">far View 거리</param>
        public static void SetPerspectiveMode(double fov, double aspect, double near, double far)
        {
            double y = Math.Tan(Util.ToRadians(fov) / 2.0) * near;
            double x = y * aspect;

            //Set perspective mode
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Frustum(-x, x, -y, y, near, far);
        }

        /// <summary>
        /// 직교투영 설정
        /// </summary>
        /// <param name="scale">Scale</param>
        /// <param name="aspect">near View의 w/h (aspect = width / height)</param>
        /// <param name="near">near View 거리</param>
        /// <param name="far">far View 거리</param>
        public static void SetOrthogonalMode(double scale, double aspect, double near, double far)
        {
            double y = scale * near / 2.0d;
            double x = y * aspect;

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-x, x, -y, y, near, far);
        }
    }
}
