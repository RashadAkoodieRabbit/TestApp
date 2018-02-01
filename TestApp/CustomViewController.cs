using System;
using UIKit;
using CoreGraphics;

namespace TestApp
{
    public class CustomViewController : UIViewController
    {
        UITextField usernameField, passwordField;

        public CustomViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();//base is like super i.e. we are calling a method from UIViewController if we use base.
            View.BackgroundColor = UIColor.Yellow;
            Title = "My very own view controller";

            //THIS IS THE BUTTON WE CREATED FOR THE TEST SCREEN
            //var btn = UIButton.FromType(UIButtonType.System);
            //btn.Frame = new CGRect(20, 200, 280, 44);
            //btn.BackgroundColor = UIColor.Black;
            //btn.SetTitle("Click me",UIControlState.Normal);

            var user = new UIViewController();
            user.View.BackgroundColor = UIColor.Green;

            //THIS WAS THE EVENT HANDLER FOR THE TEST BUTTON 
            //btn.TouchUpInside += (sender, e) => {
            //    this.NavigationController.PushViewController(user,true);
            //};

            //THIS WAS TO ADD THE TEST BUTTON TO THE VIEW
            //View.AddSubview(btn);

            nfloat height = 31.0f;
            nfloat width = View.Bounds.Width;

            usernameField = new UITextField
            {
                Placeholder = "This is where you will enter your username",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CGRect(10, 182, width - 20, height)
            };

            passwordField = new UITextField()
            {
                Placeholder = "Enter Password Here",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CGRect(10, 170, width - 20, height),//(x pos, y pos, width, height)
                SecureTextEntry = true
            };

            //View.AddSubviews(usernameField,passwordField);
            //OR YOU CAN DO THIS... FIRST ADDED WILL BE IN THE BACK OF THE STACK
            //View.AddSubview(usernameField);
            //View.AddSubview(passwordField);

            View.AddSubviews(usernameField, passwordField);
        }
    }
}
