using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Hexagons
{
    class Hexagon
    {
        //ATTRIBUTS
        float radius, panelWidth, panelHeight;
        //var pointX, pointY;

        //Construteur
        public Hexagon(float _panelWidth, float _panelHeight, float _radius)
        {
            this.panelWidth = _panelWidth;
            this.panelHeight = _panelHeight;
            this.radius = _radius;
        }

        //methodes
        public PointF[] sixPointsOfHex()
        {
            //milieu du panel
            var pointX = this.panelWidth / 2;
            var pointY = this.panelHeight / 2;

            var shape = new PointF[6];

            //pour la taille
            var r = this.radius;

            //crée 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    pointX + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    pointY + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            return shape;
        }

}
}
