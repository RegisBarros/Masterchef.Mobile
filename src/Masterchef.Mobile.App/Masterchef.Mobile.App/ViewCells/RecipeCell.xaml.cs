﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Masterchef.Mobile.App.ViewCells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeCell : ViewCell
	{
		public RecipeCell ()
		{
			InitializeComponent ();
		}
	}
}