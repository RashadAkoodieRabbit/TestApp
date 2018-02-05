using System;
using UIKit;
using CoreGraphics;

namespace TestApp
{
    public class CircleView : UIView
    {
        public CircleView()
        {
        }

        public override void Draw(CGRect rect){
            base.Draw(rect);

            //GET GRAPHICS CONTEXT
            using(var g = UIGraphics.GetCurrentContext()){

                //set up drawing attributes
                g.SetLineWidth(10.0f);
                UIColor.Green.SetFill();
                UIColor.Blue.SetStroke();

                //create geometry
                var path = new CGPath();
                path.AddArc(Bounds.GetMidX(),Bounds.GetMidY(),50f,0,2.0f*(float)Math.PI,true);//(nfloat x, nfloat y, nfloat radius, nfloat start angle, nfloat end angle, bool clockwise)

                //add geometry to graphics context and draw
                g.AddPath(path);
            }
        }
    }
}
