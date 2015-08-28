using System;

namespace Urho
{
    public class CCEaseExponentialIn : CCActionEase
    {
        #region Constructors

        public CCEaseExponentialIn (CCFiniteTimeAction action) : base (action)
        {
        }

        #endregion Constructors


        protected internal override CCActionState StartAction(Node target)
        {
            return new CCEaseExponentialInState (this, target);
        }

        public override CCFiniteTimeAction Reverse ()
        {
            return new CCEaseExponentialOut ((CCFiniteTimeAction)InnerAction.Reverse ());
        }
    }


    #region Action state

    public class CCEaseExponentialInState : CCActionEaseState
    {
        public CCEaseExponentialInState (CCEaseExponentialIn action, Node target) : base (action, target)
        {
        }

        public override void Update (float time)
        {
            InnerActionState.Update (CCEaseMath.ExponentialIn (time));
        }
    }

    #endregion Action state
}