/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI
{

    using System;
    using System.Runtime.InteropServices;


    public class TextEditor : View
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal TextEditor(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.TextEditor_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextEditor obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TextEditor()
        {
            DisposeQueue.Instance.Add(this);
        }

        public override void Dispose()
        {
            if (!Stage.IsInstalled())
            {
                DisposeQueue.Instance.Add(this);
                return;
            }

            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicPINVOKE.delete_TextEditor(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }



        /**
          * @brief Event arguments that passed via TextChanged signal
          *
          */
        public class TextChangedEventArgs : EventArgs
        {
            private TextEditor _textEditor;
            /**
              * @brief TextEditor - is the texteditor control which has the text contents changed.
              *
              */
            public TextEditor TextEditor
            {
                get
                {
                    return _textEditor;
                }
                set
                {
                    _textEditor = value;
                }
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void TextChangedCallbackDelegate(IntPtr textEditor);
        private EventHandler<TextChangedEventArgs> _textEditorTextChangedEventHandler;
        private TextChangedCallbackDelegate _textEditorTextChangedCallbackDelegate;

        /**
          * @brief Event for TextChanged signal which can be used to subscribe/unsubscribe the event handler
          * (in the type of TextChangedEventHandler-DaliEventHandler<object,TextChangedEventArgs>) 
          * provided by the user. TextChanged signal is emitted when the text changes.
          */
        public event EventHandler<TextChangedEventArgs> TextChanged
        {
            add
            {
                if (_textEditorTextChangedEventHandler == null)
                {
                    _textEditorTextChangedCallbackDelegate = (OnTextChanged);
                    TextChangedSignal().Connect(_textEditorTextChangedCallbackDelegate);
                }
                _textEditorTextChangedEventHandler += value;
            }
            remove
            {
                _textEditorTextChangedEventHandler -= value;
                if (_textEditorTextChangedEventHandler == null && _textEditorTextChangedCallbackDelegate != null)
                {
                    TextChangedSignal().Disconnect(_textEditorTextChangedCallbackDelegate);
                }
            }
        }

        private void OnTextChanged(IntPtr textEditor)
        {
            TextChangedEventArgs e = new TextChangedEventArgs();

            // Populate all members of "e" (TextChangedEventArgs) with real data
            e.TextEditor = Tizen.NUI.TextEditor.GetTextEditorFromPtr(textEditor);

            if (_textEditorTextChangedEventHandler != null)
            {
                //here we send all data to user event handlers
                _textEditorTextChangedEventHandler(this, e);
            }

        }

        internal static TextEditor GetTextEditorFromPtr(global::System.IntPtr cPtr)
        {
            TextEditor ret = new TextEditor(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }


        internal class Property : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal Property(global::System.IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
            }

            ~Property()
            {
                Dispose();
            }

            public virtual void Dispose()
            {
                lock (this)
                {
                    if (swigCPtr.Handle != global::System.IntPtr.Zero)
                    {
                        if (swigCMemOwn)
                        {
                            swigCMemOwn = false;
                            NDalicPINVOKE.delete_TextEditor_Property(swigCPtr);
                        }
                        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                    }
                    global::System.GC.SuppressFinalize(this);
                }
            }

            internal Property() : this(NDalicPINVOKE.new_TextEditor_Property(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            internal static readonly int RENDERING_BACKEND = NDalicPINVOKE.TextEditor_Property_RENDERING_BACKEND_get();
            internal static readonly int TEXT = NDalicPINVOKE.TextEditor_Property_TEXT_get();
            internal static readonly int TEXT_COLOR = NDalicPINVOKE.TextEditor_Property_TEXT_COLOR_get();
            internal static readonly int FONT_FAMILY = NDalicPINVOKE.TextEditor_Property_FONT_FAMILY_get();
            internal static readonly int FONT_STYLE = NDalicPINVOKE.TextEditor_Property_FONT_STYLE_get();
            internal static readonly int POINT_SIZE = NDalicPINVOKE.TextEditor_Property_POINT_SIZE_get();
            internal static readonly int HORIZONTAL_ALIGNMENT = NDalicPINVOKE.TextEditor_Property_HORIZONTAL_ALIGNMENT_get();
            internal static readonly int SCROLL_THRESHOLD = NDalicPINVOKE.TextEditor_Property_SCROLL_THRESHOLD_get();
            internal static readonly int SCROLL_SPEED = NDalicPINVOKE.TextEditor_Property_SCROLL_SPEED_get();
            internal static readonly int PRIMARY_CURSOR_COLOR = NDalicPINVOKE.TextEditor_Property_PRIMARY_CURSOR_COLOR_get();
            internal static readonly int SECONDARY_CURSOR_COLOR = NDalicPINVOKE.TextEditor_Property_SECONDARY_CURSOR_COLOR_get();
            internal static readonly int ENABLE_CURSOR_BLINK = NDalicPINVOKE.TextEditor_Property_ENABLE_CURSOR_BLINK_get();
            internal static readonly int CURSOR_BLINK_INTERVAL = NDalicPINVOKE.TextEditor_Property_CURSOR_BLINK_INTERVAL_get();
            internal static readonly int CURSOR_BLINK_DURATION = NDalicPINVOKE.TextEditor_Property_CURSOR_BLINK_DURATION_get();
            internal static readonly int CURSOR_WIDTH = NDalicPINVOKE.TextEditor_Property_CURSOR_WIDTH_get();
            internal static readonly int GRAB_HANDLE_IMAGE = NDalicPINVOKE.TextEditor_Property_GRAB_HANDLE_IMAGE_get();
            internal static readonly int GRAB_HANDLE_PRESSED_IMAGE = NDalicPINVOKE.TextEditor_Property_GRAB_HANDLE_PRESSED_IMAGE_get();
            internal static readonly int SELECTION_HANDLE_IMAGE_LEFT = NDalicPINVOKE.TextEditor_Property_SELECTION_HANDLE_IMAGE_LEFT_get();
            internal static readonly int SELECTION_HANDLE_IMAGE_RIGHT = NDalicPINVOKE.TextEditor_Property_SELECTION_HANDLE_IMAGE_RIGHT_get();
            internal static readonly int SELECTION_HANDLE_PRESSED_IMAGE_LEFT = NDalicPINVOKE.TextEditor_Property_SELECTION_HANDLE_PRESSED_IMAGE_LEFT_get();
            internal static readonly int SELECTION_HANDLE_PRESSED_IMAGE_RIGHT = NDalicPINVOKE.TextEditor_Property_SELECTION_HANDLE_PRESSED_IMAGE_RIGHT_get();
            internal static readonly int SELECTION_HANDLE_MARKER_IMAGE_LEFT = NDalicPINVOKE.TextEditor_Property_SELECTION_HANDLE_MARKER_IMAGE_LEFT_get();
            internal static readonly int SELECTION_HANDLE_MARKER_IMAGE_RIGHT = NDalicPINVOKE.TextEditor_Property_SELECTION_HANDLE_MARKER_IMAGE_RIGHT_get();
            internal static readonly int SELECTION_HIGHLIGHT_COLOR = NDalicPINVOKE.TextEditor_Property_SELECTION_HIGHLIGHT_COLOR_get();
            internal static readonly int DECORATION_BOUNDING_BOX = NDalicPINVOKE.TextEditor_Property_DECORATION_BOUNDING_BOX_get();
            internal static readonly int ENABLE_MARKUP = NDalicPINVOKE.TextEditor_Property_ENABLE_MARKUP_get();
            internal static readonly int INPUT_COLOR = NDalicPINVOKE.TextEditor_Property_INPUT_COLOR_get();
            internal static readonly int INPUT_FONT_FAMILY = NDalicPINVOKE.TextEditor_Property_INPUT_FONT_FAMILY_get();
            internal static readonly int INPUT_FONT_STYLE = NDalicPINVOKE.TextEditor_Property_INPUT_FONT_STYLE_get();
            internal static readonly int INPUT_POINT_SIZE = NDalicPINVOKE.TextEditor_Property_INPUT_POINT_SIZE_get();
            internal static readonly int LINE_SPACING = NDalicPINVOKE.TextEditor_Property_LINE_SPACING_get();
            internal static readonly int INPUT_LINE_SPACING = NDalicPINVOKE.TextEditor_Property_INPUT_LINE_SPACING_get();
            internal static readonly int UNDERLINE = NDalicPINVOKE.TextEditor_Property_UNDERLINE_get();
            internal static readonly int INPUT_UNDERLINE = NDalicPINVOKE.TextEditor_Property_INPUT_UNDERLINE_get();
            internal static readonly int SHADOW = NDalicPINVOKE.TextEditor_Property_SHADOW_get();
            internal static readonly int INPUT_SHADOW = NDalicPINVOKE.TextEditor_Property_INPUT_SHADOW_get();
            internal static readonly int EMBOSS = NDalicPINVOKE.TextEditor_Property_EMBOSS_get();
            internal static readonly int INPUT_EMBOSS = NDalicPINVOKE.TextEditor_Property_INPUT_EMBOSS_get();
            internal static readonly int OUTLINE = NDalicPINVOKE.TextEditor_Property_OUTLINE_get();
            internal static readonly int INPUT_OUTLINE = NDalicPINVOKE.TextEditor_Property_INPUT_OUTLINE_get();

        }

        internal class InputStyle : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal InputStyle(global::System.IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InputStyle obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
            }

            ~InputStyle()
            {
                Dispose();
            }

            public virtual void Dispose()
            {
                lock (this)
                {
                    if (swigCPtr.Handle != global::System.IntPtr.Zero)
                    {
                        if (swigCMemOwn)
                        {
                            swigCMemOwn = false;
                            NDalicPINVOKE.delete_TextEditor_InputStyle(swigCPtr);
                        }
                        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                    }
                    global::System.GC.SuppressFinalize(this);
                }
            }

            internal InputStyle() : this(NDalicPINVOKE.new_TextEditor_InputStyle(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            internal enum Mask
            {
                None = 0x0000,
                Color = 0x0001,
                FontFamily = 0x0002,
                PointSize = 0x0004,
                FontStyle = 0x0008,
                LineSpacing = 0x0010,
                Underline = 0x0020,
                Shadow = 0x0040,
                Emboss = 0x0080,
                Outline = 0x0100
            }

        }

        public TextEditor() : this(NDalicPINVOKE.TextEditor_New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        internal TextEditor(TextEditor handle) : this(NDalicPINVOKE.new_TextEditor__SWIG_1(TextEditor.getCPtr(handle)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal TextEditor Assign(TextEditor handle)
        {
            TextEditor ret = new TextEditor(NDalicPINVOKE.TextEditor_Assign(swigCPtr, TextEditor.getCPtr(handle)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public new static TextEditor DownCast(BaseHandle handle)
        {
            TextEditor ret = new TextEditor(NDalicPINVOKE.TextEditor_DownCast(BaseHandle.getCPtr(handle)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal TextEditorSignal TextChangedSignal()
        {
            TextEditorSignal ret = new TextEditorSignal(NDalicPINVOKE.TextEditor_TextChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__TextEditor_Dali__Toolkit__TextEditor__InputStyle__MaskF_t InputStyleChangedSignal()
        {
            SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__TextEditor_Dali__Toolkit__TextEditor__InputStyle__MaskF_t ret = new SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__TextEditor_Dali__Toolkit__TextEditor__InputStyle__MaskF_t(NDalicPINVOKE.TextEditor_InputStyleChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal enum PropertyRange
        {
            PROPERTY_START_INDEX = PropertyRanges.PROPERTY_REGISTRATION_START_INDEX,
            PROPERTY_END_INDEX = View.PropertyRange.PROPERTY_START_INDEX + 1000
        }

        public int RenderingBackend
        {
            get
            {
                int temp = 0;
                GetProperty(TextEditor.Property.RENDERING_BACKEND).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.RENDERING_BACKEND, new Tizen.NUI.PropertyValue(value));
            }
        }
        public string Text
        {
            get
            {
                string temp;
                GetProperty(TextEditor.Property.TEXT).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.TEXT, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Vector4 TextColor
        {
            get
            {
                Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(TextEditor.Property.TEXT_COLOR).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.TEXT_COLOR, new Tizen.NUI.PropertyValue(value));
            }
        }
        public string FontFamily
        {
            get
            {
                string temp;
                GetProperty(TextEditor.Property.FONT_FAMILY).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.FONT_FAMILY, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap FontStyle
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.FONT_STYLE).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.FONT_STYLE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float PointSize
        {
            get
            {
                float temp = 0.0f;
                GetProperty(TextEditor.Property.POINT_SIZE).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.POINT_SIZE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public string HorizontalAlignment
        {
            get
            {
                string temp;
                GetProperty(TextEditor.Property.HORIZONTAL_ALIGNMENT).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.HORIZONTAL_ALIGNMENT, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float ScrollThreshold
        {
            get
            {
                float temp = 0.0f;
                GetProperty(TextEditor.Property.SCROLL_THRESHOLD).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SCROLL_THRESHOLD, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float ScrollSpeed
        {
            get
            {
                float temp = 0.0f;
                GetProperty(TextEditor.Property.SCROLL_SPEED).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SCROLL_SPEED, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Vector4 PrimaryCursorColor
        {
            get
            {
                Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(TextEditor.Property.PRIMARY_CURSOR_COLOR).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.PRIMARY_CURSOR_COLOR, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Vector4 SecondaryCursorColor
        {
            get
            {
                Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(TextEditor.Property.SECONDARY_CURSOR_COLOR).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SECONDARY_CURSOR_COLOR, new Tizen.NUI.PropertyValue(value));
            }
        }
        public bool EnableCursorBlink
        {
            get
            {
                bool temp = false;
                GetProperty(TextEditor.Property.ENABLE_CURSOR_BLINK).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.ENABLE_CURSOR_BLINK, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float CursorBlinkInterval
        {
            get
            {
                float temp = 0.0f;
                GetProperty(TextEditor.Property.CURSOR_BLINK_INTERVAL).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.CURSOR_BLINK_INTERVAL, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float CursorBlinkDuration
        {
            get
            {
                float temp = 0.0f;
                GetProperty(TextEditor.Property.CURSOR_BLINK_DURATION).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.CURSOR_BLINK_DURATION, new Tizen.NUI.PropertyValue(value));
            }
        }
        public int CursorWidth
        {
            get
            {
                int temp = 0;
                GetProperty(TextEditor.Property.CURSOR_WIDTH).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.CURSOR_WIDTH, new Tizen.NUI.PropertyValue(value));
            }
        }
        public string GrabHandleImage
        {
            get
            {
                string temp;
                GetProperty(TextEditor.Property.GRAB_HANDLE_IMAGE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.GRAB_HANDLE_IMAGE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public string GrabHandlePressedImage
        {
            get
            {
                string temp;
                GetProperty(TextEditor.Property.GRAB_HANDLE_PRESSED_IMAGE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.GRAB_HANDLE_PRESSED_IMAGE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap SelectionHandleImageLeft
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.SELECTION_HANDLE_IMAGE_LEFT).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SELECTION_HANDLE_IMAGE_LEFT, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap SelectionHandleImageRight
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.SELECTION_HANDLE_IMAGE_RIGHT).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SELECTION_HANDLE_IMAGE_RIGHT, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap SelectionHandlePressedImageLeft
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.SELECTION_HANDLE_PRESSED_IMAGE_LEFT).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SELECTION_HANDLE_PRESSED_IMAGE_LEFT, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap SelectionHandlePressedImageRight
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.SELECTION_HANDLE_PRESSED_IMAGE_RIGHT).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SELECTION_HANDLE_PRESSED_IMAGE_RIGHT, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap SelectionHandleMarkerImageLeft
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.SELECTION_HANDLE_MARKER_IMAGE_LEFT).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SELECTION_HANDLE_MARKER_IMAGE_LEFT, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap SelectionHandleMarkerImageRight
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.SELECTION_HANDLE_MARKER_IMAGE_RIGHT).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SELECTION_HANDLE_MARKER_IMAGE_RIGHT, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Vector4 SelectionHighlightColor
        {
            get
            {
                Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(TextEditor.Property.SELECTION_HIGHLIGHT_COLOR).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SELECTION_HIGHLIGHT_COLOR, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Rectangle DecorationBoundingBox
        {
            get
            {
                Rectangle temp = new Rectangle(0, 0, 0, 0);
                GetProperty(TextEditor.Property.DECORATION_BOUNDING_BOX).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.DECORATION_BOUNDING_BOX, new Tizen.NUI.PropertyValue(value));
            }
        }
        public bool EnableMarkup
        {
            get
            {
                bool temp = false;
                GetProperty(TextEditor.Property.ENABLE_MARKUP).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.ENABLE_MARKUP, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Vector4 InputColor
        {
            get
            {
                Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(TextEditor.Property.INPUT_COLOR).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.INPUT_COLOR, new Tizen.NUI.PropertyValue(value));
            }
        }
        public string InputFontFamily
        {
            get
            {
                string temp;
                GetProperty(TextEditor.Property.INPUT_FONT_FAMILY).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.INPUT_FONT_FAMILY, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap InputFontStyle
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.INPUT_FONT_STYLE).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.INPUT_FONT_STYLE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float InputPointSize
        {
            get
            {
                float temp = 0.0f;
                GetProperty(TextEditor.Property.INPUT_POINT_SIZE).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.INPUT_POINT_SIZE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float LineSpacing
        {
            get
            {
                float temp = 0.0f;
                GetProperty(TextEditor.Property.LINE_SPACING).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.LINE_SPACING, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float InputLineSpacing
        {
            get
            {
                float temp = 0.0f;
                GetProperty(TextEditor.Property.INPUT_LINE_SPACING).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.INPUT_LINE_SPACING, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap Underline
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.UNDERLINE).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.UNDERLINE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap InputUnderline
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.INPUT_UNDERLINE).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.INPUT_UNDERLINE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap Shadow
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.SHADOW).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.SHADOW, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap InputShadow
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.INPUT_SHADOW).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.INPUT_SHADOW, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap Emboss
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.EMBOSS).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.EMBOSS, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap InputEmboss
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.INPUT_EMBOSS).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.INPUT_EMBOSS, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap Outline
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.OUTLINE).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.OUTLINE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public PropertyMap InputOutline
        {
            get
            {
                PropertyMap temp = new PropertyMap();
                GetProperty(TextEditor.Property.INPUT_OUTLINE).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(TextEditor.Property.INPUT_OUTLINE, new Tizen.NUI.PropertyValue(value));
            }
        }

    }

}
