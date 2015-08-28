﻿namespace Urho
{
    public class CCFadeOut : CCFiniteTimeAction
    {
        #region Constructors

        public CCFadeOut (float durtaion) : base (durtaion)
        {
        }

        #endregion Constructors

        protected internal override CCActionState StartAction(Node target)
        {
            return new CCFadeOutState (this, target);

        }

        public override CCFiniteTimeAction Reverse ()
        {
            return new CCFadeIn (Duration);
        }
    }

    public class CCFadeOutState : CCFiniteTimeActionState
    {

        public CCFadeOutState (CCFadeOut action, Node target)
            : base (action, target)
        {
        }

        public override void Update (float time)
        {
            var pRGBAProtocol = Target;
            if (pRGBAProtocol != null)
            {
                pRGBAProtocol.Opacity = (byte)(255 * (1 - time));
            }
        }

    }

}