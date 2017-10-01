﻿/**
 * MetroSet UI - MetroSet UI Framewrok
 * 
 * The MIT License (MIT)
 * Copyright (c) 2017 Narwin, https://github.com/N-a-r-w-i-n
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation the rights to use, copy, 
 * modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
 * and to permit persons to whom the Software is furnished to do so, subject to the 
 * following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in 
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
 * CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using MetroSet_UI.Controls;
using MetroSet_UI.Design;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;

namespace MetroSet_UI.Tasks
{
    public class MetroSetEllipseActionList : DesignerActionList
    {
        private readonly MetroSetEllipse metroSetEllipse;

        public MetroSetEllipseActionList(IComponent component) : base(component)
        {
            metroSetEllipse = (MetroSetEllipse)component;
        }

        public Style Style
        {
            get { return metroSetEllipse.Style; }
            set { metroSetEllipse.Style = value; }
        }

        public string ThemeAuthor
        {
            get { return metroSetEllipse.ThemeAuthor; }
        }

        public string ThemeName
        {
            get { return metroSetEllipse.ThemeName; }
        }

        public StyleManager StyleManager
        {
            get { return metroSetEllipse.StyleManager; }
            set { metroSetEllipse.StyleManager = value; }
        }

        public string Text
        {
            get { return metroSetEllipse.Text; }
            set { metroSetEllipse.Text = value; }
        }

        public Font Font
        {
            get { return metroSetEllipse.Font; }
            set { metroSetEllipse.Font = value; }
        }

        public int BorderThickness
        {
            get { return metroSetEllipse.BorderThickness; }
            set { metroSetEllipse.BorderThickness = value; }
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection
        {
            new DesignerActionHeaderItem("MetroSet Framework"),
            new DesignerActionPropertyItem("StyleManager", "StyleManager", "MetroSet Framework", "Gets or sets the stylemanager for the control."),
            new DesignerActionPropertyItem("Style", "Style", "MetroSet Framework", "Gets or sets the style."),

            new DesignerActionHeaderItem("Informations"),
            new DesignerActionPropertyItem("ThemeName", "ThemeName", "Informations", "Gets or sets the The Theme name associated with the theme."),
            new DesignerActionPropertyItem("ThemeAuthor", "ThemeAuthor", "Informations", "Gets or sets the The Author name associated with the theme."),

            new DesignerActionHeaderItem("Appearance"),
            new DesignerActionPropertyItem("Text", "Text", "Appearance", "Gets or sets the The text associated with the control."),
            new DesignerActionPropertyItem("Font", "Font", "Appearance", "Gets or sets the The font associated with the control."),
            new DesignerActionPropertyItem("BorderThickness", "BorderThickness", "Appearance", "Gets or sets the border thickness associated with the control."),
        };

            return items;
        }
    }
}