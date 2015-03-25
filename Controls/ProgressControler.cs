﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baq_Sozdik.Controls
{
    public partial class ProgressControler : Control
    {
        public ProgressControler()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            if (AutoStart)
                timer1.Start();
        }

        private int _value = 1;

        private int _interval = 100;

        private Color _circleColor = Color.FromArgb(20, 20, 20);

        private bool _autoStart;

        private bool _stopped = true;

        private float _circleSize = 1.0F;

        private int _numberOfCircles = 8;

        private int _numberOfVisibleCircles = 8;

        private RotationType _rotation = RotationType.Clockwise;

        private float _percentage;

        private bool _showPercentage;

        private bool _showText;

        private TextDisplayModes _textDisplay = TextDisplayModes.None;


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                IncreaseValue();
                Invalidate();
            }
        }

        private void IncreaseValue()
        {
            if (_value + 1 <= _numberOfCircles)
                _value++;
            else
                _value = 1;
        }

        [DefaultValue(typeof(Color), "20, 20, 20")]
        [Description("Gets or sets the base color for the circles.")]
        [Category("Appearance")]
        public Color CircleColor
        {
            get { return _circleColor; }
            set
            {
                _circleColor = value;
                Invalidate();
            }
        }

        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the animation should start automatically.")]
        [Category("Behavior")]
        public bool AutoStart
        {
            get { return _autoStart; }
            set
            {
                _autoStart = value;

                if (_autoStart && !DesignMode)
                    Start();
                else
                    Stop();
            }
        }

        public void Stop()
        {
            timer1.Stop();
            _value = 1;
            _stopped = true;
            Invalidate();
        }

        public void Start()
        {
            timer1.Interval = _interval;
            _stopped = false;
            timer1.Start();
        }

        [DefaultValue(1.0F)]
        [Description("Gets or sets the scale for the circles raging from 0.1 to 1.0.")]
        [Category("Appearance")]
        public float CircleSize
        {
            get { return _circleSize; }
            set
            {
                if (value <= 0.0F)
                    _circleSize = 0.1F;
                else
                    _circleSize = value > 1.0F ? 1.0F : value;

                Invalidate();
            }
        }

        [DefaultValue(75)]
        [Description("Gets or sets the animation speed.")]
        [Category("Behavior")]
        public int AnimationSpeed
        {
            get { return (-_interval + 400) / 4; }
            set
            {
                checked
                {
                    int interval = 400 - (value * 4);

                    if (interval < 10)
                        _interval = 10;
                    else
                        _interval = interval > 400 ? 400 : interval;

                    timer1.Interval = _interval;
                }
            }
        }

        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("Behavior")]
        public int NumberOfCircles
        {
            get { return _numberOfCircles; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer.");

                _numberOfCircles = value;
                Invalidate();
            }
        }

        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("Behavior")]
        public int NumberOfVisibleCircles
        {
            get { return _numberOfVisibleCircles; }
            set
            {
                if (value <= 0 || value > _numberOfCircles)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer and less than or equal to the number of circles.");

                _numberOfVisibleCircles = value;
                Invalidate();
            }
        }

        [DefaultValue(RotationType.Clockwise)]
        [Description("Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.")]
        [Category("Behavior")]
        public RotationType Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }

        [DefaultValue(0)]
        [Description("Gets or sets the percentage to show on the control.")]
        [Category("Appearance")]
        public float Percentage
        {
            get { return _percentage; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("value", "Percentage must be a positive integer between 0 and 100.");

                _percentage = value;
            }
        }

        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the percentage value should be shown.")]
        [Category("Behavior")]
        public bool ShowPercentage
        {
            get { return _showPercentage; }
            set
            {
                _showPercentage = value;

                _textDisplay = _showPercentage
                                   ? _textDisplay | TextDisplayModes.Percentage
                                   : _textDisplay & ~TextDisplayModes.Percentage;
                Invalidate();
            }
        }

        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the control text should be shown.")]
        [Category("Behavior")]
        public bool ShowText
        {
            get { return _showText; }
            set
            {
                _showText = value;

                _textDisplay = _showText
                                   ? _textDisplay | TextDisplayModes.Text
                                   : _textDisplay & ~TextDisplayModes.Text;
                Invalidate();
            }
        }

        [DefaultValue(TextDisplayModes.None)]
        [Description("Gets or sets the property that will be shown in the control.")]
        [Category("Appearance")]
        public TextDisplayModes TextDisplay
        {
            get { return _textDisplay; }
            set
            {
                _textDisplay = value;

                _showText = (_textDisplay & TextDisplayModes.Text) == TextDisplayModes.Text;
                _showPercentage = (_textDisplay & TextDisplayModes.Percentage) == TextDisplayModes.Percentage;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            float angle = 360.0F / _numberOfCircles;

            GraphicsState oldState = e.Graphics.Save();

            e.Graphics.TranslateTransform(Width / 2.0F, Height / 2.0F);
            e.Graphics.RotateTransform(angle * _value * (int)_rotation);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            for (int i = 1; i <= _numberOfCircles; i++)
            {
                int alphaValue = (255.0F * (i / (float)_numberOfVisibleCircles)) > 255.0 ? 0 : (int)(255.0F * (i / (float)_numberOfVisibleCircles));
                int alpha = _stopped ? (int)(255.0F * (1.0F / 8.0F)) : alphaValue;

                Color drawColor = Color.FromArgb(alpha, _circleColor);

                using (SolidBrush brush = new SolidBrush(drawColor))
                {
                    float sizeRate = 12F / _circleSize;
                    float size = Width / sizeRate;

                    float diff = (Width / 50F) - size;

                    float x = (Width / 9.0F) + diff;
                    float y = (Height / 9.0F) + diff;
                    e.Graphics.FillEllipse(brush, x, y, size, size);
                    e.Graphics.RotateTransform(angle * (int)_rotation);
                }
            }

            e.Graphics.Restore(oldState);

            string percent = GetDrawText();

            if (!string.IsNullOrEmpty(percent))
            {
                SizeF textSize = e.Graphics.MeasureString(percent, Font);
                float textX = (Width / 2.0F) - (textSize.Width / 2.0F);
                float textY = (Height / 2.0F) - (textSize.Height / 2.0F);
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                RectangleF rectangle = new RectangleF(textX, textY, textSize.Width, textSize.Height);


                using (SolidBrush textBrush = new SolidBrush(ForeColor))
                {
                    e.Graphics.DrawString(percent, Font, textBrush, rectangle, format);
                }
            }

            base.OnPaint(e);
        }

        private string GetDrawText()
        {
            string percent = string.Format(CultureInfo.CurrentCulture, "{0:0.##} %", _percentage);

            if (_showText && _showPercentage)
                return string.Format("{0}{1}{2}", percent, Environment.NewLine, Text);

            if (_showText)
                return Text;

            if (_showPercentage)
                return percent;

            return string.Empty;
        }

        protected override void OnResize(EventArgs e)
        {
            SetNewSize();
            base.OnResize(e);
        }

        private void SetNewSize()
        {
            int size = Math.Max(Width, Height);
            Size = new Size(size, size);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            SetNewSize();
            base.OnSizeChanged(e);
        }


    }
}
