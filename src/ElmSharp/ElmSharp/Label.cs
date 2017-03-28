/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace ElmSharp
{
    /// <summary>
    /// Label is a widget to display text, with simple html-like markup.
    /// Inherits Layout
    /// </summary>
    public class Label : Layout
    {
        SmartEvent _slideCompleted;

        /// <summary>
        /// Creates and initializes a new instance of Label class.
        /// </summary>
        /// <param name="parent">The parent is a given container which will be attached by Label as a child. It's <see cref="EvasObject"/> type.</param>
        public Label(EvasObject parent) : base(parent)
        {
            _slideCompleted = new SmartEvent(this, this.RealHandle, "slide,end");
            _slideCompleted.On += (s, e) =>
            {
                SlideCompleted?.Invoke(this, EventArgs.Empty);
            };
        }

        /// <summary>
        /// SlideCompleted will be triggered when the slide is completed.
        /// </summary>
        public event EventHandler SlideCompleted;

        /// <summary>
        /// Sets or gets wrap width of the label.
        /// </summary>
        public int LineWrapWidth
        {
            get
            {
                return Interop.Elementary.elm_label_wrap_width_get(RealHandle);
            }
            set
            {
                Interop.Elementary.elm_label_wrap_width_set(RealHandle, value);
            }
        }

        /// <summary>
        /// Sets or gets the wrapping behavior of the label.
        /// </summary>
        public WrapType LineWrapType
        {
            get
            {
                return (WrapType)Interop.Elementary.elm_label_line_wrap_get(RealHandle);
            }
            set
            {
                Interop.Elementary.elm_label_line_wrap_set(RealHandle, (int)value);
            }
        }

        /// <summary>
        /// Sets or gets the slide mode of the label widget.
        /// </summary>
        public LabelSlideMode SlideMode
        {
            get
            {
                return (LabelSlideMode)Interop.Elementary.elm_label_slide_mode_get(RealHandle);
            }
            set
            {
                Interop.Elementary.elm_label_slide_mode_set(RealHandle, (int)value);
            }
        }

        /// <summary>
        /// Sets or gets the slide duration of the label.
        /// </summary>
        public double SlideDuration
        {
            get
            {
                return Interop.Elementary.elm_label_slide_duration_get(RealHandle);
            }
            set
            {
                Interop.Elementary.elm_label_slide_duration_set(RealHandle, value);
            }
        }

        /// <summary>
        /// Sets or gets the ellipsis behavior of the label.
        /// </summary>
        public bool IsEllipsis
        {
            get
            {
                return Interop.Elementary.elm_label_ellipsis_get(RealHandle);
            }
            set
            {
                Interop.Elementary.elm_label_ellipsis_set(RealHandle, value);
            }
        }

        /// <summary>
        /// Start slide effect.
        /// </summary>
        public void PlaySlide()
        {
            Interop.Elementary.elm_label_slide_go(RealHandle);
        }

        /// <summary>
        /// Sets the content at a part of a given container widget.
        /// </summary>
        /// <param name="parent">EvasObject</param>
        /// <returns>The new object, otherwise null if it cannot be created</returns>
        protected override IntPtr CreateHandle(EvasObject parent)
        {
            //TODO: Fix this to use layout
            return Interop.Elementary.elm_label_add(parent.Handle);
        }
    }

    /// <summary>
    /// Enumeration for slide mode of a label widget
    /// </summary>
    public enum LabelSlideMode
    {
        /// <summary>
        /// no slide effect
        /// </summary>
        None = 0,
        /// <summary>
        /// slide only if the label area is bigger than the text width length
        /// </summary>
        Auto,
        /// <summary>
        /// slide always
        /// </summary>
        Always
    }
}
