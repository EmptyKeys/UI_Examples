//-----------------------------------------------------------------------------
// Synapse Gaming - SunBurn Starter Kit
// Copyright © Synapse Gaming 2012
//-----------------------------------------------------------------------------

#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SynapseGaming.SunBurn.Framework.Content;
using SynapseGaming.SunBurn.Framework.Core;
using SynapseGaming.SunBurn.Framework.Graphics;
using SynapseGaming.SunBurn.Framework.Input;
using SynapseGaming.SunBurn.Framework.Models;
using SynapseGaming.SunBurn.Framework.Primitives;
using SynapseGaming.SunBurn.Engine.Core;
using SynapseGaming.SunBurn.Engine.Rendering;
#endregion


namespace GameLibrary.Input
{
    public class CompositeInputSource : BaseInputSource
    {
        private List<BaseInputSource> _Sources = new List<BaseInputSource>();

        public CompositeInputSource(BaseInputSource[] sources)
        {
            if (sources != null)
                _Sources.AddRange(sources);
        }

        protected override void CalculateMovement()
        {
            foreach (BaseInputSource source in _Sources)
            {
                source.Update();

                _MoveAmount += source.MoveAmount;
                _TurnAmount += source.TurnAmount;
                _LookUpDownAmount += source.LookUpDownAmount;

                _Crouch |= source.Crouch;
                _Jump |= source.Jump;
            }
        }
    }
}
