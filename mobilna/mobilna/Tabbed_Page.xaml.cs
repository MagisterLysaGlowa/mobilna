﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobilna
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabbed_Page : TabbedPage
    {
        public Tabbed_Page()
        {
            InitializeComponent();
        }
    }
}