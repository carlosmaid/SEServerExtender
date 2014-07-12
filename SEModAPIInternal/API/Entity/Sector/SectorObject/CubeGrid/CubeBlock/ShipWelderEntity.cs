﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Sandbox.Common.ObjectBuilders;

using SEModAPIInternal.API.Common;
using SEModAPIInternal.Support;

namespace SEModAPIInternal.API.Entity.Sector.SectorObject.CubeGrid.CubeBlock
{
	public class ShipWelderEntity : FunctionalBlockEntity
	{
		#region "Attributes"

		public static string ShipWelderNamespace = "";
		public static string ShipWelderClass = "";

		#endregion

		#region "Constructors and Intializers"

		public ShipWelderEntity(CubeGridEntity parent, MyObjectBuilder_ShipWelder definition)
			: base(parent, definition)
		{
		}

		public ShipWelderEntity(CubeGridEntity parent, MyObjectBuilder_ShipWelder definition, Object backingObject)
			: base(parent, definition, backingObject)
		{
		}

		#endregion

		#region "Properties"
		#endregion

		#region "Methods"

		/// <summary>
		/// Method to get the casted instance from parent signature
		/// </summary>
		/// <returns>The casted instance into the class type</returns>
		new internal MyObjectBuilder_ShipWelder GetSubTypeEntity()
		{
			return (MyObjectBuilder_ShipWelder)BaseEntity;
		}

		#endregion
	}
}
